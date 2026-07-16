<?php
// inscripcion.php
require_once 'config.php';

// Inicializamos las variables para que no den error al cargar por primera vez
$errores = [];
$campos = [
    'dui' => '', 'nombres' => '', 'apellidos' => '', 'fecha_nacimiento' => '',
    'sexo' => '', 'telefono' => '', 'correo' => '', 'institucion_estudio' => '',
    'promedio' => '', 'ingreso_familiar' => '', 'id_tipo' => ''
];

// Cargamos la base de datos JSON
$db = obtener_datos_db();

// 1. CARGAR LOS TIPOS DE BECA ACTIVOS
$tipos_beca = [];
foreach ($db['tipos_beca'] as $beca) {
    if ($beca['activo'] == 1) {
        $tipos_beca[] = $beca;
    }
}

// 2. PROCESAR EL FORMULARIO CUANDO SE ENVÍA (POST)
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Limpiamos los espacios en blanco
    foreach ($campos as $key => $val) {
        $campos[$key] = isset($_POST[$key]) ? trim($_POST[$key]) : '';
    }

    // --- VALIDACIONES ---
    
    // Validar DUI
    if (empty($campos['dui']) || !preg_match('/^\d{8}-\d$/', $campos['dui'])) {
        $errores['dui'] = "El DUI es obligatorio y debe usar el formato 00000000-0.";
    } else {
        // Verificar si el DUI ya existe en los aspirantes guardados
        foreach ($db['aspirantes'] as $asp) {
            if ($asp['dui'] === $campos['dui']) {
                $errores['dui'] = "Ya existe una inscripción con ese DUI.";
                break;
            }
        }
    }
    
    // Validar Nombres y Apellidos
    if (empty($campos['nombres']) || strlen($campos['nombres']) > 60) {
        $errores['nombres'] = "El nombre es obligatorio (máx 60 caracteres).";
    }
    if (empty($campos['apellidos']) || strlen($campos['apellidos']) > 60) {
        $errores['apellidos'] = "El apellido es obligatorio (máx 60 caracteres).";
    }

    // Validar Edad (Debe tener entre 15 y 30 años)
    if (empty($campos['fecha_nacimiento'])) {
        $errores['fecha_nacimiento'] = "La fecha de nacimiento es obligatoria.";
    } else {
        $cumpleanos = new DateTime($campos['fecha_nacimiento']);
        $hoy = new DateTime();
        $edad = $hoy->diff($cumpleanos)->y;
        if ($edad < 15 || $edad > 30) {
            $errores['fecha_nacimiento'] = "Debes tener entre 15 y 30 años de edad.";
        }
    }

    // Validar Sexo
    if (empty($campos['sexo']) || !in_array($campos['sexo'], ['F', 'M'])) {
        $errores['sexo'] = "Selecciona un sexo válido.";
    }

    // Validar Teléfono
    if (empty($campos['telefono']) || !preg_match('/^[67]\d{3}-\d{4}$/', $campos['telefono'])) {
        $errores['telefono'] = "El teléfono debe tener el formato 7234-5678 (iniciar con 6 o 7).";
    }

    // Validar Correo
    if (!empty($campos['correo']) && !filter_var($campos['correo'], FILTER_VALIDATE_EMAIL)) {
        $errores['correo'] = "El correo electrónico no es válido.";
    }

    // Validar Institución
    if (empty($campos['institucion_estudio']) || strlen($campos['institucion_estudio']) > 100) {
        $errores['institucion_estudio'] = "La institución es obligatoria (máx 100 caracteres).";
    }

    // Validar Promedio
    $promedio_val = filter_var($campos['promedio'], FILTER_VALIDATE_FLOAT);
    if ($promedio_val === false || $promedio_val < 6.00 || $promedio_val > 10.00) {
        $errores['promedio'] = "El promedio debe estar entre 6.00 y 10.00.";
    }

    // Validar Ingreso familiar
    $ingreso_val = filter_var($campos['ingreso_familiar'], FILTER_VALIDATE_FLOAT);
    if ($ingreso_val === false || $ingreso_val < 0.00 || $ingreso_val > 9999.99) {
        $errores['ingreso_familiar'] = "El ingreso familiar debe estar entre $0.00 y $9999.99.";
    }
    
    // Validar Tipo de beca
    if (empty($campos['id_tipo'])) {
        $errores['id_tipo'] = "Selecciona un tipo de beca.";
    }

    // --- GUARDAR SI NO HAY ERRORES ---
    if (empty($errores)) {
        // Generar un ID incremental para el nuevo aspirante
        $nuevo_id = count($db['aspirantes']) + 1;

        $nuevo_aspirante = [
            'id' => $nuevo_id,
            'dui' => $campos['dui'],
            'nombres' => $campos['nombres'],
            'apellidos' => $campos['apellidos'],
            'fecha_nacimiento' => $campos['fecha_nacimiento'],
            'sexo' => $campos['sexo'],
            'telefono' => $campos['telefono'],
            'correo' => !empty($campos['correo']) ? $campos['correo'] : null,
            'institucion_estudio' => $campos['institucion_estudio'],
            'promedio' => $promedio_val,
            'ingreso_familiar' => $ingreso_val,
            'id_tipo' => intval($campos['id_tipo'])
        ];

        // Añadimos el nuevo registro y guardamos en el JSON
        $db['aspirantes'][] = $nuevo_aspirante;
        guardar_datos_db($db);

        // Redirigimos a la página de éxito
        header("Location: gracias.php?id=" . urlencode($nuevo_id));
        exit();
    }
}

// Función de seguridad
function s(string $html) : string {
    return htmlspecialchars($html, ENT_QUOTES, 'UTF-8');
}
?>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Beca Joven Lourdes 2026</title>
    <style>
        :root {
            --primary-gradient: linear-gradient(135deg, #6d28d9, #a855f7);
            --bg-color: #f8fafc;
            --card-bg: #ffffff;
            --text-color: #1e293b;
            --border-radius: 6px;
        }
        body {
            font-family: 'Segoe UI', sans-serif;
            background-color: var(--bg-color);
            color: var(--text-color);
            margin: 0;
            padding: 20px;
            display: flex;
            justify-content: center;
        }
        .container {
            width: 100%;
            max-width: 650px;
            background: var(--card-bg);
            border-radius: var(--border-radius);
            box-shadow: 0 4px 15px rgba(0, 0, 0, 0.08);
            overflow: hidden;
        }
        .header {
            background: var(--primary-gradient);
            color: white;
            padding: 25px;
        }
        .header h1 { margin: 0 0 10px 0; font-size: 24px; }
        .header p { margin: 0; font-size: 14px; opacity: 0.9; }
        
        form { padding: 25px; }
        .section-title {
            color: #a855f7;
            font-size: 13px;
            font-weight: bold;
            text-transform: uppercase;
            margin: 20px 0 15px 0;
            border-bottom: 1px solid #f1f5f9;
            padding-bottom: 5px;
        }
        
        .row { display: flex; gap: 15px; margin-bottom: 15px; }
        .col { flex: 1; display: flex; flex-direction: column; }
        
        label { font-size: 13px; font-weight: 600; margin-bottom: 5px; }
        label .req { color: #ef4444; }
        
        input, select {
            padding: 10px;
            border: 1px solid #cbd5e1;
            border-radius: var(--border-radius);
            font-size: 14px;
            outline: none;
        }
        input:focus, select:focus {
            border-color: #a855f7;
            box-shadow: 0 0 0 3px rgba(168, 85, 247, 0.15);
        }
        
        .radio-group { display: flex; gap: 15px; padding: 10px 0; }
        .radio-group label { font-weight: normal; cursor: pointer; display: flex; align-items: center; gap: 5px; }
        
        .hint { font-size: 11px; color: #64748b; margin-top: 4px; }
        .error-msg { color: #ef4444; font-size: 12px; margin-top: 4px; }
        .error-summary {
            background-color: #fef2f2;
            border-left: 4px solid #ef4444;
            color: #b91c1c;
            padding: 15px;
            margin: 20px;
            border-radius: 4px;
            font-size: 14px;
        }
        
        .buttons { display: flex; justify-content: flex-end; gap: 10px; margin-top: 25px; }
        .btn-submit {
            background: var(--primary-gradient);
            color: white;
            border: none;
            padding: 12px 24px;
            font-size: 14px;
            font-weight: bold;
            border-radius: var(--border-radius);
            cursor: pointer;
            transition: opacity 0.2s;
        }
        .btn-submit:hover { opacity: 0.9; }
    </style>
</head>
<body>

<div class="container">
    <div class="header">
        <h1>Beca Joven Lourdes 2026</h1>
        <p>Completa tus datos para postularte al programa de asistencia económica.</p>
    </div>

    <?php if (!empty($errores)): ?>
        <div class="error-summary">
            <strong>Por favor, corrige los siguientes errores antes de continuar:</strong>
            <ul>
                <?php foreach ($errores as $error): ?>
                    <li><?php echo s($error); ?></li>
                <?php endforeach; ?>
            </ul>
        </div>
    <?php endif; ?>

    <form action="inscripcion.php" method="POST">
        <div class="section-title">Datos Personales</div>
        
        <div class="row">
            <div class="col">
                <label for="dui">DUI <span class="req">*</span></label>
                <input type="text" id="dui" name="dui" placeholder="00000000-0" value="<?php echo s($campos['dui']); ?>">
                <span class="hint">Formato: 8 números, guión, 1 número</span>
                <?php if (isset($errores['dui'])): ?>
                    <span class="error-msg"><?php echo s($errores['dui']); ?></span>
                <?php endif; ?>
            </div>
            
            <div class="col">
                <label for="fecha_nacimiento">Fecha de Nacimiento <span class="req">*</span></label>
                <input type="date" id="fecha_nacimiento" name="fecha_nacimiento" value="<?php echo s($campos['fecha_nacimiento']); ?>">
                <span class="hint">Edad permitida: 15 a 30 años</span>
                <?php if (isset($errores['fecha_nacimiento'])): ?>
                    <span class="error-msg"><?php echo s($errores['fecha_nacimiento']); ?></span>
                <?php endif; ?>
            </div>
        </div>

        <div class="row">
            <div class="col">
                <label for="nombres">Nombres <span class="req">*</span></label>
                <input type="text" id="nombres" name="nombres" value="<?php echo s($campos['nombres']); ?>">
                <?php if (isset($errores['nombres'])): ?>
                    <span class="error-msg"><?php echo s($errores['nombres']); ?></span>
                <?php endif; ?>
            </div>
            
            <div class="col">
                <label for="apellidos">Apellidos <span class="req">*</span></label>
                <input type="text" id="apellidos" name="apellidos" value="<?php echo s($campos['apellidos']); ?>">
                <?php if (isset($errores['apellidos'])): ?>
                    <span class="error-msg"><?php echo s($errores['apellidos']); ?></span>
                <?php endif; ?>
            </div>
        </div>

        <div class="row">
            <div class="col">
                <label>Sexo <span class="req">*</span></label>
                <div class="radio-group">
                    <label>
                        <input type="radio" name="sexo" value="M" <?php echo $campos['sexo'] === 'M' ? 'checked' : ''; ?>> Masculino
                    </label>
                    <label>
                        <input type="radio" name="sexo" value="F" <?php echo $campos['sexo'] === 'F' ? 'checked' : ''; ?>> Femenino
                    </label>
                </div>
                <?php if (isset($errores['sexo'])): ?>
                    <span class="error-msg"><?php echo s($errores['sexo']); ?></span>
                <?php endif; ?>
            </div>
            
            <div class="col">
                <label for="telefono">Teléfono de Contacto <span class="req">*</span></label>
                <input type="text" id="telefono" name="telefono" placeholder="7000-0000" value="<?php echo s($campos['telefono']); ?>">
                <span class="hint">Formato de El Salvador (8 dígitos con guión)</span>
                <?php if (isset($errores['telefono'])): ?>
                    <span class="error-msg"><?php echo s($errores['telefono']); ?></span>
                <?php endif; ?>
            </div>
        </div>

        <div class="row">
            <div class="col">
                <label for="correo">Correo Electrónico</label>
                <input type="email" id="correo" name="correo" placeholder="correo@ejemplo.com" value="<?php echo s($campos['correo']); ?>">
                <?php if (isset($errores['correo'])): ?>
                    <span class="error-msg"><?php echo s($errores['correo']); ?></span>
                <?php endif; ?>
            </div>
        </div>

        <div class="section-title">Información Académica y Socioeconómica</div>

        <div class="row">
            <div class="col">
                <label for="institucion_estudio">Centro Escolar / Universidad <span class="req">*</span></label>
                <input type="text" id="institucion_estudio" name="institucion_estudio" value="<?php echo s($campos['institucion_estudio']); ?>">
                <?php if (isset($errores['institucion_estudio'])): ?>
                    <span class="error-msg"><?php echo s($errores['institucion_estudio']); ?></span>
                <?php endif; ?>
            </div>
        </div>

        <div class="row">
            <div class="col">
                <label for="promedio">Promedio de Notas <span class="req">*</span></label>
                <input type="number" id="promedio" name="promedio" min="6.00" max="10.00" step="0.01" value="<?php echo s($campos['promedio']); ?>">
                <span class="hint">Debe ser entre 6.00 y 10.00</span>
                <?php if (isset($errores['promedio'])): ?>
                    <span class="error-msg"><?php echo s($errores['promedio']); ?></span>
                <?php endif; ?>
            </div>
            
            <div class="col">
                <label for="ingreso_familiar">Ingreso Familiar Mensual ($) <span class="req">*</span></label>
                <input type="number" id="ingreso_familiar" name="ingreso_familiar" min="0.00" max="9999.99" step="0.01" value="<?php echo s($campos['ingreso_familiar']); ?>">
                <?php if (isset($errores['ingreso_familiar'])): ?>
                    <span class="error-msg"><?php echo s($errores['ingreso_familiar']); ?></span>
                <?php endif; ?>
            </div>
        </div>

        <div class="row">
            <div class="col">
                <label for="id_tipo">Tipo de Beca Solicitada <span class="req">*</span></label>
                <select id="id_tipo" name="id_tipo">
                    <option value="">-- Selecciona una opción --</option>
                    <?php foreach ($tipos_beca as $beca): ?>
                        <option value="<?php echo $beca['id']; ?>" <?php echo (string)$campos['id_tipo'] === (string)$beca['id'] ? 'selected' : ''; ?>>
                            <?php echo s($beca['nombre']) . " ($" . number_format($beca['monto'], 2) . ")"; ?>
                        </option>
                    <?php endforeach; ?>
                </select>
                <?php if (isset($errores['id_tipo'])): ?>
                    <span class="error-msg"><?php echo s($errores['id_tipo']); ?></span>
                <?php endif; ?>
            </div>
        </div>

        <div class="buttons">
            <button type="submit" class="btn-submit">Enviar Solicitud</button>
        </div>
    </form>
</div>

</body>
</html>