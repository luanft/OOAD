ALTER DATABASE [QUANLYDULICH] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYDULICH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [QUANLYDULICH] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET ARITHABORT OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [QUANLYDULICH] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [QUANLYDULICH] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [QUANLYDULICH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [QUANLYDULICH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET  ENABLE_BROKER 
GO

ALTER DATABASE [QUANLYDULICH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [QUANLYDULICH] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [QUANLYDULICH] SET  MULTI_USER 
GO

ALTER DATABASE [QUANLYDULICH] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [QUANLYDULICH] SET DB_CHAINING OFF 
GO

ALTER DATABASE [QUANLYDULICH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [QUANLYDULICH] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [QUANLYDULICH] SET  READ_WRITE 
GO


