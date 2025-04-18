USE [Parcial_1_EmilyChiriboga]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiantes](
	[EstudianteId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Telefono] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Estudiantes] PRIMARY KEY CLUSTERED 
(
	[EstudianteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evaluaciones]    Script Date: 16/04/2025 11:08:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluaciones](
	[EvaluacionId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Descripcion] [nvarchar](250) NOT NULL,
	[Fecha] [date] NOT NULL,
	[PuntajeMaximo] [float] NOT NULL,
	[Tipo] [int] NOT NULL,
	[Materia] [int] NOT NULL,
 CONSTRAINT [PK_Evaluaciones] PRIMARY KEY CLUSTERED 
(
	[EvaluacionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resultados](
	[ResultadosId] [int] IDENTITY(1,1) NOT NULL,
	[EstudianteId] [int] NOT NULL,
	[EvaluacionId] [int] NOT NULL,
	[PuntajeObtenido] [float] NOT NULL,
	[Comentarios] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Resultados] PRIMARY KEY CLUSTERED 
(
	[ResultadosId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoEvaluacion](
	[TipoEvaluacionId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TipoEvaluacion] PRIMARY KEY CLUSTERED 
(
	[TipoEvaluacionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoMateria](
	[TipoMateriaId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TipoMateria] PRIMARY KEY CLUSTERED 
(
	[TipoMateriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Evaluaciones]  WITH CHECK ADD  CONSTRAINT [FK_Evaluaciones_TipoEvaluacion] FOREIGN KEY([Tipo])
REFERENCES [dbo].[TipoEvaluacion] ([TipoEvaluacionId])
GO
ALTER TABLE [dbo].[Evaluaciones] CHECK CONSTRAINT [FK_Evaluaciones_TipoEvaluacion]
GO
ALTER TABLE [dbo].[Evaluaciones]  WITH CHECK ADD  CONSTRAINT [FK_Evaluaciones_TipoMateria] FOREIGN KEY([Materia])
REFERENCES [dbo].[TipoMateria] ([TipoMateriaId])
GO
ALTER TABLE [dbo].[Evaluaciones] CHECK CONSTRAINT [FK_Evaluaciones_TipoMateria]
GO
ALTER TABLE [dbo].[Resultados]  WITH CHECK ADD  CONSTRAINT [FK_Resultados_Estudiantes] FOREIGN KEY([EstudianteId])
REFERENCES [dbo].[Estudiantes] ([EstudianteId])
GO
ALTER TABLE [dbo].[Resultados] CHECK CONSTRAINT [FK_Resultados_Estudiantes]
GO
ALTER TABLE [dbo].[Resultados]  WITH CHECK ADD  CONSTRAINT [FK_Resultados_Evaluaciones] FOREIGN KEY([EvaluacionId])
REFERENCES [dbo].[Evaluaciones] ([EvaluacionId])
GO
ALTER TABLE [dbo].[Resultados] CHECK CONSTRAINT [FK_Resultados_Evaluaciones]
GO
