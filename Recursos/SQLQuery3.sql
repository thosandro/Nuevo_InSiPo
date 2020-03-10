go
create procedure SP_listarEETT
	@buscar varchar(15)
as
	select *
	from EETT
	where nombreET like ('%' + @buscar + '%');
go

drop procedure SP_listarEETT;

execute SP_listarEETT @buscar = 'CIPOLLETTI';


select * from EETT;
