CREATE DATABASE SistemaAgua;
GO

USE SistemaAgua;
GO

CREATE TABLE Perfil (
    IdPerfil INT IDENTITY(1,1) PRIMARY KEY,
    NombrePerfil NVARCHAR(50) NOT NULL,
    Activo BIT DEFAULT 1
);

CREATE TABLE StatusUsuario (
    IdStatus INT IDENTITY(1,1) PRIMARY KEY,
    NombreStatus NVARCHAR(50) NOT NULL,
    Activo BIT DEFAULT 1
);

CREATE TABLE TipoCooperacion (
    IdTipoCooperacion INT IDENTITY(1,1) PRIMARY KEY,
    NombreTipoCooperacion NVARCHAR(50) NOT NULL,
    Activo BIT DEFAULT 1
);

CREATE TABLE TipoPago (
    IdTipoPago INT IDENTITY(1,1) PRIMARY KEY,
    NombreTipoPago NVARCHAR(50) NOT NULL,
    Activo BIT DEFAULT 1
);

CREATE TABLE Persona (
    IdPersona INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    ApellidoPaterno NVARCHAR(100) NOT NULL,
    ApellidoMaterno NVARCHAR(100),
    Correo NVARCHAR(100),
    NumeroTelefono NVARCHAR(15),
    FechaNacimiento DATE,
    FechaRegistro DATE DEFAULT GETDATE()
);


CREATE TABLE Usuario (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario NVARCHAR(50) NOT NULL,
    ApellidoPaterno NVARCHAR(100),
    ApellidoMaterno NVARCHAR(100),
    Correo NVARCHAR(100),
    NumeroTelefono NVARCHAR(15),
    Contrasena NVARCHAR(100) NOT NULL,
    IdPerfil INT NOT NULL,
    IdStatus INT NOT NULL,
    FechaRegistro DATE DEFAULT GETDATE(),
    FechaUltimoCambioPassword DATE,

    CONSTRAINT FK_Usuario_Perfil 
        FOREIGN KEY (IdPerfil) REFERENCES Perfil(IdPerfil),

    CONSTRAINT FK_Usuario_Status 
        FOREIGN KEY (IdStatus) REFERENCES StatusUsuario(IdStatus)
);

CREATE TABLE Cooperacion (
    IdCooperacion INT IDENTITY(1,1) PRIMARY KEY,
    IdPersona INT NOT NULL,            -- quien paga
    IdPersonaRecibe INT NOT NULL,      -- quien recibe
    IdUsuario INT NOT NULL,
    IdTipoCooperacion INT NOT NULL,
    IdTipoPago INT NOT NULL,
    Monto DECIMAL(10,2) NOT NULL,
    Descripcion NVARCHAR(200),
    FechaInicio DATE,
    FechaPago DATE,
    FechaRegistro DATE DEFAULT GETDATE(),
    Folio NVARCHAR(50) UNIQUE,

    CONSTRAINT FK_Coop_Persona 
        FOREIGN KEY (IdPersona) REFERENCES Persona(IdPersona),

    CONSTRAINT FK_Coop_PersonaRecibe 
        FOREIGN KEY (IdPersonaRecibe) REFERENCES Persona(IdPersona),

    CONSTRAINT FK_Coop_Usuario 
        FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),

    CONSTRAINT FK_Coop_TipoCoop 
        FOREIGN KEY (IdTipoCooperacion) REFERENCES TipoCooperacion(IdTipoCooperacion),

    CONSTRAINT FK_Coop_TipoPago 
        FOREIGN KEY (IdTipoPago) REFERENCES TipoPago(IdTipoPago)
);

-- Perfil
INSERT INTO Perfil (NombrePerfil)
VALUES ('Administrador'), ('Cajero');

-- StatusUsuario
INSERT INTO StatusUsuario (NombreStatus)
VALUES ('Activo'), ('Inactivo'), ('Registrado'), ('Bloqueado');

-- TipoCooperacion
INSERT INTO TipoCooperacion (NombreTipoCooperacion)
VALUES ('Agua potable'), ('Riego');

-- TipoPago
INSERT INTO TipoPago (NombreTipoPago)
VALUES ('Efectivo'), ('Transferencia');