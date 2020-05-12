create table Empleado
(
    idEmp INT(2) NOT NULL PRIMARY KEY AUTO_INCREMENT,
    ci INT(8) NOT NULL,
    priNom VARCHAR(20) NOT NULL,
    priApe VARCHAR(20) NOT NULL,
    direccion VARCHAR(30) NOT NULL,
    salario INT(6) NOT NULL,
    tipo VARCHAR(20) NOT NULL
);
create table telefonos
(
    idEmp INT(2) NOT NULL,
    tel INT(8),
    CONSTRAINT idEmp FOREIGN KEY (idEmp) REFERENCES Empleado(idEmp)
);