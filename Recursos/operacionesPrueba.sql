USE [insipoCod]

insert into operacionesPrueba (fecha, et, sistema, tension, idCampo, nombreEquipo, idEquipo, motivo,
								responsable, ens, ap, descripcion, actuaciones, observaciones)
select fecha, et, sistema, tension, idCampo, nombreEquipo, idEquipo, motivo, responsable, ens, ap, descripcion,
		actuaciones, observaciones
	from operaciones
	where 
		(et = 'CD1CI'
		or et = 'CD1CS'
		or et = 'ET2CA'
		or et = 'ET2CG'
		or et = 'ET2CI'
		or et = 'ET3AL'
		or et = 'ET3GU'
		or et = 'ET3IH')
		and nombreEquipo!='';



drop table operacionesPrueba;



USE [insipoCod]
GO

/****** Object:  Table [dbo].[operacionesPrueba]    Script Date: 6/2/2020 05:42:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[operacionesPrueba](
	[idTabla] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[et] [varchar](40) NOT NULL,
	[sistema] [varchar](5) NOT NULL,
	[tension] [varchar](8) NOT NULL,
	[idCampo] [varchar](60) NOT NULL,
	[nombreEquipo] [varchar](60) NOT NULL,
	[idEquipo] [varchar](20) NULL,
	[motivo] [varchar](40) NOT NULL,
	[responsable] [varchar](50) NOT NULL,
	[ens] [varchar](2) NOT NULL,
	[ap] [int] NULL,
	[descripcion] [varchar](155) NOT NULL,
	[actuaciones] [varchar](155) NULL,
	[observaciones] [varchar](1024) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTabla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO




