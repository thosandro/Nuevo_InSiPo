use codEdersa;

create table MOTIVOS(
	idTabla int auto_increment not null,
    idMotivo varchar(10) not null,
    nombreMotivo varchar(60) not null,
    ap int null,
    primary key (idTabla,idMotivo)
);

create table EETT (
	idTabla int auto_increment not null,
	idEETT varchar(10) not null,
    nombreET varchar(69) not null,
    sistema varchar(5) not null,
    primary key (idTabla, idEETT)
);

create table COD(
	idTabla int auto_increment primary key not null,
    nombre varchar(60)
);

insert into COD (nombre) values 
('Barrera, Marcos'),
('Ciavatta, Gastón'),
('Lescano, Thomas'),
('Navarrete, Bruno'),
('Rucci, Maximiliano'),
('Simon, Juan Cruz');

create table MANTENIMIENTO(
	idTabla int auto_increment primary key not null,
    nombre varchar(60)
);

insert into MANTENIMIENTO (nombre) values
('Beltran, Crsitian'),
('Castillo, Fabián'),
('Crespo, Daniel'),
('Lillo, Carlos'),
('Mendez, Fernando'),
('Rodriguez, Ricardo'),
('Rovere, Ramiro'),
('Sanchez, Cesar'),
('Sede, Rodolfo'),
('Urbina, Bruno'),
('Villar, Fernando');

create table RESPONSABLES(
	idTabla int auto_increment primary key not null,
    nombre varchar(60)
);