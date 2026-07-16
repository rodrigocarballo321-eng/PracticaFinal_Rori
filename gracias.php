<?php
// gracias.php
require_once 'config.php';

// Obtenemos el ID del aspirante recién inscrito desde la URL
$id = isset($_GET['id']) ? intval($_GET['id']) : 0;

$db = obtener_datos_db();
$aspirante = null;

// Buscamos al aspirante en nuestro archivo JSON
foreach ($db['aspirantes'] as $asp) {
    if ($asp['id'] === $id) {
        $aspirante = $asp;
        break;
    }
}

// Si no se encuentra el aspirante, redirigimos al formulario
if (!$aspirante) {
    header("Location: inscripcion.php");
    exit();
}

// Buscamos el nombre del tipo de beca que solicitó
$nombre_beca = "No especificado";
foreach ($db['tipos_beca'] as $beca) {
    if ($beca['id'] === $aspirante['id_tipo']) {
        $nombre_beca = $beca['nombre'] . " ($" . number_format($beca['monto'], 2) . ")";
        break;
    }
}

function s(string $html) : string {
    return htmlspecialchars($html, ENT_QUOTES, 'UTF-8');
}
?>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Inscripción Exitosa</title>
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
            align-items: center;
            min-height: 90vh;
        }
        .container {
            width: 100%;
            max-width: 550px;
            background: var(--card-bg);
            border-radius: var(--border-radius);
            box-shadow: 0 4px 15px rgba(0, 0, 0, 0.08);
            overflow: hidden;
            text-align: center;
        }
        .header {
            background: var(--primary-gradient);
            color: white;
            padding: 30px;
        }
        .header h1 { margin: 0; font-size: 26px; }
        .header p { margin: 10px 0 0 0; font-size: 14px; opacity: 0.9; }
        
        .content {
            padding: 30px;
        }
        .success-icon {
            font-size: 50px;
            color: #22c55e;
            margin-bottom: 15px;
        }
        .info-card {
            background-color: #faf5ff;
            border: 1px solid #e9d5ff;
            border-radius: var(--border-radius);
            padding: 20px;
            text-align: left;
            margin: 20px 0;
        }
        .info-row {
            display: flex;
            justify-content: space-between;
            border-bottom: 1px solid #f3e8ff;
            padding: 8px 0;
            font-size: 14px;
        }
        .info-row:last-child {
            border-bottom: none;
        }
        .info-label {
            font-weight: bold;
            color: #6b21a8;
        }
        .info-value {
            color: #3b0764;
        }
        .btn {
            display: inline-block;
            background: var(--primary-gradient);
            color: white;
            text-decoration: none;
            padding: 12px 25px;
            font-weight: bold;
            border-radius: var(--border-radius);
            transition: opacity 0.2s;
            margin-top: 10px;
        }
        .btn:hover {
            opacity: 0.9;
        }
    </style>
</head>
<body>

<div class="container">
    <div class="header">
        <h1>¡Inscripción Completada!</h1>
        <p>Tu solicitud ha sido procesada y guardada exitosamente.</p>
    </div>
    
    <div class="content">
        <div class="success-icon">✓</div>
        <p>A continuación se detallan los datos registrados en el sistema:</p>
        
        <div class="info-card">
            <div class="info-row">
                <span class="info-label">DUI:</span>
                <span class="info-value"><?php echo s($aspirante['dui']); ?></span>
            </div>
            <div class="info-row">
                <span class="info-label">Aspirante:</span>
                <span class="info-value"><?php echo s($aspirante['nombres'] . ' ' . $aspirante['apellidos']); ?></span>
            </div>
            <div class="info-row">
                <span class="info-label">Institución:</span>
                <span class="info-value"><?php echo s($aspirante['institucion_estudio']); ?></span>
            </div>
            <div class="info-row">
                <span class="info-label">Promedio:</span>
                <span class="info-value"><?php echo number_format($aspirante['promedio'], 2); ?></span>
            </div>
            <div class="info-row">
                <span class="info-label">Beca Solicitada:</span>
                <span class="info-value"><?php echo s($nombre_beca); ?></span>
            </div>
        </div>
        
        <p style="font-size: 12px; color: #64748b; margin-bottom: 25px;">
            Los datos se han persistido localmente en tu base de datos portátil JSON.
        </p>
        
        <a href="inscripcion.php" class="btn">Registrar nueva solicitud</a>
    </div>
</div>

</body>
</html>