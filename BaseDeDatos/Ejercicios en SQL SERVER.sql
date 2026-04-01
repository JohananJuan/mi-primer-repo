CREATE DATABASE Ejercicio;
USE Ejercicio;

CREATE TABLE Libros (
	IdLibro INT PRIMARY KEY,
	Titulo VARCHAR(100),
	Autor VARCHAR(50),
	AnoPublicacion INT,
);


CREATE TABLE Cliente (
	IdCliente INT PRIMARY KEY,
	NombreCliente VARCHAR (20),
	ApellidoPaternoCliente VARCHAR (20),
	ApellidoMaternoCliente VARCHAR (20),
	FechaNacimientoCliente INT,
);

INSERT INTO Libros (IdLibro, Titulo, Autor, AnoPublicacion)
VALUES (1, 'Cien años de soledad', 'Gabriel García Márquez', 1967);


ALTER TABLE Libros ADD Editorial VARCHAR (50);
ALTER TABLE Libros DROP COLUMN Titulo;

UPDATE Libros SET AnoPublicacion = 1999 WHERE IdLibro = 1;

SELECT * FROM  Libros;