--  TABLA SISTEMAS --
insert into sistemas (codificacion, nombreCompleto)
values	('AN',	'Sistema Andino'),
		('AT',	'Sistema Atlántico'),
		('CO',	'Sistema Comahue'),
		('VM',	'Sistema Valle Medio');

select * from sistemas;

--  TABLA EETT  --
insert into EETT (codificacion, nombreCompleto, id_Sistema)
values	('ET3AL',	'ET 66 kV - Allen',	3),
		('ET4BA',	'ET 132 kV - Bariloche',	1),
		('ET4VI',	'ET 132 kV - Viedma',	2),
		('ET3LB',	'ET 66 kV - Luis Beltrán',	4);

select * from EETT;

--  TABLA EQUIPAMIENTO  --
insert into equipamiento (id_ET, id_Sistema, nivelTension, nombreCampo, tipoDeEquipo, codificacion, accionOperativa, ultimaModificacion)
values
(1, 3, 13.2, 'Alimentador Allen', 'Reconectador', '1RC/Al', 'Maniobra', '06/03/2020'),
(1, 3, 13.2, 'Alimentador Barrio Norte', 'Seccionador', '129/BN', 'Corte Visible', '06/03/2020'),
(2, 1, 33, 'Interconexion CT', 'Interruptor', '252/CT', 'Maniobra', '06/06/2020'),
(2, 1, 132, 'Salida Pilcaniyeu', 'Seccionador', '429L/BAPI', 'Corte Visible', '06/03/2020'),
(3, 2, 13.2, 'Alimentador Viedma 1', 'Interruptor', '152/V1', 'Maniobra', '06/06/2020'),
(3, 2, 33, 'Alimentador Viedma 1', 'TI', '1TI/V1', 'Medición', '06/03/2020'),
(4, 4, 66, 'Salida Céspedes', 'Interruptor', '352/LBCE', 'Maniobra', '06/03/2020'),
(4, 4, 13.2, 'Alimentador Expofrut', 'TI', '1TI/Ex', 'Medición', '06/03/2020'),
(1,	3, 13.2, 'Alimentador Barrio Norte', 'Reconectador', '1RC/BN', 'Maniobra', '2020-03-08'),
(2,	1, 132, 'Salida Pilcaniyeu', 'Interruptor', '452/BAPI', 'Maniobra', '2020-03-08'),
(3,	2, 132, 'Salida C. de Patagones', 'Interruptor', '452/VICP', 'Maniobra', '2020-03-08'),
(4,	4, 13.2, 'Alimentador Expofrut', 'Interruptor', '152/Ex', 'Maniobra', '2020-03-080');

select * from equipamiento;

--  TABLA MOTIVOS  --
insert into motivos (codificacion, motivo, ap)
values	('APU', 'A pedido del usuario', 1),
		('CAAC', 'Cambio de aceite', 0),
		('ERROR', 'Error operativo', 1),
		('FALLA', 'Falla', 1),
		('MANOP', 'Maniobra operativa', 0),
		('MAPRO', 'Mantenimiento programado', 0),
		('MINFR', 'Mínima frecuencia', 4),
		('OBS', 'Observaciones', 0),
		('RESCA', 'Restricción de carga', 3),
		('SVPF', 'Sin tensión por falla', 1);

select * from motivos;

--  TABLA RESPONSABLES --
insert into responsables (responsable)
values ('Allen Sucursal'), ('CEB'), ('Viedma Sucursal'), ('IPE'), ('Choel Choel Sucursal'), ('Mantenimiento'), ('COD');

select * from responsables;

-- TABLA OPERACIONES  --
insert into operaciones (id_Equipamiento, ET, nombreCampo, codificacionEquipo, fecha, id_motivo, id_responsable, ens, ap, descripcion, actuaciones)
values	(1, 'ET3AL', 'Alimentador Allen', '1RC/Al', '01/03/2000 15:06', 1, 1, 'No', 1, 'Se abre Reconectador A pedido del usuario', ''),
		(3, 'ET4BA', 'Interconexion CT', '252/CT', '03/05/2003 17:09', 3, 7, 'No', 1, 'Se abre Interruptor por Error operativo', ''),
		(5, 'ET4VI', 'Alimentador Viedma 1', '152/V1', '05/07/2006 19:12', 5, 3, 'No', 0, 'Se abre Interruptor por Maniobra operativa', ''),
		(7, 'ET3LB', 'Salida Céspedes', '352/LBCE', '07/09/2009 21:15', 7, 6, 'No', 4, 'Disparo Interruptor por Mínima frecuencia', ''), 
		(1, 'ET3AL', 'Alimentador Allen', '1RC/Al', '09/11/2012 23:18', 9, 1, 'No', 3, 'Se abre Reconectador por Restricción de carga', ''),
		(3, 'ET4BA', 'Interconexion CT', '252/CT', '11/01/2015 01:21', 2, 7, 'No', 0, 'Se abre Interruptor por Cambio de aceite', ''),
		(5, 'ET4VI', 'Alimentador Viedma 1', '152/V1', '01/03/2018 03:24', 4, 3, 'No', 1, 'Disparo Interruptor por Falla', 'Corriente máxima de fase'),
		(7, 'ET3LB', 'Salida Céspedes', '352/LBCE', '03/04/2001 04:27', 6, 6, 'No', 0, 'Se abre Interruptor por Mantenimiento programado', ''),
		(1, 'ET3AL', 'Alimentador Allen', '1RC/Al', '04/06/2004 06:30', 8, 1, 'No', 0, 'Observaciones', ''),
		(3, 'ET4BA', 'Interconexion CT', '252/CT', '06/08/2010 08:33', 10, 7, 'No', 1, 'Se abre Interruptor Sin tensión por falla', ''),
		(5, 'ET4VI', 'Alimentador Viedma 1', '152/V1', '08/10/2016 10:36', 1, 3, 'No', 1, 'Se abre Interruptor A pedido del usuario', ''),
		(7, 'ET3LB', 'Salida Céspedes', '352/LBCE', '10/12/2019 12:39', 7, 6, 'No', 4, 'Disparo Interrptor por Mínima frecuencia', '');
        
update operaciones set fecha = '2000-03-01 15:06' where id = 1;
update operaciones set fecha = '2003-05-03 17:09' where id = 2;
update operaciones set fecha = '2006-07-05 19:12' where id = 3;
update operaciones set fecha = '2009-09-07 21:15' where id = 4;
update operaciones set fecha = '2012-09-11 23:18' where id = 5;
update operaciones set fecha = '2015-01-11 01:21' where id = 6;
update operaciones set fecha = '2018-03-01 03:24' where id = 7;
update operaciones set fecha = '2001-03-04 04:27' where id = 8;
update operaciones set fecha = '2004-06-04 06:30' where id = 9;
update operaciones set fecha = '2010-08-06 08:33' where id = 10;
update operaciones set fecha = '2016-10-08 10:36' where id = 11;
update operaciones set fecha = '2019-12-10 12:39' where id = 12;


select * from operaciones;