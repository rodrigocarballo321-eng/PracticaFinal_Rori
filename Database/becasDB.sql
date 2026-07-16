
CREATE DATABASE becas;
GO

USE becas;
GO


CREATE TABLE tipos_beca (
    id INT IDENTITY(1,1) NOT NULL,
    nombre NVARCHAR(100) NOT NULL,
    monto DECIMAL(10,2) NOT NULL,
    activo BIT NOT NULL CONSTRAINT DF_tipos_beca_activo DEFAULT 1, -- Por defecto activa
    CONSTRAINT PK_tipos_beca PRIMARY KEY (id)
);
GO

CREATE TABLE aspirantes (
    id_aspirante INT IDENTITY(1,1) NOT NULL,
    dui VARCHAR(10) NOT NULL,
    nombres NVARCHAR(60) NOT NULL,
    apellidos NVARCHAR(60) NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    sexo CHAR(1) NOT NULL,
    telefono VARCHAR(9) NOT NULL,
    correo VARCHAR(100) NULL, -- Permite nulos ya que es opcional en tu formulario
    institucion NVARCHAR(100) NOT NULL,
    promedio DECIMAL(4,2) NOT NULL,
    ingreso_familiar DECIMAL(10,2) NOT NULL,
    id_tipo_beca INT NOT NULL,
    fecha_registro DATETIME NOT NULL CONSTRAINT DF_aspirantes_fecha_registro DEFAULT GETDATE(), -- Registra la fecha actual automáticamente
    CONSTRAINT PK_aspirantes PRIMARY KEY (id_aspirante),
    CONSTRAINT FK_aspirantes_tipos_beca FOREIGN KEY (id_tipo_beca) REFERENCES tipos_beca(id)
);
GO

INSERT INTO tipos_beca (nombre, monto, activo) VALUES 
('Bachillerato', 50.00, 1),
('Técnica', 75.00, 1),
('Universitaria', 100.00, 1),
('Posgrado', 150.00, 1);
GO