select * from EETT;
select * from sistemas;

select EETT.id, EETT.codificacion, EETT.nombreCompleto, sistemas.nombreCompleto as sistema
from EETT
inner join sistemas on EETT.id_Sistema = sistemas.id;

-- ----------------------------------------------------------------------------------------
select * from equipamiento;
select * from EETT;
select * from sistemas;

select EETT.codificacion as ET, equipamiento.nombreCampo, equipamiento.tipoDeEquipo, equipamiento.codificacion, equipamiento.nivelTension, equipamiento.accionOperativa, sistemas.nombreCompleto as sistema
from equipamiento
inner join sistemas on equipamiento.id_Sistema = sistemas.id
inner join EETT on equipamiento.id_ET = EETT.id;

-- ----------------------------------------------------------------------------------------
select * from responsables;
select * from motivos;
select * from equipamiento;
select * from operaciones;

select	fecha, ET, nombreCampo, codificacionEquipo,
		responsables.responsable AS Responsable, motivos.motivo as Motivo,
		ens, operaciones.ap, descripcion, actuaciones, observaciones
from operaciones
inner join motivos on operaciones.id_motivo = motivos.id
inner join responsables on operaciones.id_responsable = responsables.id;

-- ----------------------------------------------------------------------------------------
