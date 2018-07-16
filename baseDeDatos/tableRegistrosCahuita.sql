USE [CAHUITA]
GO

/****** Object:  Table [dbo].[REGISTROS]    Script Date: 2/7/2018 11:09:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[REGISTROS](
	[nombre] [varchar](20) NOT NULL,
	[apellido] [varchar](30) NOT NULL,
	[correo] [varchar](40) NOT NULL,
	[fecha_De_Nacimiento] [date] NOT NULL,
	[id] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


