namespace PracticaFinal_19795362
{
    partial class FormRegistroAspirantes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbDeshacer;
        private System.Windows.Forms.ToolStripButton tsbEliminar;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslEstadoConexion;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuario;

        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;

        private System.Windows.Forms.GroupBox grpContacto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;

        private System.Windows.Forms.GroupBox grpAcademico;
        private System.Windows.Forms.Label lblInstitucion;
        private System.Windows.Forms.TextBox txtInstitucion;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.NumericUpDown txtPromedio;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.NumericUpDown txtIngreso;
        private System.Windows.Forms.Label lblTipoBeca;
        private System.Windows.Forms.ComboBox cmbTipoBeca;

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDeshacer = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();

            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUsuario = new System.Windows.Forms.ToolStripStatusLabel();

            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblDui = new System.Windows.Forms.Label();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblSexo = new System.Windows.Forms.Label();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();

            this.grpContacto = new System.Windows.Forms.GroupBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();

            this.grpAcademico = new System.Windows.Forms.GroupBox();
            this.lblInstitucion = new System.Windows.Forms.Label();
            this.txtInstitucion = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.NumericUpDown();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtIngreso = new System.Windows.Forms.NumericUpDown();
            this.lblTipoBeca = new System.Windows.Forms.Label();
            this.cmbTipoBeca = new System.Windows.Forms.ComboBox();

            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();

            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpDatosPersonales.SuspendLayout();
            this.grpSexo.SuspendLayout();
            this.grpContacto.SuspendLayout();
            this.grpAcademico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngreso)).BeginInit();
            this.SuspendLayout();

            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.archivoToolStripMenuItem,
                this.edicionToolStripMenuItem,
                this.registrosToolStripMenuItem,
                this.reportesToolStripMenuItem,
                this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;

            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Text = "&Archivo";

            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);

            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.cortarToolStripMenuItem,
                this.copiarToolStripMenuItem,
                this.pegarToolStripMenuItem});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Text = "&Edición";

            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Text = "Cor&tar";

            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Text = "&Copiar";

            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Text = "&Pegar";

            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.nuevoToolStripMenuItem,
                this.guardarToolStripMenuItem,
                this.eliminarToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Text = "&Registros";

            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Text = "&Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.btnGuardar_Click);

            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Text = "&Eliminar";

            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.generarReporteToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Text = "Re&portes";

            this.generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            this.generarReporteToolStripMenuItem.Text = "&Generar reporte";

            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Text = "A&yuda";

            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Text = "&Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);

            //
            // toolStrip1
            //
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsbNuevo,
                this.tsbGuardar,
                this.tsbBuscar,
                this.toolStripSeparator1,
                this.tsbDeshacer,
                this.tsbEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(624, 25);
            this.toolStrip1.TabIndex = 1;

            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNuevo.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;

            this.tsbDeshacer.Text = "Deshacer";
            this.tsbDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDeshacer.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;

            //
            // statusStrip1
            //
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsslEstadoConexion,
                this.tsslUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 606);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 2;

            this.tsslEstadoConexion.Name = "tsslEstadoConexion";
            this.tsslEstadoConexion.Text = "Sin conexión";
            this.tsslEstadoConexion.Spring = true;
            this.tsslEstadoConexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.tsslUsuario.Name = "tsslUsuario";
            this.tsslUsuario.Text = "Usuario: empleado.alcaldia    Listo";
            this.tsslUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            //
            // grpDatosPersonales
            //
            this.grpDatosPersonales.Controls.Add(this.lblDui);
            this.grpDatosPersonales.Controls.Add(this.txtDui);
            this.grpDatosPersonales.Controls.Add(this.lblNombres);
            this.grpDatosPersonales.Controls.Add(this.txtNombres);
            this.grpDatosPersonales.Controls.Add(this.lblApellidos);
            this.grpDatosPersonales.Controls.Add(this.txtApellidos);
            this.grpDatosPersonales.Controls.Add(this.lblFechaNacimiento);
            this.grpDatosPersonales.Controls.Add(this.dtpNacimiento);
            this.grpDatosPersonales.Controls.Add(this.lblSexo);
            this.grpDatosPersonales.Controls.Add(this.grpSexo);
            this.grpDatosPersonales.Location = new System.Drawing.Point(12, 58);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(596, 200);
            this.grpDatosPersonales.TabIndex = 3;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos personales";

            this.lblDui.AutoSize = false;
            this.lblDui.Location = new System.Drawing.Point(10, 27);
            this.lblDui.Size = new System.Drawing.Size(120, 20);
            this.lblDui.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDui.Text = "DUI *:";

            this.txtDui.Location = new System.Drawing.Point(140, 24);
            this.txtDui.Size = new System.Drawing.Size(150, 23);
            this.txtDui.MaxLength = 10;
            this.txtDui.Name = "txtDui";

            this.lblNombres.AutoSize = false;
            this.lblNombres.Location = new System.Drawing.Point(10, 57);
            this.lblNombres.Size = new System.Drawing.Size(120, 20);
            this.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNombres.Text = "Nombres *:";

            this.txtNombres.Location = new System.Drawing.Point(140, 54);
            this.txtNombres.Size = new System.Drawing.Size(320, 23);
            this.txtNombres.MaxLength = 60;
            this.txtNombres.Name = "txtNombres";

            this.lblApellidos.AutoSize = false;
            this.lblApellidos.Location = new System.Drawing.Point(10, 87);
            this.lblApellidos.Size = new System.Drawing.Size(120, 20);
            this.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblApellidos.Text = "Apellidos *:";

            this.txtApellidos.Location = new System.Drawing.Point(140, 84);
            this.txtApellidos.Size = new System.Drawing.Size(320, 23);
            this.txtApellidos.MaxLength = 60;
            this.txtApellidos.Name = "txtApellidos";

            this.lblFechaNacimiento.AutoSize = false;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(10, 117);
            this.lblFechaNacimiento.Size = new System.Drawing.Size(120, 20);
            this.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFechaNacimiento.Text = "Fecha de nacim. *:";

            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(140, 114);
            this.dtpNacimiento.Size = new System.Drawing.Size(150, 23);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.MaxDate = System.DateTime.Today;

            this.lblSexo.AutoSize = false;
            this.lblSexo.Location = new System.Drawing.Point(10, 152);
            this.lblSexo.Size = new System.Drawing.Size(120, 20);
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSexo.Text = "Sexo *:";

            //
            // grpSexo
            //
            this.grpSexo.Controls.Add(this.rbFemenino);
            this.grpSexo.Controls.Add(this.rbMasculino);
            this.grpSexo.Location = new System.Drawing.Point(140, 145);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(220, 45);
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";

            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(10, 18);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Text = "Femenino";

            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(110, 18);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Text = "Masculino";

            //
            // grpContacto
            //
            this.grpContacto.Controls.Add(this.lblTelefono);
            this.grpContacto.Controls.Add(this.txtTelefono);
            this.grpContacto.Controls.Add(this.lblCorreo);
            this.grpContacto.Controls.Add(this.txtCorreo);
            this.grpContacto.Location = new System.Drawing.Point(12, 266);
            this.grpContacto.Name = "grpContacto";
            this.grpContacto.Size = new System.Drawing.Size(596, 95);
            this.grpContacto.TabIndex = 4;
            this.grpContacto.TabStop = false;
            this.grpContacto.Text = "Contacto";

            this.lblTelefono.AutoSize = false;
            this.lblTelefono.Location = new System.Drawing.Point(10, 27);
            this.lblTelefono.Size = new System.Drawing.Size(120, 20);
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTelefono.Text = "Teléfono *:";

            this.txtTelefono.Mask = "0000-0000";
            this.txtTelefono.Location = new System.Drawing.Point(140, 24);
            this.txtTelefono.Size = new System.Drawing.Size(150, 23);
            this.txtTelefono.Name = "txtTelefono";

            this.lblCorreo.AutoSize = false;
            this.lblCorreo.Location = new System.Drawing.Point(10, 57);
            this.lblCorreo.Size = new System.Drawing.Size(120, 20);
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCorreo.Text = "Correo electrónico:";

            this.txtCorreo.Location = new System.Drawing.Point(140, 54);
            this.txtCorreo.Size = new System.Drawing.Size(320, 23);
            this.txtCorreo.MaxLength = 100;
            this.txtCorreo.Name = "txtCorreo";

            //
            // grpAcademico
            //
            this.grpAcademico.Controls.Add(this.lblInstitucion);
            this.grpAcademico.Controls.Add(this.txtInstitucion);
            this.grpAcademico.Controls.Add(this.lblPromedio);
            this.grpAcademico.Controls.Add(this.txtPromedio);
            this.grpAcademico.Controls.Add(this.lblIngreso);
            this.grpAcademico.Controls.Add(this.txtIngreso);
            this.grpAcademico.Controls.Add(this.lblTipoBeca);
            this.grpAcademico.Controls.Add(this.cmbTipoBeca);
            this.grpAcademico.Location = new System.Drawing.Point(12, 371);
            this.grpAcademico.Name = "grpAcademico";
            this.grpAcademico.Size = new System.Drawing.Size(596, 180);
            this.grpAcademico.TabIndex = 5;
            this.grpAcademico.TabStop = false;
            this.grpAcademico.Text = "Datos académicos y económicos";

            this.lblInstitucion.AutoSize = false;
            this.lblInstitucion.Location = new System.Drawing.Point(10, 27);
            this.lblInstitucion.Size = new System.Drawing.Size(120, 20);
            this.lblInstitucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInstitucion.Text = "Institución *:";

            this.txtInstitucion.Location = new System.Drawing.Point(140, 24);
            this.txtInstitucion.Size = new System.Drawing.Size(320, 23);
            this.txtInstitucion.MaxLength = 100;
            this.txtInstitucion.Name = "txtInstitucion";

            this.lblPromedio.AutoSize = false;
            this.lblPromedio.Location = new System.Drawing.Point(10, 57);
            this.lblPromedio.Size = new System.Drawing.Size(120, 20);
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPromedio.Text = "Promedio *:";

            this.txtPromedio.DecimalPlaces = 2;
            this.txtPromedio.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            this.txtPromedio.Location = new System.Drawing.Point(140, 54);
            this.txtPromedio.Size = new System.Drawing.Size(100, 23);
            this.txtPromedio.Minimum = new decimal(new int[] { 600, 0, 0, 131072 });
            this.txtPromedio.Maximum = new decimal(new int[] { 1000, 0, 0, 131072 });
            this.txtPromedio.Value = new decimal(new int[] { 600, 0, 0, 131072 });
            this.txtPromedio.Name = "txtPromedio";

            this.lblIngreso.AutoSize = false;
            this.lblIngreso.Location = new System.Drawing.Point(10, 87);
            this.lblIngreso.Size = new System.Drawing.Size(120, 20);
            this.lblIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIngreso.Text = "Ingreso familiar *:";

            this.txtIngreso.DecimalPlaces = 2;
            this.txtIngreso.ThousandsSeparator = true;
            this.txtIngreso.Location = new System.Drawing.Point(140, 84);
            this.txtIngreso.Size = new System.Drawing.Size(150, 23);
            this.txtIngreso.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.txtIngreso.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.txtIngreso.Name = "txtIngreso";

            this.lblTipoBeca.AutoSize = false;
            this.lblTipoBeca.Location = new System.Drawing.Point(10, 117);
            this.lblTipoBeca.Size = new System.Drawing.Size(120, 20);
            this.lblTipoBeca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTipoBeca.Text = "Tipo de beca *:";

            this.cmbTipoBeca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBeca.Location = new System.Drawing.Point(140, 114);
            this.cmbTipoBeca.Size = new System.Drawing.Size(320, 23);
            this.cmbTipoBeca.Name = "cmbTipoBeca";

            //
            // btnLimpiar / btnCancelar / btnGuardar
            //
            this.btnLimpiar.Location = new System.Drawing.Point(300, 562);
            this.btnLimpiar.Size = new System.Drawing.Size(95, 30);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnCancelar.Location = new System.Drawing.Point(401, 562);
            this.btnCancelar.Size = new System.Drawing.Size(95, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            this.btnGuardar.Location = new System.Drawing.Point(502, 562);
            this.btnGuardar.Size = new System.Drawing.Size(106, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            //
            // FormRegistroAspirantes
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 628);
            this.Controls.Add(this.grpDatosPersonales);
            this.Controls.Add(this.grpContacto);
            this.Controls.Add(this.grpAcademico);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FormRegistroAspirantes";
            this.Text = "SisBecas — Registro de Aspirantes [Alcaldía de Colón]";

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.grpContacto.ResumeLayout(false);
            this.grpAcademico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPromedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIngreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
