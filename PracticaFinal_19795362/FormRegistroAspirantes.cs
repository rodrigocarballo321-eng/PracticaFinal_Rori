using System;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PracticaFinal_19795362.Data;

namespace PracticaFinal_19795362
{
    public partial class FormRegistroAspirantes : Form
    {
        // Representa un renglón del combo "Tipo de beca", cargado desde la tabla tipos_beca.
        private class TipoBecaItem
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public decimal Monto { get; set; }

            public override string ToString()
            {
                return string.Format("{0} — ${1:0.00}/mes", Nombre, Monto);
            }
        }

        private static readonly Regex RegexSoloLetras =
            new Regex(@"^[A-Za-zÁÉÍÓÚÑÜáéíóúñü ]{1,60}$", RegexOptions.Compiled);

        private static readonly Regex RegexDui =
            new Regex(@"^\d{8}-\d$", RegexOptions.Compiled);

        private static readonly Regex RegexCorreo =
            new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

        public FormRegistroAspirantes()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormRegistroAspirantes_Load);
        }

        private void FormRegistroAspirantes_Load(object sender, EventArgs e)
        {
            dtpNacimiento.Value = DateTime.Today.AddYears(-18);
            CargarTiposBeca();
        }

        /// <summary>
        /// Carga el ComboBox de tipo de beca con los registros activos de la
        /// tabla tipos_beca, mostrando "Nombre — $monto/mes".
        /// </summary>
        private void CargarTiposBeca()
        {
            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    cn.Open();

                    // ¡CORREGIDO! Cambiamos "id_tipo_beca" por "id" para alinearlo con tu tabla de SQL Server
                    const string sql =
                        "SELECT id, nombre, monto " +
                        "FROM tipos_beca WHERE activo = 1 ORDER BY nombre;";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbTipoBeca.Items.Clear();
                        while (reader.Read())
                        {
                            cmbTipoBeca.Items.Add(new TipoBecaItem
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Monto = reader.GetDecimal(2)
                            });
                        }
                    }
                }

                ActualizarEstadoConexion(true);
            }
            catch (SqlException ex)
            {
                ActualizarEstadoConexion(false);
                MessageBox.Show(
                    "No fue posible conectar con la base de datos para cargar los tipos de beca.\n\nDetalles del error:\n" + ex.Message,
                    "Error de conexión SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ActualizarEstadoConexion(false);
                MessageBox.Show(
                    "Ocurrió un error inesperado al cargar los tipos de beca.\n\nDetalles:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Valida todos los campos obligatorios del formulario.
        /// Devuelve true si todo es válido; en caso contrario, arma un
        /// mensaje amigable con todos los errores encontrados.
        /// </summary>
        private bool ValidarFormulario(out string mensajeError)
        {
            StringBuilder errores = new StringBuilder();

            if (!RegexDui.IsMatch(txtDui.Text.Trim()))
                errores.AppendLine("- El DUI debe tener el formato 00000000-0.");

            if (!RegexSoloLetras.IsMatch(txtNombres.Text.Trim()))
                errores.AppendLine("- Los nombres solo deben contener letras y espacios (máx. 60 caracteres).");

            if (!RegexSoloLetras.IsMatch(txtApellidos.Text.Trim()))
                errores.AppendLine("- Los apellidos solo deben contener letras y espacios (máx. 60 caracteres).");

            int edad = CalcularEdad(dtpNacimiento.Value.Date);
            if (edad < 15 || edad > 30)
                errores.AppendLine("- La edad del aspirante debe estar entre 15 y 30 años.");

            if (!rbFemenino.Checked && !rbMasculino.Checked)
                errores.AppendLine("- Debe seleccionar el sexo del aspirante.");

            if (!txtTelefono.MaskCompleted || (txtTelefono.Text.Length > 0 &&
                txtTelefono.Text[0] != '6' && txtTelefono.Text[0] != '7'))
                errores.AppendLine("- El teléfono debe tener el formato 0000-0000 e iniciar con 6 o 7.");

            string correo = txtCorreo.Text.Trim();
            if (correo.Length > 0 && !RegexCorreo.IsMatch(correo))
                errores.AppendLine("- El correo electrónico no tiene un formato válido.");

            string institucion = txtInstitucion.Text.Trim();
            if (institucion.Length < 5 || institucion.Length > 100)
                errores.AppendLine("- La institución debe tener entre 5 y 100 caracteres.");

            if (txtPromedio.Value < 6.00m || txtPromedio.Value > 10.00m)
                errores.AppendLine("- El promedio debe estar entre 6.00 y 10.00.");

            if (txtIngreso.Value < 0)
                errores.AppendLine("- El ingreso familiar no puede ser negativo.");

            if (cmbTipoBeca.SelectedItem == null)
                errores.AppendLine("- Debe seleccionar un tipo de beca.");

            mensajeError = errores.ToString();
            return errores.Length == 0;
        }

        private static int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > hoy.AddYears(-edad))
                edad--;
            return edad;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensajeError;
            if (!ValidarFormulario(out mensajeError))
            {
                MessageBox.Show(
                    "Por favor corrija los siguientes datos:" + Environment.NewLine + Environment.NewLine + mensajeError,
                    "Datos incompletos o inválidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            TipoBecaItem tipoBecaSeleccionado = (TipoBecaItem)cmbTipoBeca.SelectedItem;

            try
            {
                using (SqlConnection cn = ConexionBD.ObtenerConexion())
                {
                    cn.Open();

                    // ¡CORREGIDO! Agregamos la columna 'fecha_registro' y su parámetro correspondiente para evitar el error de valor NULL en la base de datos.
                    const string sql =
                        "INSERT INTO aspirantes " +
                        "(dui, nombres, apellidos, fecha_nacimiento, sexo, telefono, correo, " +
                        " institucion, promedio, ingreso_familiar, id_tipo_beca, fecha_registro) " +
                        "VALUES " +
                        "(@Dui, @Nombres, @Apellidos, @FechaNacimiento, @Sexo, @Telefono, @Correo, " +
                        " @Institucion, @Promedio, @IngresoFamiliar, @IdTipoBeca, @FechaRegistro); " +
                        "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Dui", txtDui.Text.Trim());
                        cmd.Parameters.AddWithValue("@Nombres", txtNombres.Text.Trim());
                        cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text.Trim());
                        cmd.Parameters.AddWithValue("@FechaNacimiento", dtpNacimiento.Value.Date);
                        cmd.Parameters.AddWithValue("@Sexo", rbFemenino.Checked ? "F" : "M");
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());

                        object correoValor = string.IsNullOrWhiteSpace(txtCorreo.Text)
                            ? (object)DBNull.Value
                            : txtCorreo.Text.Trim();
                        cmd.Parameters.AddWithValue("@Correo", correoValor);

                        cmd.Parameters.AddWithValue("@Institucion", txtInstitucion.Text.Trim());
                        cmd.Parameters.AddWithValue("@Promedio", txtPromedio.Value);
                        cmd.Parameters.AddWithValue("@IngresoFamiliar", txtIngreso.Value);
                        cmd.Parameters.AddWithValue("@IdTipoBeca", tipoBecaSeleccionado.Id);

                        // Enviamos la fecha y hora actual del sistema
                        cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);

                        object resultado = cmd.ExecuteScalar();
                        int nuevoId = Convert.ToInt32(resultado);

                        ActualizarEstadoConexion(true);

                        MessageBox.Show(
                            string.Format("Aspirante registrado correctamente con el ID {0}.", nuevoId),
                            "Registro exitoso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LimpiarFormulario();
                    }
                }
            }
            catch (SqlException ex)
            {
                ActualizarEstadoConexion(false);
                MessageBox.Show(
                    "No fue posible guardar el registro.\n\nDetalles del error SQL:\n" + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ActualizarEstadoConexion(false);
                MessageBox.Show(
                    "Ocurrió un error inesperado al guardar el registro.\n\nDetalles:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtDui.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            dtpNacimiento.Value = DateTime.Today.AddYears(-18);
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtInstitucion.Clear();
            txtPromedio.Value = txtPromedio.Minimum;
            txtIngreso.Value = txtIngreso.Minimum;
            if (cmbTipoBeca.Items.Count > 0)
                cmbTipoBeca.SelectedIndex = 0;
            else
                cmbTipoBeca.SelectedIndex = -1;

            txtDui.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea cancelar el registro y cerrar el formulario?",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "SisBecas — Registro de Aspirantes" + Environment.NewLine +
                "Alcaldía de Colón" + Environment.NewLine +
                "Práctica Final 19795362",
                "Acerca de",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ActualizarEstadoConexion(bool conectado)
        {
            tsslEstadoConexion.Text = conectado
                ? "Conectado a: " + ConexionBD.ObtenerConexion().Database + " | " + Environment.MachineName
                : "Sin conexión";
        }
    }
}