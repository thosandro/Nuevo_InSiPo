select * from operaciones order by idCampo asc;
-- 52 Interruptor -- 29 Seccionador --

update operaciones
set et = 'ET2CA', sistema = 'CO', 
tension = '33 kV', nombreEquipo = 'TP1', idEquipo = '252/TP1'
where idCampo = '2CAGTP1';

select * from operaciones where idCampo = '1CCPAL4';

select * from operaciones where idCampo like '1AL%' order by idCampo asc;

select distinct idCampo, nombreEquipo from operaciones where idCampo like '1AL%';

select distinct idCampo, nombreEquipo from operaciones where nombreEquipo!='' order by idCampo asc;

select distinct idCampo, nombreEquipo, et from operaciones order by idCampo asc;

update operaciones
set sistema = 'CO'
where et = 'PS3GR'

select distinct idCampo from operaciones where responsable = 'CIPOLLETTI SUCURSAL' order by idCampo asc;

select * from EETT order by idEETT asc;

select * from responsable;

select fecha from operaciones;

