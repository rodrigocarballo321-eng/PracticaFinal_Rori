<?php
// config.php

// Definimos dónde se guardará nuestra "base de datos" JSON
define('DB_FILE', __DIR__ . '/becas_db.json');

// Si el archivo de base de datos no existe, lo creamos con datos iniciales de becas
if (!file_exists(DB_FILE)) {
    $datos_iniciales = [
        "tipos_beca" => [
            ["id" => 1, "nombre" => "Universitaria", "monto" => 100.00, "activo" => 1],
            ["id" => 2, "nombre" => "Técnica", "monto" => 75.00, "activo" => 1],
            ["id" => 3, "nombre" => "Bachillerato", "monto" => 50.00, "activo" => 1],
            ["id" => 4, "nombre" => "Deportiva", "monto" => 120.00, "activo" => 1]
        ],
        "aspirantes" => []
    ];
    file_put_contents(DB_FILE, json_encode($datos_iniciales, JSON_PRETTY_PRINT | JSON_UNESCAPED_UNICODE));
}

// Función para leer toda nuestra base de datos JSON
function obtener_datos_db() {
    $contenido = file_get_contents(DB_FILE);
    return json_decode($contenido, true);
}

// Función para guardar cambios en nuestra base de datos JSON
function guardar_datos_db($datos) {
    file_put_contents(DB_FILE, json_encode($datos, JSON_PRETTY_PRINT | JSON_UNESCAPED_UNICODE));
}
?>