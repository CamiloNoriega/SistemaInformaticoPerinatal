USE [master]
GO
/****** Object:  Database [SIPerinatal]    Script Date: 25/09/2024 10:29:16 p. m. ******/
CREATE DATABASE [SIPerinatal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SIPerinatal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SIPerinatal.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SIPerinatal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SIPerinatal_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SIPerinatal] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SIPerinatal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SIPerinatal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SIPerinatal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SIPerinatal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SIPerinatal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SIPerinatal] SET ARITHABORT OFF 
GO
ALTER DATABASE [SIPerinatal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SIPerinatal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SIPerinatal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SIPerinatal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SIPerinatal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SIPerinatal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SIPerinatal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SIPerinatal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SIPerinatal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SIPerinatal] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SIPerinatal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SIPerinatal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SIPerinatal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SIPerinatal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SIPerinatal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SIPerinatal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SIPerinatal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SIPerinatal] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SIPerinatal] SET  MULTI_USER 
GO
ALTER DATABASE [SIPerinatal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SIPerinatal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SIPerinatal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SIPerinatal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SIPerinatal] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SIPerinatal] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SIPerinatal] SET QUERY_STORE = ON
GO
ALTER DATABASE [SIPerinatal] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SIPerinatal]
GO
/****** Object:  Table [dbo].[AntecedentesFamiliares]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AntecedentesFamiliares](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDPaciente] [int] NOT NULL,
	[TBC] [bit] NOT NULL,
	[Diabetes] [bit] NOT NULL,
	[Hipertension] [bit] NOT NULL,
	[Preeclampsia] [bit] NOT NULL,
	[Eclampsia] [bit] NOT NULL,
	[OtraCondMedicaGrave] [bit] NOT NULL,
 CONSTRAINT [PK_AntecedentesFamiliares] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AntecedentesPersonales]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AntecedentesPersonales](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDPaciente] [int] NOT NULL,
	[TBC] [bit] NOT NULL,
	[IDDiabetesAPersonales] [int] NOT NULL,
	[DiabetesAPersonales] [varchar](50) NOT NULL,
	[Hipertension] [bit] NOT NULL,
	[Preeclampsia] [bit] NOT NULL,
	[Eclampsia] [bit] NOT NULL,
	[OtraCondMedicaGrave] [bit] NOT NULL,
 CONSTRAINT [PK_AntecedentesPersonales] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AntecedentesPObstetricos]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AntecedentesPObstetricos](
	[ID] [varchar](50) NOT NULL,
	[IDPaciente] [int] NOT NULL,
	[CirugiaGUrinaria] [bit] NOT NULL,
	[Infetilidad] [bit] NOT NULL,
	[Cardiopatia] [bit] NOT NULL,
	[Nefropatia] [bit] NOT NULL,
	[Violencia] [bit] NOT NULL,
	[VIH] [bit] NOT NULL,
	[GestasPrevias] [varchar](50) NOT NULL,
	[NacidosVivos] [varchar](50) NOT NULL,
	[Viven] [varchar](50) NOT NULL,
	[NacidosMuertos] [varchar](50) NOT NULL,
	[MuertosPrimeraSemana] [varchar](50) NOT NULL,
	[EmbaratoEctopico] [varchar](50) NOT NULL,
	[NumeroPartos] [varchar](50) NOT NULL,
	[PartosVaginales] [varchar](50) NOT NULL,
	[Cesareas] [varchar](50) NOT NULL,
	[IDPesoRecienNacido] [int] NOT NULL,
	[PesoRecienNacido] [varchar](50) NOT NULL,
	[Abortos] [varchar](50) NOT NULL,
	[TresAbortosConsecutivos] [bit] NOT NULL,
	[FechaFinEmbarazoAnterior] [datetime] NOT NULL,
	[IDUsoAnticonceptivos] [int] NOT NULL,
	[UsoAnticonceptivos] [bit] NOT NULL,
	[AntecedentesGemelares] [bit] NOT NULL,
	[EmbarazoPlaneado] [bit] NOT NULL,
 CONSTRAINT [PK_AntecedentesPObstetricos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatosPerinatales]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatosPerinatales](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDPaciente] [int] NOT NULL,
	[LugarControlPrenatal] [varchar](50) NOT NULL,
	[LugarPartoAborto] [varchar](50) NOT NULL,
	[NumeroDeIdentidad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DatosPerinatales] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiabetesAPersonales]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiabetesAPersonales](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DiabetesAPersonales] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiabetesEnfermedades]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiabetesEnfermedades](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DiabetesEnfermedades] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnfermedadesMaternas]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnfermedadesMaternas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDPaciente] [int] NOT NULL,
	[UnaoMas] [bit] NOT NULL,
	[HTAPrevia] [bit] NOT NULL,
	[HTAInducidaEmbarazo] [bit] NOT NULL,
	[Preeclampsia] [bit] NOT NULL,
	[Eclampsia] [bit] NOT NULL,
	[Cardiopatia] [bit] NOT NULL,
	[Nefropatia] [bit] NOT NULL,
	[IDDiabetesEnfermedades] [int] NOT NULL,
	[DiabetesEnfermedades] [varchar](50) NOT NULL,
	[InfeccionOvular] [bit] NOT NULL,
	[InfeccionUrinaria] [bit] NOT NULL,
	[AmenazaPartoPreter] [bit] NOT NULL,
	[RCIU] [bit] NOT NULL,
	[RoturaPremMembranas] [bit] NOT NULL,
	[Anemia] [bit] NOT NULL,
	[OtraCondGrave] [bit] NOT NULL,
	[HemorragiaPrimerTrimestre] [bit] NOT NULL,
	[HemorragiaSegundoTrimestre] [bit] NOT NULL,
	[HemorragiaTercerTrimestre] [bit] NOT NULL,
	[HemorragiaPostparto] [bit] NOT NULL,
	[HemorragiaInfeccionPuerperal] [bit] NOT NULL,
	[IDTdpSifilis] [int] NOT NULL,
	[TdpSifilis] [varchar](50) NOT NULL,
	[IDTdpVIH] [int] NOT NULL,
	[TdpVIH] [varchar](50) NOT NULL,
	[IDTARV] [int] NOT NULL,
	[TARV] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EnfermedadesMaternas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoCivil]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoCivil](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EstadoCivil] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Etnia]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etnia](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Etnia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NivelEstudios]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NivelEstudios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_NivelEstudios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Localidad] [varchar](50) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[IDEtnia] [int] NOT NULL,
	[Etnia] [bit] NOT NULL,
	[Alfabeta] [bit] NOT NULL,
	[IDNivelEstudio] [int] NOT NULL,
	[NivelEstudio] [bit] NOT NULL,
	[AñoAprobado] [bit] NOT NULL,
	[ViveSola] [bit] NOT NULL,
	[IDEstadoCivil] [int] NOT NULL,
	[EstadoCivil] [bit] NOT NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PesoRecienNacido]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PesoRecienNacido](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PesoRecienNacido] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TdpSifilis]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TdpSifilis](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TdpSifilis] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TdpTARV]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TdpTARV](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TdpTARV] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TdpVIH]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TdpVIH](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TdpVIH] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsoAnticonceptivos]    Script Date: 25/09/2024 10:29:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsoAnticonceptivos](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UsoAnticonceptivos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DiabetesAPersonales] ON 

INSERT [dbo].[DiabetesAPersonales] ([ID], [Nombre]) VALUES (1, N'No')
INSERT [dbo].[DiabetesAPersonales] ([ID], [Nombre]) VALUES (2, N'TipoI')
INSERT [dbo].[DiabetesAPersonales] ([ID], [Nombre]) VALUES (3, N'TipoII')
INSERT [dbo].[DiabetesAPersonales] ([ID], [Nombre]) VALUES (4, N'TipoG')
SET IDENTITY_INSERT [dbo].[DiabetesAPersonales] OFF
GO
SET IDENTITY_INSERT [dbo].[DiabetesEnfermedades] ON 

INSERT [dbo].[DiabetesEnfermedades] ([ID], [Nombre]) VALUES (1, N'No')
INSERT [dbo].[DiabetesEnfermedades] ([ID], [Nombre]) VALUES (2, N'TipoI')
INSERT [dbo].[DiabetesEnfermedades] ([ID], [Nombre]) VALUES (3, N'TipoII')
INSERT [dbo].[DiabetesEnfermedades] ([ID], [Nombre]) VALUES (4, N'TipoG')
SET IDENTITY_INSERT [dbo].[DiabetesEnfermedades] OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoCivil] ON 

INSERT [dbo].[EstadoCivil] ([ID], [Nombre]) VALUES (1, N'Soltera')
INSERT [dbo].[EstadoCivil] ([ID], [Nombre]) VALUES (2, N'Casada')
INSERT [dbo].[EstadoCivil] ([ID], [Nombre]) VALUES (3, N'UnionLibre ')
INSERT [dbo].[EstadoCivil] ([ID], [Nombre]) VALUES (4, N'Otro')
SET IDENTITY_INSERT [dbo].[EstadoCivil] OFF
GO
SET IDENTITY_INSERT [dbo].[Etnia] ON 

INSERT [dbo].[Etnia] ([ID], [Nombre]) VALUES (1, N'Blanca')
INSERT [dbo].[Etnia] ([ID], [Nombre]) VALUES (2, N'Negra')
INSERT [dbo].[Etnia] ([ID], [Nombre]) VALUES (3, N'Indigena')
INSERT [dbo].[Etnia] ([ID], [Nombre]) VALUES (4, N'Mestiza')
INSERT [dbo].[Etnia] ([ID], [Nombre]) VALUES (5, N'Otros')
SET IDENTITY_INSERT [dbo].[Etnia] OFF
GO
SET IDENTITY_INSERT [dbo].[NivelEstudios] ON 

INSERT [dbo].[NivelEstudios] ([ID], [Nombre]) VALUES (1, N'Primaria')
INSERT [dbo].[NivelEstudios] ([ID], [Nombre]) VALUES (2, N'Secundaria')
INSERT [dbo].[NivelEstudios] ([ID], [Nombre]) VALUES (3, N'Universidad')
INSERT [dbo].[NivelEstudios] ([ID], [Nombre]) VALUES (4, N'Ninguno')
SET IDENTITY_INSERT [dbo].[NivelEstudios] OFF
GO
SET IDENTITY_INSERT [dbo].[PesoRecienNacido] ON 

INSERT [dbo].[PesoRecienNacido] ([ID], [Nombre]) VALUES (1, N'nc')
INSERT [dbo].[PesoRecienNacido] ([ID], [Nombre]) VALUES (2, N'menos2500g')
INSERT [dbo].[PesoRecienNacido] ([ID], [Nombre]) VALUES (3, N'mas4000g')
INSERT [dbo].[PesoRecienNacido] ([ID], [Nombre]) VALUES (4, N'Normal')
SET IDENTITY_INSERT [dbo].[PesoRecienNacido] OFF
GO
SET IDENTITY_INSERT [dbo].[TdpSifilis] ON 

INSERT [dbo].[TdpSifilis] ([ID], [Nombre]) VALUES (1, N'Negativo')
INSERT [dbo].[TdpSifilis] ([ID], [Nombre]) VALUES (2, N'Positivo')
INSERT [dbo].[TdpSifilis] ([ID], [Nombre]) VALUES (3, N'Nr')
INSERT [dbo].[TdpSifilis] ([ID], [Nombre]) VALUES (4, N'Nc')
SET IDENTITY_INSERT [dbo].[TdpSifilis] OFF
GO
SET IDENTITY_INSERT [dbo].[TdpTARV] ON 

INSERT [dbo].[TdpTARV] ([ID], [Nombre]) VALUES (1, N'Si')
INSERT [dbo].[TdpTARV] ([ID], [Nombre]) VALUES (2, N'No')
INSERT [dbo].[TdpTARV] ([ID], [Nombre]) VALUES (3, N'Nc')
SET IDENTITY_INSERT [dbo].[TdpTARV] OFF
GO
SET IDENTITY_INSERT [dbo].[TdpVIH] ON 

INSERT [dbo].[TdpVIH] ([ID], [Nombre]) VALUES (1, N'Negativo')
INSERT [dbo].[TdpVIH] ([ID], [Nombre]) VALUES (2, N'Positivo')
INSERT [dbo].[TdpVIH] ([ID], [Nombre]) VALUES (3, N'Nr')
INSERT [dbo].[TdpVIH] ([ID], [Nombre]) VALUES (4, N'Nc')
SET IDENTITY_INSERT [dbo].[TdpVIH] OFF
GO
INSERT [dbo].[UsoAnticonceptivos] ([ID], [Nombre]) VALUES (1, N'NoUsaba')
INSERT [dbo].[UsoAnticonceptivos] ([ID], [Nombre]) VALUES (2, N'Barrera')
INSERT [dbo].[UsoAnticonceptivos] ([ID], [Nombre]) VALUES (3, N'Emergencia')
INSERT [dbo].[UsoAnticonceptivos] ([ID], [Nombre]) VALUES (4, N'Hormonal')
INSERT [dbo].[UsoAnticonceptivos] ([ID], [Nombre]) VALUES (5, N'DIU')
INSERT [dbo].[UsoAnticonceptivos] ([ID], [Nombre]) VALUES (6, N'Natural')
GO
ALTER TABLE [dbo].[AntecedentesFamiliares]  WITH CHECK ADD  CONSTRAINT [FK_AntecedentesFamiliares_Paciente] FOREIGN KEY([IDPaciente])
REFERENCES [dbo].[Paciente] ([ID])
GO
ALTER TABLE [dbo].[AntecedentesFamiliares] CHECK CONSTRAINT [FK_AntecedentesFamiliares_Paciente]
GO
ALTER TABLE [dbo].[AntecedentesPersonales]  WITH CHECK ADD  CONSTRAINT [FK_AntecedentesPersonales_DiabetesAPersonales] FOREIGN KEY([IDDiabetesAPersonales])
REFERENCES [dbo].[DiabetesAPersonales] ([ID])
GO
ALTER TABLE [dbo].[AntecedentesPersonales] CHECK CONSTRAINT [FK_AntecedentesPersonales_DiabetesAPersonales]
GO
ALTER TABLE [dbo].[AntecedentesPersonales]  WITH CHECK ADD  CONSTRAINT [FK_AntecedentesPersonales_Paciente] FOREIGN KEY([IDPaciente])
REFERENCES [dbo].[Paciente] ([ID])
GO
ALTER TABLE [dbo].[AntecedentesPersonales] CHECK CONSTRAINT [FK_AntecedentesPersonales_Paciente]
GO
ALTER TABLE [dbo].[AntecedentesPObstetricos]  WITH CHECK ADD  CONSTRAINT [FK_AntecedentesPObstetricos_Paciente] FOREIGN KEY([IDPaciente])
REFERENCES [dbo].[Paciente] ([ID])
GO
ALTER TABLE [dbo].[AntecedentesPObstetricos] CHECK CONSTRAINT [FK_AntecedentesPObstetricos_Paciente]
GO
ALTER TABLE [dbo].[AntecedentesPObstetricos]  WITH CHECK ADD  CONSTRAINT [FK_AntecedentesPObstetricos_Paciente1] FOREIGN KEY([IDPaciente])
REFERENCES [dbo].[Paciente] ([ID])
GO
ALTER TABLE [dbo].[AntecedentesPObstetricos] CHECK CONSTRAINT [FK_AntecedentesPObstetricos_Paciente1]
GO
ALTER TABLE [dbo].[AntecedentesPObstetricos]  WITH CHECK ADD  CONSTRAINT [FK_AntecedentesPObstetricos_PesoRecienNacido] FOREIGN KEY([IDPesoRecienNacido])
REFERENCES [dbo].[PesoRecienNacido] ([ID])
GO
ALTER TABLE [dbo].[AntecedentesPObstetricos] CHECK CONSTRAINT [FK_AntecedentesPObstetricos_PesoRecienNacido]
GO
ALTER TABLE [dbo].[AntecedentesPObstetricos]  WITH CHECK ADD  CONSTRAINT [FK_AntecedentesPObstetricos_UsoAnticonceptivos1] FOREIGN KEY([IDUsoAnticonceptivos])
REFERENCES [dbo].[UsoAnticonceptivos] ([ID])
GO
ALTER TABLE [dbo].[AntecedentesPObstetricos] CHECK CONSTRAINT [FK_AntecedentesPObstetricos_UsoAnticonceptivos1]
GO
ALTER TABLE [dbo].[DatosPerinatales]  WITH CHECK ADD  CONSTRAINT [FK_DatosPerinatales_Paciente] FOREIGN KEY([IDPaciente])
REFERENCES [dbo].[Paciente] ([ID])
GO
ALTER TABLE [dbo].[DatosPerinatales] CHECK CONSTRAINT [FK_DatosPerinatales_Paciente]
GO
ALTER TABLE [dbo].[EnfermedadesMaternas]  WITH CHECK ADD  CONSTRAINT [FK_EnfermedadesMaternas_DiabetesEnfermedades] FOREIGN KEY([IDDiabetesEnfermedades])
REFERENCES [dbo].[DiabetesEnfermedades] ([ID])
GO
ALTER TABLE [dbo].[EnfermedadesMaternas] CHECK CONSTRAINT [FK_EnfermedadesMaternas_DiabetesEnfermedades]
GO
ALTER TABLE [dbo].[EnfermedadesMaternas]  WITH CHECK ADD  CONSTRAINT [FK_EnfermedadesMaternas_Paciente] FOREIGN KEY([IDPaciente])
REFERENCES [dbo].[Paciente] ([ID])
GO
ALTER TABLE [dbo].[EnfermedadesMaternas] CHECK CONSTRAINT [FK_EnfermedadesMaternas_Paciente]
GO
ALTER TABLE [dbo].[EnfermedadesMaternas]  WITH CHECK ADD  CONSTRAINT [FK_EnfermedadesMaternas_TdpSifilis] FOREIGN KEY([IDTdpSifilis])
REFERENCES [dbo].[TdpSifilis] ([ID])
GO
ALTER TABLE [dbo].[EnfermedadesMaternas] CHECK CONSTRAINT [FK_EnfermedadesMaternas_TdpSifilis]
GO
ALTER TABLE [dbo].[EnfermedadesMaternas]  WITH CHECK ADD  CONSTRAINT [FK_EnfermedadesMaternas_TdpTARV] FOREIGN KEY([IDTARV])
REFERENCES [dbo].[TdpTARV] ([ID])
GO
ALTER TABLE [dbo].[EnfermedadesMaternas] CHECK CONSTRAINT [FK_EnfermedadesMaternas_TdpTARV]
GO
ALTER TABLE [dbo].[EnfermedadesMaternas]  WITH CHECK ADD  CONSTRAINT [FK_EnfermedadesMaternas_TdpVIH] FOREIGN KEY([IDTdpVIH])
REFERENCES [dbo].[TdpVIH] ([ID])
GO
ALTER TABLE [dbo].[EnfermedadesMaternas] CHECK CONSTRAINT [FK_EnfermedadesMaternas_TdpVIH]
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_EstadoCivil] FOREIGN KEY([IDEstadoCivil])
REFERENCES [dbo].[EstadoCivil] ([ID])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_EstadoCivil]
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_Etnia] FOREIGN KEY([IDEtnia])
REFERENCES [dbo].[Etnia] ([ID])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_Etnia]
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_NivelEstudios] FOREIGN KEY([IDEstadoCivil])
REFERENCES [dbo].[NivelEstudios] ([ID])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_NivelEstudios]
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_NivelEstudios1] FOREIGN KEY([IDNivelEstudio])
REFERENCES [dbo].[NivelEstudios] ([ID])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_NivelEstudios1]
GO
USE [master]
GO
ALTER DATABASE [SIPerinatal] SET  READ_WRITE 
GO
