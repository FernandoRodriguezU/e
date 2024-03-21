CREATE DATABASE GestionE
CREATE TABLE TablaPersona (
    IDPersona INT PRIMARY KEY,
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    Estado NVARCHAR(50)
);


INSERT INTO TablaPersona (IDPersona, Nombre, Apellido, Estado)
VALUES 
    (1, 'Jaime', 'Pérez', 'Activo'),
    (2, 'Fernando', 'González', 'Inactivo'),
    (3, 'Olver', 'López', 'Activo');


CREATE TABLE TablaEmpleado (
    IDEmpleado INT PRIMARY KEY,
    IDPersona INT,
    Puesto NVARCHAR(100),
    Salario DECIMAL(10, 2),
    FechaContratacion DATE,
    FOREIGN KEY (IDPersona) REFERENCES TablaPersona(IDPersona)
);


INSERT INTO TablaEmpleado (IDEmpleado, IDPersona, Puesto, Salario, FechaContratacion)
VALUES
    (1, 1, 'Gerente', 5500.00, '2022-01-15'),
    (2, 2, 'Desarrollador', 99000.00, '2023-03-10'),
    (3, 3, 'Contador', 49900.00, '2021-07-20');
	
