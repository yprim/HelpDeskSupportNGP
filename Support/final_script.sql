USE [master]
GO
/****** Object:  Database [2020HelpDeskNGP]    Script Date: 2/25/2020 12:37:27 AM ******/
CREATE DATABASE [2020HelpDeskNGP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'2020HelpDeskNGP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\2020HelpDeskNGP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'2020HelpDeskNGP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\2020HelpDeskNGP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [2020HelpDeskNGP] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [2020HelpDeskNGP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [2020HelpDeskNGP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET ARITHABORT OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [2020HelpDeskNGP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [2020HelpDeskNGP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [2020HelpDeskNGP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [2020HelpDeskNGP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET RECOVERY FULL 
GO
ALTER DATABASE [2020HelpDeskNGP] SET  MULTI_USER 
GO
ALTER DATABASE [2020HelpDeskNGP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [2020HelpDeskNGP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [2020HelpDeskNGP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [2020HelpDeskNGP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [2020HelpDeskNGP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [2020HelpDeskNGP] SET QUERY_STORE = OFF
GO
USE [2020HelpDeskNGP]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [2020HelpDeskNGP]
GO
/****** Object:  Table [dbo].[Comment_Client]    Script Date: 2/25/2020 12:37:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment_Client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](250) NOT NULL,
	[note_timestamp] [varchar](50) NULL,
	[id_issue] [int] NULL,
	[report_number] [varchar](100) NULL,
 CONSTRAINT [PK_Comment_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Issue_Client]    Script Date: 2/25/2020 12:37:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Issue_Client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[report_number] [varchar](100) NOT NULL,
	[register_timestamp] [varchar](50) NULL,
	[address] [varchar](250) NOT NULL,
	[contact_phone] [varchar](50) NOT NULL,
	[contact_email] [varchar](50) NOT NULL,
	[status] [varchar](50) NOT NULL,
	[support_user_asigned] [varchar](50) NULL,
	[id_user] [int] NULL,
	[description] [varchar](50) NULL,
	[service] [varchar](50) NULL,
 CONSTRAINT [PK_Issue_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Issue_Support]    Script Date: 2/25/2020 12:37:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Issue_Support](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[report_number] [varchar](50) NOT NULL,
	[classification] [varchar](50) NOT NULL,
	[status] [varchar](50) NOT NULL,
	[report_timestamp] [varchar](50) NULL,
	[resolution_comment] [varchar](50) NULL,
	[id_supporter] [int] NULL,
	[description] [varchar](50) NULL,
	[service] [varchar](50) NULL,
 CONSTRAINT [PK_Issue_Support] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notes_Support]    Script Date: 2/25/2020 12:37:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notes_Support](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](250) NOT NULL,
	[note_timestamp] [varchar](50) NULL,
	[id_issue] [int] NULL,
 CONSTRAINT [PK_Notes_Support] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supervisor_Support]    Script Date: 2/25/2020 12:37:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supervisor_Support](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[first_surname] [varchar](50) NOT NULL,
	[second_surname] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Supervisor_Support] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supporter_Support]    Script Date: 2/25/2020 12:37:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supporter_Support](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[first_surname] [varchar](50) NOT NULL,
	[second_surname] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[id_supervisor] [int] NULL,
	[password] [varchar](50) NOT NULL,
	[television] [int] NULL,
	[mobile_phone] [int] NULL,
	[telephone] [int] NULL,
	[internet] [int] NULL,
 CONSTRAINT [PK_Supporter_Support] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Client]    Script Date: 2/25/2020 12:37:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[first_surname] [varchar](50) NOT NULL,
	[second_surname] [varchar](50) NOT NULL,
	[address] [varchar](250) NOT NULL,
	[phone] [varchar](50) NOT NULL,
	[second_contact] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[television] [int] NULL,
	[mobile_phone] [int] NULL,
	[telephone] [int] NULL,
	[internet] [int] NULL,
 CONSTRAINT [PK_User_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Comment_Client]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Client_Issue_Client] FOREIGN KEY([id_issue])
REFERENCES [dbo].[Issue_Client] ([id])
GO
ALTER TABLE [dbo].[Comment_Client] CHECK CONSTRAINT [FK_Comment_Client_Issue_Client]
GO
ALTER TABLE [dbo].[Issue_Client]  WITH CHECK ADD  CONSTRAINT [FK_Issue_Client_User_Client] FOREIGN KEY([id_user])
REFERENCES [dbo].[User_Client] ([id])
GO
ALTER TABLE [dbo].[Issue_Client] CHECK CONSTRAINT [FK_Issue_Client_User_Client]
GO
ALTER TABLE [dbo].[Issue_Support]  WITH CHECK ADD FOREIGN KEY([id_supporter])
REFERENCES [dbo].[Supporter_Support] ([id])
GO
ALTER TABLE [dbo].[Notes_Support]  WITH CHECK ADD  CONSTRAINT [FK_Notes_Support_Issue_Support] FOREIGN KEY([id_issue])
REFERENCES [dbo].[Issue_Support] ([id])
GO
ALTER TABLE [dbo].[Notes_Support] CHECK CONSTRAINT [FK_Notes_Support_Issue_Support]
GO
ALTER TABLE [dbo].[Supporter_Support]  WITH CHECK ADD  CONSTRAINT [FK_Supporter_Supervisor] FOREIGN KEY([id_supervisor])
REFERENCES [dbo].[Supervisor_Support] ([id])
GO
ALTER TABLE [dbo].[Supporter_Support] CHECK CONSTRAINT [FK_Supporter_Supervisor]
GO
USE [master]
GO
ALTER DATABASE [2020HelpDeskNGP] SET  READ_WRITE 
GO
