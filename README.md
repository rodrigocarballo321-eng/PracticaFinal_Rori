SISTEMA DE INSCRIPCIÓN - BECA JOVEN LOURDES 2026 - PHP
===============================================

Este proyecto está desarrollado en PHP y no requiere XAMPP, WampServer ni motores de bases de datos complejos (como SQL Server o MySQL).

¿POR QUÉ LO DISEÑÉ ASÍ?
-----------------------
Para evitar errores de compatibilidad y drivers en Windows (como el error 'could not find driver'). Se utilizó una arquitectura de archivos planos (Flat-File):
1. Base de Datos Portátil (JSON): Los datos se guardan estructurados en 'becas_db.json'. PHP lee y escribe en él de forma nativa.
2. Servidor Integrado de PHP: Usa el servidor de desarrollo de consola propio de PHP en lugar del Apache de XAMPP.

ESTRUCTURA DEL PROYECTO
-----------------------
- config.php: Configuración y funciones para leer/escribir el JSON.
- inscripcion.php: Formulario visual morado con validaciones (DUI, edad, promedio).
- gracias.php: Pantalla que confirma el éxito del registro.
- becas_db.json: Archivo donde se guardan los datos (se crea solo al iniciar).

INSTRUCCIONES DE USO Y EJECUCIÓN
--------------------------------
Paso 1: Abre la carpeta de este proyecto en Visual Studio Code.
Paso 2: Abre la terminal en VS Code (Ctrl + Ñ), escribe esto: (php -S localhost:3000) y dale enter
        
Paso 3: Abre el navegador web e ingresa a esta ruta:
        http://localhost:3000/inscripcion.php

¿DÓNDE SE GUARDAN LOS REGISTROS?
--------------------------------
Los registros se guardan al instante en un archivo llamado 'becas_db.json' que aparecerá en la carpeta en cuanto envíe la primera solicitud con éxito.

======================================================================================================================================================

SISTEMA DE INSCRIPCIÓN - BECA JOVEN LOURDES 2026 - WINDOWS FORMS
===============================================

## Características
* **Validaciones estrictas:** Control de formato para DUI (`00000000-0`), teléfono (iniciando con 6 o 7) y edad (entre 15 y 30 años).
* **Seguridad:** Consultas SQL parametrizadas para evitar inyección de código.
* **Estado de conexión:** Barra inferior que indica en tiempo real si el sistema está conectado a la base de datos.

## Código Ordenado con `#region`
Para facilitar el mantenimiento y la lectura rápida del archivo `FormRegistroAspirantes.cs`, el código se organizó meticulosamente utilizando bloques **`#region`** y **`#endregion`**. 

Esto permite:
* **Colapsar y expandir** secciones de código en Visual Studio para no lidiar con un archivo gigante.
* **Separar visualmente** las tareas del formulario en grupos claros:
  * `Atributos y Constantes` (Expresiones regulares).
  * `Constructor y Carga (Load)` (Inicialización y carga de combos).
  * `Métodos de Validación` (Reglas de negocio).
  * `Eventos de Botones y Guardado` (Insert en base de datos y botones auxiliares).
  * `Métodos de Utilidad` (Limpieza de controles y estado de red).

