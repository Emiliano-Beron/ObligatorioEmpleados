create table Tipo
(
    idTipo INT(2) NOT NULL PRIMARY KEY,
    tipo CHAR(20) NOT NULL,
    aumento INT(3) NOT NULL
);
create table Empleado
(
    idEmp INT(2) NOT NULL PRIMARY KEY AUTO_INCREMENT,
    ci INT(8) NOT NULL,
    priNom CHAR(20) NOT NULL,
    priApe CHAR(20) NOT NULL,
    salario INT(6) NOT NULL,
    idTipo INT(2) NOT NULL,
    CONSTRAINT idTipo FOREIGN KEY(idTipo) REFERENCES Tipo(idTipo)
);
create table telefonos
(
    idEmp INT(2) NOT NULL,
    tel INT(8),
    CONSTRAINT idEmp FOREIGN KEY (idEmp) REFERENCES Empleado(idEmp)
);