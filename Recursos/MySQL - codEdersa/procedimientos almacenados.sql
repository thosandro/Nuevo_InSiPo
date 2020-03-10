--  TABLA EETT  --
-- **************************************************************
delimiter $$
create procedure SP_actualizarCursoHorario (
	in pViejo nvarchar(200),
    in pNuevo nvarchar(200)
)
begin
update ALUMNOS set curso = replace(curso, pViejo, pNuevo);
end;
delimiter $$
-- *************************************************************
delimiter $$
create procedure SP_listarEETT
	in pbuscar varchar(10)
as
	select EETT.id, EETT.codificacion, EETT.nombreCompleto, sistemas.nombreCompleto as sistema
	from EETT
	inner join sistemas on EETT.id_Sistema = sistemas.id
	where EETT.codificacion like '%' + @buscar + '%'
	order by EETT.codificacion asc;
end;
delimiter $$

create procedure SP_agregarEETT
	@codificacion varchar(20),
	@nombreCompleto varchar(100),
	@id_Sistema int
as
	insert into EETT (codificacion, nombreCompleto, id_Sistema)
	values (@codificacion, @nombreCompleto, @id_Sistema);
go

create procedure SP_editarEETT
	@id int,
	@codificacion varchar(20),
	@nombreCompleto varchar(100),
	@id_Sistema int
as
	update EETT
	set	codificacion = @codificacion,
		nombreCompleto = @nombreCompleto,
		id_Sistema = @id_Sistema
	where id = @id;
go

create procedure SP_eliminarEETT
	@id int
as
	delete from EETT
	where id = @id;
go
-- ------------------------------------------------------------------------------------- --
--  TABLA EQUIPAMIENTOS  --

create procedure SP_listarEquipamiento
	@buscar varchar(100)
as
	select	equipamiento.id, EETT.codificacion as ET, sistemas.codificacion as sistema, nombreCampo, tipoDeEquipo, equipamiento.codificacion, nivelTension, accionOperativa,
			marcaModelo, anioFabricacion, nroSerie, sNominal, iNominal, uNominal, uccPorcentual, grupoConexion, rbc, tipo, poderDeCorte, accionamiento,
			camara, relacionTiTv, clase, observaciones, ultimaModificacion
	from equipamiento
	inner join sistemas on equipamiento.id_Sistema = sistemas.id
	inner join EETT on equipamiento.id_ET = EETT.id
	where nombreCampo like '%' + @buscar + '%'
	order by ET, nivelTension, nombreCampo asc;
go

drop procedure SP_listarEquipamientoParaCargaDeNovedades;

create procedure SP_listarEquipamientoParaCargaDeNovedades
	@buscar varchar(10),
	@ET varchar(10)
as
	select	equipamiento.id, EETT.codificacion as ET,nombreCampo, tipoDeEquipo, equipamiento.codificacion, nivelTension, accionOperativa
	from equipamiento
	--inner join sistemas on equipamiento.id_Sistema = sistemas.id
	inner join EETT on equipamiento.id_ET = EETT.id
	where accionOperativa = 'Maniobra' and EETT.codificacion = @ET and nombreCampo like '%' + @buscar + '%'
	order by ET, nivelTension, nombreCampo;
go

exec SP_listarEquipamientoParaCargaDeNovedades '','ET4VI';

create procedure SP_agregarEquipamiento
	@id_ET int, @id_Sistema int, @nivelTension int,
	@nombreCampo varchar(100), @tipoDeEquipo varchar(100), @codificacion varchar(50), @accionOperativa varchar(50),
	@ultimaModificacion date,
	@marcaModelo varchar(150), @anioFabricacion varchar(10), @nroSerie varchar(50),
	@sNominal varchar(15), @iNominal varchar(15), @uNominal varchar(15),
	@uccPorcentual varchar(20), @grupoConexion varchar(30),
	@rbc varchar(10), @tipo varchar(50), @poderDeCorte varchar(20), 
	@accionamiento varchar(50), @camara varchar(50), @relacionTiTv varchar(20), @clase varchar(20),
	@observaciones varchar(200)
as
	insert into equipamiento
		(id_ET, id_Sistema, nivelTension, nombreCampo, tipoDeEquipo, codificacion, accionOperativa, ultimaModificacion,
		 marcaModelo, anioFabricacion, nroSerie, sNominal, iNominal, uNominal, uccPorcentual, grupoConexion, rbc,
		 tipo, poderDeCorte, accionamiento, camara, relacionTiTv, clase, observaciones)
	values	(@id_ET, @id_Sistema, @nivelTension, @nombreCampo, @tipoDeEquipo, @codificacion, @accionOperativa,
			 @ultimaModificacion, @marcaModelo, @anioFabricacion, @nroSerie, @sNominal, @iNominal, @uNominal,
			 @uccPorcentual, @grupoConexion, @rbc, @tipo, @poderDeCorte, @accionamiento, @camara, @relacionTiTv,
			 @clase, @observaciones);
go

create procedure SP_editarEquipamiento
	@id int,
	@id_ET int, @id_Sistema int, @nivelTension int,
	@nombreCampo varchar(100), @tipoDeEquipo varchar(100), @codificacion varchar(50), @accionOperativa varchar(50),
	@ultimaModificacion date,
	@marcaModelo varchar(150), @anioFabricacion varchar(10), @nroSerie varchar(50),
	@sNominal varchar(15), @iNominal varchar(15), @uNominal varchar(15),
	@uccPorcentual varchar(20), @grupoConexion varchar(30),
	@rbc varchar(10), @tipo varchar(50), @poderDeCorte varchar(20), 
	@accionamiento varchar(50), @camara varchar(50), @relacionTiTv varchar(20), @clase varchar(20),
	@observaciones varchar(200)
as
	update equipamiento
	set	id_ET = @id_ET, id_Sistema = @id_Sistema, NivelTension = @nivelTension,
		nombreCampo = @nombreCampo, tipoDeEquipo = @tipoDeEquipo, codificacion = @codificacion, accionOperativa = @accionOperativa,
		ultimaModificacion = @ultimaModificacion,
		marcaModelo = @marcaModelo, anioFabricacion = @anioFabricacion, nroSerie = @nroSerie,
		sNominal = @sNominal, iNominal = @iNominal, uNominal = uNominal,
		uccPorcentual = @uccPorcentual, grupoConexion = @grupoConexion,
		rbc = @rbc, tipo = @tipo, poderDeCorte = @poderDeCorte,
		accionamiento = @accionamiento, camara = @camara, relacionTiTv = @relacionTiTv, clase = @clase,
		observaciones = @observaciones
	where id = @id;
go

create procedure SP_eliminarEquipamiento
	@id int
as
	delete from equipamiento
	where id = @id;
go

-- ------------------------------------------------------------------------------------- --
--  TABLA MOTIVOS  --
create procedure SP_listarMotivo
as
	select * from motivos order by codificacion asc;
go

create procedure SP_agregarMotivo
	@codificacion varchar(10),
	@motivo varchar(50),
	@ap int
as
	insert into motivos (codificacion, motivo, ap)
	values (@codificacion, @motivo, @ap);
go

create procedure SP_editarMotivo
	@id int,
	@codificacion varchar(10),
	@motivo varchar(50),
	@ap int
as
	update motivos
	set	codificacion = @codificacion,
		motivo = @motivo,
		ap = @ap
	where id = @id;
go

create procedure SP_eliminarMotivo
	@id int
as
	delete from motivos
	where id = @id;
go

-- ------------------------------------------------------------------------------------ --
--  TABLA OPERACIONES  --
create procedure SP_listarOperacion
	@buscar varchar(10)
as
	select	operaciones.id, fecha, ET, nombreCampo, codificacionEquipo,
			responsables.responsable AS responsable, motivos.motivo as motivo,
			ens, operaciones.ap, descripcion, actuaciones, id_Equipamiento as equipoAsociado, observaciones
	from operaciones
	inner join motivos on operaciones.id_motivo = motivos.id
	inner join responsables on operaciones.id_responsable = responsables.id
	where operaciones.ET like '%' + @buscar + '%'
	order by fecha asc;
go

create procedure SP_listarOperacionEntreFechas
	@fechaInicial date,
	@fechaFinal date
as
	select	operaciones.id, fecha, ET, nombreCampo, codificacionEquipo,
			responsables.responsable AS responsable, motivos.motivo as motivo,
			ens, operaciones.ap, descripcion, actuaciones, id_Equipamiento as equipoAsociado, observaciones
	from operaciones
	inner join motivos on operaciones.id_motivo = motivos.id
	inner join responsables on operaciones.id_responsable = responsables.id
	where fecha >= @fechaInicial and fecha <= @fechaFinal
	order by fecha asc;
go

exec SP_listarOperacionEntreFechas '2006-06-05 00:00', '2012-11-09 00:00'

create procedure SP_agregarOperacion
	@id_Equipamiento int,
	@ET varchar(10),
	@nombreCampo varchar(100),
	@codificacionEquipo varchar(10),
	@fecha datetime,
	@id_Motivo int,
	@id_responsable int,
	@ens varchar(2),
	@ap int,
	@descripcion varchar(155),
	@actuaciones varchar(155),
	@observaciones varchar(1024)
as
	insert into operaciones
		(id_Equipamiento, ET, nombreCampo, codificacionEquipo, fecha, id_motivo, id_responsable, ens, ap,
		 descripcion, actuaciones, observaciones)
	values	(@id_Equipamiento, @ET, @nombreCampo, @codificacionEquipo, @fecha, @id_Motivo, @id_responsable,
			 @ens, @ap, @descripcion, @actuaciones, @observaciones);
go

create procedure SP_editarOperacion
	@id int,
	@id_Equipamiento int,
	@ET varchar(10),
	@nombreCampo varchar(100),
	@codificacionEquipo varchar(10),
	@fecha datetime,
	@id_Motivo int,
	@id_Responsable int,
	@ens varchar(2),
	@ap int,
	@descripcion varchar(155),
	@actuaciones varchar(155),
	@observaciones varchar(1024)
as
	update operaciones
	set	id_Equipamiento = @id_Equipamiento,
		ET = @ET,
		nombreCampo = @nombreCampo,
		codificacionEquipo = @codificacionEquipo,
		fecha = @fecha,
		id_motivo = @id_Motivo,
		id_responsable = @id_Responsable,
		ens = @ens,
		ap = @ap,
		descripcion = @descripcion,
		actuaciones = @actuaciones,
		observaciones = @observaciones
	where id = @id;

go

create procedure SP_eliminarOperacion
	@id int
as
	delete from operaciones
	where id = @id;
go

-- ------------------------------------------------------------------------------------ --
--  TABLA RESPONSABLES  --
create procedure SP_listarResponsable
as
	select * from responsables order by responsable asc;
go

create procedure SP_agregarResponsable
	@responsable varchar(70)
as
	insert into responsables (responsable)
	values (@responsable);
go

create procedure SP_editarResponsable
	@id int,
	@responsable varchar(70)
as
	update responsables
	set responsable = @responsable
	where id = @id;
go

create procedure SP_eliminarResponsable
	@id int
as
	delete from responsables
	where id = @id;
go
-- ------------------------------------------------------------------------------------ --
--  TABLA SISTEMAS  --
create procedure SP_listarSistema
as
	select EETT.id, EETT.codificacion, EETT.nombreCompleto, sistemas.nombreCompleto as sistema
	from EETT
	inner join sistemas on EETT.id_Sistema = sistemas.id;
go

create procedure SP_agregarSistema
	@codificacion varchar(10),
	@nombreCompleto varchar(100)
as
	insert into sistemas (codificacion, nombreCompleto)
	values	(@codificacion, @nombreCompleto);
go

create procedure SP_editarSistema
	@id int,
	@codificacion varchar(10),
	@nombreCompleto varchar(100)
as
	update sistemas
	set codificacion = @codificacion,
		nombreCompleto = @nombreCompleto
	where id = @id;
go

create procedure SP_eliminarSistema
	@id int
as
	delete from sistemas
	where id = @id;
go