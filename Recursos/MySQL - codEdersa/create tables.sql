use codEdersa;

create table EETT(
	id int primary key auto_increment not null,
    codificacion varchar(20) null,
    nombreCompleto varchar(100) null,
    id_Sistema int null
);

create table equipamiento(
	id int primary key auto_increment not null,
    id_ET int null,
    id_Sistema int null,
    nivelTension varchar(5) null,
    nombreCampo varchar(100) null,
    tipoDeEquipo varchar(100) null,
    codificacion varchar(50) null,
    accionOperativa varchar(50) null,
    ultimaModificacion date null,
    marcaModelo varchar(50) null,
    anioFabricacion varchar(10) null,
    nroSerie varchar(50) null,
    sNominal varchar(15) null,
    iNominal varchar(15) null,
    uNominal varchar(15) null,
    uccPorcentual varchar(20) null,
    grupoConexion varchar(30) null,
    rbc varchar(10) null,
    tipo varchar(50) null,
    poderDeCorte varchar(20) null,
    accionamiento varchar(50) null,
    camara varchar(50) null,
    relacionTiTv varchar(20) null,
    clase varchar(20) null,
    observaciones varchar(1024) null
);

create table motivos (
	id int primary key auto_increment not null,
    codificacion varchar(10) null,
    motivo varchar(50) null,
    ap int null
);

create table operaciones (
	id int primary key auto_increment not null,
    id_Equipamiento int null,
    ET varchar(10) null,
    nombreCompleto varchar(100) null,
    codificacionEquipo varchar(10) null,
    fecha datetime null,
    id_motivo int null,
    id_responsable int null,
    ens varchar(2) null,
    ap int null,
    descripcion varchar(155) null,
    actuaciones varchar(155) null,
    observaciones varchar(1024) null
);

create table responsables (
	id int primary key auto_increment not null,
    responsable varchar(70) null
);

create table sistemas (
	id int primary key auto_increment not null,
    codificacion varchar(10) null,
    nombreCompleto varchar(100) null
);