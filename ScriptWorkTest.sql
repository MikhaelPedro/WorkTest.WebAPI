USE [master]
GO

/****** Object:  Database [RegisterApp]    Script Date: 10/03/2021 15:46:43 ******/
CREATE DATABASE [RegisterApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RegisterApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RegisterApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RegisterApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RegisterApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RegisterApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [RegisterApp] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [RegisterApp] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [RegisterApp] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [RegisterApp] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [RegisterApp] SET ARITHABORT OFF 
GO

ALTER DATABASE [RegisterApp] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [RegisterApp] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [RegisterApp] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [RegisterApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [RegisterApp] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [RegisterApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [RegisterApp] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [RegisterApp] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [RegisterApp] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [RegisterApp] SET  ENABLE_BROKER 
GO

ALTER DATABASE [RegisterApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [RegisterApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [RegisterApp] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [RegisterApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [RegisterApp] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [RegisterApp] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [RegisterApp] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [RegisterApp] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [RegisterApp] SET  MULTI_USER 
GO

ALTER DATABASE [RegisterApp] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [RegisterApp] SET DB_CHAINING OFF 
GO

ALTER DATABASE [RegisterApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [RegisterApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [RegisterApp] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [RegisterApp] SET QUERY_STORE = OFF
GO

ALTER DATABASE [RegisterApp] SET  READ_WRITE 
GO
