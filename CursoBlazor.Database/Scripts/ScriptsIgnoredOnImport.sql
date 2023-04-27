
USE [master]
GO

/****** Object:  Database [CursoBlazor]    Script Date: 27/04/2023 01:15:16 p. m. ******/
CREATE DATABASE [CursoBlazor]
GO

USE [CursoBlazor]
GO

/****** Object:  Table [dbo].[Careers]    Script Date: 27/04/2023 01:15:16 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Courses]    Script Date: 27/04/2023 01:15:16 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Instructors]    Script Date: 27/04/2023 01:15:16 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[PaymentReceipts]    Script Date: 27/04/2023 01:15:16 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Students]    Script Date: 27/04/2023 01:15:16 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

INSERT [dbo].[Careers] ([CareerId], [CareerKey], [Name], [Description], [CreatedDate], [ModifiedDate]) VALUES (N'e77ea6e9-f5a7-407e-a3c9-f454deff6277', N'IINF-2010-220', N'Ingeniería Informática', N'Ingeniería Informática del Itsao', CAST(N'2023-04-26T20:40:38.673' AS DateTime), NULL)
GO

USE [master]
GO

ALTER DATABASE [CursoBlazor] SET  READ_WRITE
GO
