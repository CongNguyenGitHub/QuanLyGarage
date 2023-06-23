USE [master]
GO

/****** Object:  Database [QuanLyGarage]    Script Date: 5/31/2023 11:3:32 PM ******/
CREATE DATABASE [QuanLyGarage]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyGarage', FILENAME = N'E:\QuanLyGarage.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyGarage_log', FILENAME = N'E:\QuanLyGarage_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [QuanLyGarage] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyGarage].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyGarage] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyGarage] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyGarage] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyGarage] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyGarage] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyGarage] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyGarage] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyGarage] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyGarage] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyGarage] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyGarage] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyGarage] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyGarage] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyGarage] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyGarage] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyGarage] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyGarage] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyGarage] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyGarage] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyGarage] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyGarage] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyGarage] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyGarage] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyGarage] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyGarage] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyGarage] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyGarage] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyGarage] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyGarage] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyGarage', N'ON'
GO
ALTER DATABASE [QuanLyGarage] SET QUERY_STORE = OFF
GO
USE [QuanLyGarage]
GO

/****** Object:  Table [dbo].[QUYDINH]    Script Date: 5/31/2023 11:12:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO]
(
	[MaThamSo] [int] IDENTITY(1,1),
	[TenThamSo] [nvarchar](100) NOT NULL,
	[GiaTri] [int] NOT NULL,
	PRIMARY KEY CLUSTERED
	(
		[MaThamSo] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[KHACHHANG]		Scripyt Date: 5/31/2023 24:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG]
(
	[MaKH] [int] IDENTITY(1,1),
	[TenKH] [nvarchar](50) NOT NULL,
	[DienThoai] [varchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[TienNo] [int] NOT NULL DEFAULT 0,
	PRIMARY KEY  CLUSTERED
	(
		[MaKH] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[NGUOIDUNG]		Scripyt Date: 5/31/2023 24:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOIDUNG]
(
	[MaNguoiDung] [int] IDENTITY(1,1),
	[TenND] [nvarchar](50) NOT NULL,
	[GioiTinh] [int] NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[NgaySinh] [date]  NULL,
	[DienThoai] [varchar](50) NOT NULL,
	PRIMARY KEY  CLUSTERED
	(
		[MaNguoiDung] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[TAIKHOAN]		Scripyt Date: 5/31/2023 24:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN]
(
	[MaTK] [int] IDENTITY(1,1),
	[MaNguoiDung] [int] NOT NULL,
	[TenDangNhap] [varchar](20) NOT NULL,
	[MatKhau] [varchar](20) NOT NULL,
	[QuyenHan] [bit] NOT NULL,
	PRIMARY KEY  CLUSTERED
	(
		[MaTK] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[XE]		Scripyt Date: 5/31/2023 34:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XE]
(
	[BienSo] [varchar](10) NOT NULL,
	[MaKH] [int] NOT NULL,
	[HieuXe] [varchar](50) NOT NULL,
	[NgayTiepNhan] [datetime] NULL,
	[TrangThai] [int] DEFAULT 1,  ---- 1 là xe vẫn còn trong garage, còn lại là không còn
	PRIMARY KEY CLUSTERED
	(
		[BienSo] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[XE_2]		Scripyt Date: 5/31/2023 34:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XE_2]
(
	[BienSo] [varchar](10) NOT NULL,
	[MaKH] [int] NOT NULL,
	[HieuXe] [varchar](50) NOT NULL,
	[NgayTiepNhan] [datetime] NULL,
	[TrangThai] [int] DEFAULT 1,  ---- 1 là xe vẫn còn trong garage, còn lại là không còn
	PRIMARY KEY CLUSTERED
	(
		[BienSo] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[KHO]		Scripyt Date: 5/31/2023 34:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHO]
(
	[MaPhuTung] [int] IDENTITY(1,1),
	[TenVatTuPhuTung] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
	PRIMARY KEY CLUSTERED 
	(
		[MaPhuTung] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[TIENCONG]		Scripyt Date: 5/31/2023 34:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIENCONG]
(
	[MaTC] [int] IDENTITY(1,1),
	[TenTienCong] [nvarchar](50) NOT NULL,
	[ChiPhi] [int] NOT NULL,
	PRIMARY KEY CLUSTERED 
	(
		[MaTC] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[PHIEUSUACHUA]		Scripyt Date: 5/31/2023 34:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUSUACHUA]
(
	[MaPhieuSuaChua] [int] IDENTITY(1,1),
	[BienSo] [varchar](10) NOT NULL,
	[NgaySuaChua] [datetime] NOT NULL,
	[MaKH] [int] NOT NULL,
	[TongTien] [int] NOT NULL
	PRIMARY KEY CLUSTERED
	(
		[MaPhieuSuaChua] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[PHIEUSUACHUA_2]		Scripyt Date: 5/31/2023 34:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUSUACHUA_2]
(
	[MaPhieuSuaChua] [int] IDENTITY(1,1),
	[BienSo] [varchar](10) NOT NULL,
	[NgaySuaChua] [datetime] NOT NULL,
	[MaKH] [int] NOT NULL,
	[TongTien] [int] NOT NULL
	PRIMARY KEY CLUSTERED
	(
		[MaPhieuSuaChua] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[CT_PHIEUSUACHUA]		Scripyt Date: 5/31/2023 34:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUSUACHUA]
(
	[MaPhieuSuaChua] [int],
	[MaTC] [int] NOT NULL,
	[MaPhuTung] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	CONSTRAINT [PK_CTPSC] PRIMARY KEY CLUSTERED
	(
		[MaPhieuSuaChua] ASC,
		[MaTC] ASC,
		[MaPhuTung] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[PHIEUTHUTIEN]		Scripyt Date: 5/31/2023 34:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHUTIEN]
(
	[MaPhieuThuTien] [int] IDENTITY(1,1),
	[MaKH] [int] NOT NULL,
	[TienThu] [int] NOT NULL,
	[NgayThuTien] [datetime] NOT NULL,
	PRIMARY KEY CLUSTERED
	(
		[MaPhieuThuTien] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[PHIEUTHUTIEN_2]		Scripyt Date: 5/31/2023 34:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHUTIEN_2]
(
	[MaPhieuThuTien] [int] IDENTITY(1,1),
	[MaKH] [int] NOT NULL,
	[TienThu] [int] NOT NULL,
	[NgayThuTien] [datetime] NOT NULL,
	PRIMARY KEY CLUSTERED
	(
		[MaPhieuThuTien] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[PHIEUNHAPVTPT]		Scripyt Date: 5/31/2023 34:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAPVTPT]
(
	[MaPNVTPT] [int] IDENTITY(1,1),
	[MaPhuTung] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThoiDiem] [datetime] NOT NULL,
	PRIMARY KEY CLUSTERED
	(
		[MaPNVTPT] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[BAOCAOTON]		Scripyt Date: 5/31/2023 34:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAOTON]
(
	[MaBCT] [int] IDENTITY(1,1),
	[ThoiDiemBaoCao] [datetime] NOT NULL,
	PRIMARY KEY CLUSTERED
	(
		[MaBCT] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[CT_BAOCAOTON]		Scripyt Date: 5/31/2023 34:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_BAOCAOTON]
(
	[MaBCT] [int],
	[MaPhuTung] [int] NOT NULL,
	[TonDau] [int] NOT NULL,
	[TonCuoi] [int] NOT NULL,
	[PhatSinh] [int] NOT NULL,
	CONSTRAINT [PK_CTBCT] PRIMARY KEY CLUSTERED
	(
		[MaBCT] ASC,
		[MaPhuTung] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[BAOCAOTON45]		Scripyt Date: 5/31/2023 34:4:4 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAOTON45]
(
	[MaBCT45] [int] IDENTITY(1,1) ,
	[Thang] [int],
	[Nam] [int],
	[TenVatTuPhuTung] [nvarchar](50) NOT NULL,
	[TonDau] [int] NOT NULL,
	[PhatSinh] [int] NOT NULL,
	[TonCuoi] [int] NOT NULL,
	PRIMARY KEY  CLUSTERED
	(
		[MaBCT45] ASC
	)
	WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]	
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[XE] WITH CHECK ADD FOREIGN KEY ([MaKH]) REFERENCES [dbo].[KHACHHANG]([MaKH])
GO
ALTER TABLE [dbo].[PHIEUSUACHUA] WITH CHECK ADD FOREIGN KEY ([BienSo])  REFERENCES [dbo].[XE](BienSo)
GO
ALTER TABLE [dbo].[PHIEUSUACHUA] WITH CHECK ADD FOREIGN KEY ([MaKH])  REFERENCES [dbo].[KHACHHANG](MaKH)
GO
ALTER TABLE [dbo].[CT_PHIEUSUACHUA] WITH CHECK ADD FOREIGN KEY ([MaPhieuSuaChua]) REFERENCES [dbo].[PHIEUSUACHUA]([MaPhieuSuaChua])
GO
ALTER TABLE [dbo].[CT_PHIEUSUACHUA] WITH CHECK ADD FOREIGN KEY ([MaPhuTung]) REFERENCES [dbo].[KHO]([MaPhuTung])
GO
ALTER TABLE [dbo].[CT_PHIEUSUACHUA] WITH CHECK ADD FOREIGN KEY ([MaTC]) REFERENCES [dbo].[TIENCONG]([MaTC])
GO
ALTER TABLE [dbo].[PHIEUTHUTIEN] WITH CHECK ADD FOREIGN KEY ([MaKH]) REFERENCES [dbo].[KHACHHANG]([MaKH])
GO
ALTER TABLE [dbo].[PHIEUNHAPVTPT] WITH CHECK ADD FOREIGN KEY (MaPhuTung) REFERENCES [dbo].[KHO]([MaPhuTung])
GO
ALTER TABLE [dbo].[CT_BAOCAOTON] WITH CHECK ADD FOREIGN KEY ([MaBCT]) REFERENCES [dbo].[BAOCAOTON]([MaBCT])
GO
ALTER TABLE [dbo].[CT_BAOCAOTON] WITH CHECK ADD FOREIGN KEY ([MaPhuTung]) REFERENCES [dbo].[KHO]([MaPhuTung])
GO
ALTER TABLE [dbo].[TAIKHOAN] WITH CHECK ADD FOREIGN KEY ([MaNguoiDung]) REFERENCES [dbo].[NGUOIDUNG]([MaNguoiDung])
GO

SET DATEFORMAT dmy;

/****** EXEC usp_dangnhap @TenDangNhap = 'quanly01', @MatKhau = 'quanly01' ******/
/****** UC-1: Đăng nhập: USP_DangNhap ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[usp_dangnhap]
	@TenDangNhap varchar(20),
	@MatKhau varchar(20) 
AS
BEGIN
	SELECT *
	FROM TAIKHOAN
	WHERE TenDangNhap COLLATE SQL_Latin1_General_CP1_CS_AS = @TenDangNhap 
	and MatKhau COLLATE SQL_Latin1_General_CP1_CS_AS = @MatKhau
	ORDER BY MaTK ASC
END
GO

/******  UC-3: PROCEDURE ThemKhachHang  ******/
/****** EXEC ThemKhachHang @TenKH = 'Trần Minh Duy', @DienThoai = '0985670111', @DiaChi = 'huyện Vũng Liêm', @TienNo = 0 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[ThemKhachHang]
	@TenKH nvarchar(50),
	@DienThoai varchar(50),
	@DiaChi nvarchar(100),
	@TienNo int
AS
BEGIN
	INSERT INTO [dbo].[KHACHHANG]([TenKH], [DienThoai], [DiaChi],[TienNo]) VALUES( @TenKH, @DienThoai, @DiaChi,  @TienNo)
END
GO

/******  PROCEDURE KiemTraBienSoDaTonTai   ******/
/******  EXEC KiemTraBienSoDaTonTai  @BienSo = '004004' ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[KiemTraBienSoDaTonTai ]
	@BienSo varchar(10)
AS
BEGIN
	SELECT *
	FROM XE
	WHERE BienSo = @BienSo
END
GO

/******  UC-3: PROCEDURE ThemXe  ******/
/******  EXEC ThemXe @BienSo = '004004', @HieuXe = 'Hyundai' ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[ThemXe]
	@BienSo varchar(10),
	@HieuXe varchar(50),
	@NgayTiepNhan datetime = NULL
AS
BEGIN
	DECLARE @MaKH int
	SELECT @MaKH = ISNULL(MAX(MAKH),1) FROM KHACHHANG
	INSERT INTO [dbo].[XE] ( [MaKH], [BienSo], [HieuXe], [NgayTiepNhan]) VALUES (@MaKH, @BienSo, @HieuXe, @NgayTiepNhan)
	INSERT INTO [dbo].[XE_2] ( [MaKH], [BienSo], [HieuXe], [NgayTiepNhan]) VALUES (@MaKH, @BienSo, @HieuXe, @NgayTiepNhan)
END
GO

/******  UC-3: PROCEDURE ThemXe_2  ******/
/******  EXEC ThemXe @BienSo = '004004', @HieuXe = 'Hyundai' ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[ThemXe_2]
	@MaKH int,
	@BienSo varchar(10),
	@HieuXe varchar(50),
	@NgayTiepNhan datetime = NULL
AS
BEGIN
	--DECLARE @MaKH int
	--SELECT @MaKH = ISNULL(MAX(MAKH),1) FROM KHACHHANG
	INSERT INTO [dbo].[XE_2] ( [MaKH], [BienSo], [HieuXe], [NgayTiepNhan]) VALUES (@MaKH, @BienSo, @HieuXe, @NgayTiepNhan)
END
GO

/****** UC-5: PROCEDURE XemDanhSachXe  ******/
/****** EXEC XemDanhSachXe  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[XemDanhSachXe]
AS
BEGIN
	SELECT ROW_NUMBER() OVER (ORDER BY x.BienSo) AS STT,
		   x.BienSo AS [Biển số],
		   x.HieuXe AS [Hiệu xe],
		   kh.TenKH AS [Chủ xe],
		   kh.TienNo AS [Tiền nợ]
	FROM XE x, KHACHHANG kh 
	WHERE x.MaKH = kh.MaKH
	ORDER BY x.NgayTiepNhan ASC
END
GO

/******   PROCEDURE TimKiemMotDoiSo  ******/
/****** EXEC TimKiemMotDoiSo @Dulieu = '004004'  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TimKiemMotDoiSo]
	@Dulieu varchar(10)
AS
BEGIN
	SELECT ROW_NUMBER() OVER (ORDER BY x.BienSo) AS STT,
		   x.BienSo AS [Biển số],
		   x.HieuXe AS [Hiệu xe],
		   kh.TenKH AS [Chủ xe],
		   kh.TienNo AS [Tiền nợ]
	FROM XE x, KHACHHANG kh 
	WHERE x.MaKH = kh.MaKH
	and ((x.BienSo like '%'+@Dulieu+'%') or (x.HieuXe like '%'+@Dulieu+'%')) 
END
GO

/******   PROCEDURE TimKiemHaiDoiSo  ******/
/****** EXEC TimKiemHaiDoiSo @BienSo = '001001', @HieuXe = 'dai'  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TimKiemHaiDoiSo]
	@BienSo varchar(10),
	@HieuXe varchar(50)
AS
BEGIN
	SELECT ROW_NUMBER() OVER (ORDER BY x.BienSo) AS STT,
		   x.BienSo AS [Biển số],
		   x.HieuXe AS [Hiệu xe],
		   kh.TenKH AS [Chủ xe],
		   kh.TienNo AS [Tiền nợ]
	FROM XE x, KHACHHANG kh 
	WHERE x.MaKH = kh.MaKH
	and x.BienSo like '%'+@BienSo+'%' 
	and x.HieuXe like '%'+@HieuXe+'%' 
END
GO

/******   PROCEDURE LayDuLieuQuyDinh  ******/
/****** EXEC LayDuLieuQuyDinh  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayDuLieuQuyDinh]
AS
BEGIN
	SELECT MaThamSo AS STT,
		   TenThamSo AS [Nội dung],
		   GiaTri AS [Giá trị]
	FROM THAMSO
	ORDER BY MaThamSo ASC
END
GO

/****** UC-12  PROCEDURE ThayDoiQuyDinh  ******/
/****** EXEC ThayDoiQuyDinh @MaThamSo = 1, @GiaTriMoi = 10  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThayDoiQuyDinh]
	@MaThamSo int,
	@GiaTriMoi int
AS
BEGIN
	UPDATE THAMSO
	SET GiaTri = @GiaTriMoi
	WHERE MaThamSo = @MaThamSo
END
GO


/****** Procedure BaoCaoDoanhThu ******/
/****** EXEC BaoCaoDoanhThu @Thang = 6, @Nam = 2023 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[BaoCaoDoanhThu]
	@Thang int,
	@Nam int 
AS
BEGIN
	SELECT ROW_NUMBER() OVER (ORDER BY x.HieuXe) AS STT,
			x.HieuXe AS [Hiệu xe],
			COUNT(psc.MaPhieuSuaChua) AS [Số lượt],
			SUM(ptt.TienThu) AS [Thành tiền],
			ROUND(CAST(COUNT(psc.MaPhieuSuaChua) * 100.0 / NULLIF((
			SELECT COUNT(*)
			FROM PHIEUTHUTIEN_2 ptt, PHIEUSUACHUA_2 psc
			WHERE ptt.MaKH = psc.MaKH
				AND MONTH(ptt.NgayThuTien) = @Thang
				AND YEAR(ptt.NgayThuTien) = @Nam 
				AND MONTH(psc.NgaySuaChua) = @Thang
				AND YEAR(psc.NgaySuaChua) = @Nam), 0) AS decimal(5, 2)), 2) AS [Tỉ lệ %]
	FROM XE_2 x, PHIEUTHUTIEN_2 ptt, PHIEUSUACHUA_2 psc
	WHERE x.MaKH = ptt.MaKH 
	and ptt.MaKH = psc.MaKH
	and MONTH(ptt.NgayThuTien) = @Thang
	and YEAR(ptt.NgayThuTien) = @Nam
	and MONTH(psc.NgaySuaChua) = @Thang
	and YEAR(psc.NgaySuaChua) = @Nam
	GROUP BY x.HieuXe
END
GO

/****** Procedure BaoCaoTonKho ******/
/****** EXEC BaoCaoTonKho @Thang = 6, @Nam = 2023 ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[BaoCaoTonKho]
	@Thang int,
	@Nam int
AS
BEGIN
	SELECT k.MaPhuTung AS STT,
		   k.TenVatTuPhuTung AS [Vật tư phụ tùng],
		   ctbct.TonDau AS [Tồn đầu],
		   ctbct.PhatSinh AS [Phát sinh],
		   ctbct.TonCuoi AS [Tồn cuối]
	FROM KHO k, CT_BAOCAOTON ctbct, BAOCAOTON bct
	WHERE k.MaPhuTung = ctbct.MaPhuTung
	and ctbct.MaBCT = bct.MaBCT
	and MONTH(bct.ThoiDiemBaoCao) = @Thang
	and YEAR(bct.ThoiDiemBaoCao) = @Nam
END
GO

/****** Procedure TongTienDoanhThu ******/
/****** EXEC TongTienDoanhThu @Thang = 6, @Nam = 2023 ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[TongTienDoanhThu]
	@Thang int,
	@Nam int
AS
BEGIN
	SELECT SUM(TienThu)
	FROM PHIEUTHUTIEN_2
	WHERE MONTH(NgayThuTien) = @Thang
	AND YEAR(NgayThuTien) = @Nam
END
GO

/****** Procedure LayToanBoThongTinTaiKhoan ******/
/****** EXEC LayToanBoThongTinTaiKhoan @TenDangNhap = 'quanly01', @MatKhau = 'quanly01' ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayToanBoThongTinTaiKhoan]
	@TenDangNhap varchar(20),
	@MatKhau varchar(20)
AS
BEGIN
	SELECT nd.TenND, CONVERT(DATE, nd.NgaySinh) AS [NgaySinh],
		CASE 
			WHEN nd.GioiTinh = 0 THEN 'Nam'
			WHEN nd.GioiTinh = 1 THEN N'Nữ'
		END AS GioiTinh,
		nd.DienThoai, nd.DiaChi, tk.TenDangNhap, tk.MatKhau, 
		CASE
			WHEN tk.QuyenHan = 1 THEN N'Quản lý'
			WHEN tk.QuyenHan = 0 THEN N'Nhân Viên'
		END AS QuyenHan
	FROM TAIKHOAN tk, NGUOIDUNG nd
	WHERE tk.MaNguoiDung = nd.MaNguoiDung
		AND tk.TenDangNhap = @TenDangNhap
		AND tk.MatKhau = @MatKhau
END
GO



/****** Procedure CapNhatMatKhau ******/
/****** EXEC CapNhatMatKhau @TenDangNhap = 'quanly01', @MatKhau = 'quanly01', @MatKhauMoi = 'quanly03' ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CapNhatMatKhau]
	@TenDangNhap varchar(20),
	@MatKhau varchar(20),
	@MatKhauMoi varchar(20)
AS
BEGIN
	UPDATE TAIKHOAN
	SET MatKhau = @MatKhauMoi
	WHERE TenDangNhap = @TenDangNhap and MatKhau = @MatKhau
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemNguoiDung]
	@TenND nvarchar(50),
	@NgaySinh nvarchar(10),
	@GioiTinh int = NULL,
	@DienThoai varchar(20),
	@DiaChi nvarchar(100)
AS
BEGIN
	-- Chuyển đổi format ngày sinh
	--DECLARE @NgaySinhDate date
	--SET @NgaySinhDate = CONVERT(date, @NgaySinh, 103) -- 103: dd/mm/yyyy

	-- Thực hiện INSERT
	INSERT INTO NGUOIDUNG ([TenND], [NgaySinh], [GioiTinh], [DienThoai], [DiaChi])
	VALUES (@TenND, @NgaySinh, @GioiTinh, @DienThoai, @DiaChi)
END
GO

--EXEC [dbo].[KiemTraNguoiDungDaTonTai] @TenND =  N'Nguyễn Quan Thịnh', @GioiTinh = 0, @DiaChi = N'23 Hai Bà Trưng',@NgaySinh = N'04/04/2000', @DienThoai = N'0987887709'
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KiemTraNguoiDungDaTonTai]
	@TenND nvarchar(50),
	@NgaySinh nvarchar(10),
	@GioiTinh int = NULL,
	@DienThoai varchar(20),
	@DiaChi nvarchar(100)
AS
BEGIN
	SELECT *
	FROM NGUOIDUNG
	WHERE TenND = @TenND
	and NgaySinh = @NgaySinh
	and GioiTinh = @GioiTinh
	and DienThoai = @DienThoai
	and DiaChi = @DiaChi
END
GO

/****** Procedure ThemTaiKhoan ******/
/****** EXEC ThemTaiKhoan @user = 'nhanvien03', @pass = 'nhanvien03', @QuyenHan = 0 ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemTaiKhoan]
	@user varchar(20),
	@pass varchar(20),
	@QuyenHan int
AS
BEGIN
	DECLARE @MaNguoiDung int
	SELECT @MaNguoiDung = ISNULL(MAX(MaNguoiDung),1) FROM NGUOIDUNG
	INSERT INTO TAIKHOAN([MaNguoiDung], [TenDangNhap],[MatKhau],[QuyenHan]) VALUES(@MaNguoiDung, @user,@pass, @QuyenHan)
END
GO

/****** Procedure LayMatKhau ******/
/****** EXEC LayMatKhau @user = 'nhanvien01' ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayMatKhau]
	@user varchar(20)
AS
BEGIN
	SELECT MatKhau
	FROM TAIKHOAN
	WHERE TenDangNhap = @user
END
GO

/****** Procedure KiemTraTenDNTonTai ******/
/****** EXEC KiemTraTenDNTonTai @TenDangNhap = 'quanly01' ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[KiemTraTenDNTonTai]
	@TenDangNhap varchar(20)
AS
BEGIN
	SELECT *
	FROM TAIKHOAN
	WHERE TenDangNhap = @TenDangNhap
END
GO

/****** Procedure BaoCaoTonKho45 ******/
/****** EXEC BaoCaoTonKho45 @Thang = 4, @Nam = 2023 ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[BaoCaoTonKho45]
	@Thang int,
	@Nam int
AS
BEGIN
	SELECT ROW_NUMBER() OVER (ORDER BY MaBCT45) AS STT,
		TenVatTuPhuTung AS [Tên vật tư phụ tùng],
		TonDau AS [Tồn đầu],
		PhatSinh AS [PhatSinh],
		TonCuoi AS [Tồn cuối]
	FROM BAOCAOTON45
	WHERE Thang = @Thang and Nam = @Nam
END
GO

/****** Procedure InsertBaoCaoTon45 ******/
/****** EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Bánh xe', @TonDau = 100, @PhatSinh = 60, @TonCuoi = 20 ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[InsertBaoCaoTonKho45]
	@Thang int,
	@Nam int,
	@TenVatTuPhuTung nvarchar(50),
	@TonDau int,
	@PhatSinh int,
	@TonCuoi int	
AS
BEGIN
	INSERT INTO [dbo].[BAOCAOTON45] VALUES (@Thang,@Nam, @TenVatTuPhuTung, @TonDau, @PhatSinh, @TonCuoi)
END
GO

/****** Procedure ThemPhieuNhapVatTu ******/
/****** EXEC ThemPhieuNhapVatTu @TenVatTuPhuTung = N'Bánh xe', @SoLuong = 100, @NgayNhapVT = '02-04-2023'  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[ThemPhieuNhapVatTu]
	@TenVatTuPhuTung nvarchar(50),
	@SoLuong int,
	@NgayNhapVT datetime	
AS
BEGIN
	DECLARE @MaPhuTung int

	SELECT @MaPhuTung = MaPhuTung
	FROM KHO
	WHERE TenVatTuPhuTung = @TenVatTuPhuTung

	UPDATE KHO
	SET SoLuong += @SoLuong
	WHERE TenVatTuPhuTung = @TenVatTuPhuTung

	INSERT INTO PHIEUNHAPVTPT([MaPhuTung], [SoLuong],[ThoiDiem]) VALUES (@MaPhuTung, @SoLuong, @NgayNhapVT)
END
GO

/****** Procedure LayThongTinKhachHang ******/
/****** EXEC LayThongTinKhachHang @BienSo = '001001' ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[LayThongTinKhachHang]
	@BienSo varchar(10)
AS
BEGIN
	SELECT kh.TenKH, kh.DienThoai, kh.DiaChi
	FROM KHACHHANG kh, XE x, PHIEUSUACHUA psc
	WHERE kh.MaKH = x.MaKH
	and psc.MaKH = kh.MaKH
	and x.BienSo = @BienSo
END
GO

/****** Procedure ThemPhieuThuTien ******/
/****** EXEC ThemPhieuThuTien @BienSo = '001001', @SoTien = 100000, @NgayThu= '02/06/2023 09:00:00' ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[ThemPhieuThuTien]
	@BienSo varchar(10),
	@SoTien int,
	@NgayThu datetime
AS
BEGIN
	DECLARE @MaKH int

	SELECT @MaKH = kh.MaKH
	FROM XE x, KHACHHANG kh
	WHERE x.MaKH = kh.MaKH
	and x.BienSo = @BienSo

	INSERT INTO PHIEUTHUTIEN([MaKH], [TienThu], [NgayThuTien]) VALUES (@MaKH, @SoTien, @NgayThu)
	INSERT INTO PHIEUTHUTIEN_2([MaKH], [TienThu], [NgayThuTien]) VALUES (@MaKH, @SoTien, @NgayThu)
	
	UPDATE KHACHHANG
	SET TienNo -= @SoTien
	WHERE MaKH = @MaKH

		IF (SELECT TienNo FROM KHACHHANG WHERE MaKH = @MaKH) = 0
	BEGIN
		DELETE FROM PHIEUSUACHUA
		WHERE MaKH = @MaKH

		DELETE FROM PHIEUTHUTIEN
		WHERE MaKH = @MaKH

		DELETE FROM XE
		WHERE MaKH = @MaKH

		DELETE FROM KHACHHANG
		WHERE MaKH = @MaKH

	END

END
GO

/****** Procedure TinhTienVatTu ******/
/****** EXEC TinhTienVatTu @TenVatTuPhuTung = N'Bánh xe', @SoLuong = 2 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TinhTienVatTu]
	@TenVatTuPhuTung nvarchar(50),
	@SoLuong int
AS
BEGIN
	SELECT @SoLuong * DonGia
	FROM KHO
	WHERE @TenVatTuPhuTung = TenVatTuPhuTung
END
GO

/****** Procedure LaySoLoaiVatTuHienTai ******/
/****** EXEC LaySoLoaiVatTuHienTai ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LaySoLoaiVatTuHienTai]
AS
BEGIN
	SELECT COUNT(DISTINCT MaPhuTung)
	FROM KHO
END
GO

/****** Procedure LaySoLoaiTienCongHienTai ****** /
/ ******EXEC LaySoLoaiTienCongHienTai ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LaySoLoaiTienCongHienTai]
AS
BEGIN
	SELECT COUNT(DISTINCT MaTC) 
	FROM TIENCONG
END
GO

/****** Procedure LayDonGiaAndSoLuongVatTu ****** /
/ ******EXEC LayDonGiaAndSoLuongVatTu @TenVatTu = N'Lọc dầu' ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayDonGiaAndSoLuongVatTu]
	@TenVatTu nvarchar(50)
AS
BEGIN
	SELECT DonGia, SoLuong  
	FROM KHO
	WHERE TenVatTuPhuTung = @TenVatTu
END
GO

/****** Procedure LayTienCong ****** /
/ ******EXEC LayTienCong @TenTienCong = N'Thay nhớt' ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LayTienCong]
	@TenTienCong nvarchar(50)
AS
BEGIN
	SELECT ChiPhi 
	FROM TIENCONG
	WHERE TenTienCong = @TenTienCong
END
GO


/****** Procedure ThemPhieuSuaChua ****** /
/ ******EXEC ThemPhieuSuaChua @BienSo = '001001', @NgaySuaChua = '01-06-2023', @TongTien = 200000 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemPhieuSuaChua]
	@BienSo varchar(10),
	@NgaySuaChua datetime,
	@TongTien int
AS
BEGIN
	DECLARE @MaKH int

	SELECT @MaKH = MaKH
	FROM XE
	WHERE BienSo = @BienSo

	INSERT INTO [dbo].[PHIEUSUACHUA]([BienSo],[NgaySuaChua],[MaKH],[TongTien]) VALUES (@BienSo, @NgaySuaChua, @MaKH, @TongTien)
	INSERT INTO [dbo].[PHIEUSUACHUA_2]([BienSo],[NgaySuaChua],[MaKH],[TongTien]) VALUES (@BienSo, @NgaySuaChua, @MaKH, @TongTien)

	UPDATE KHACHHANG
	SET TienNo += @TongTien
	WHERE MaKH = @MaKH
END



/****** Procedure ThemCT_PhieuSuaChua ****** /
/ ******EXEC ThemCT_PhieuSuaChua @TenVatTu = N'Bánh xe', @TenTienCong = N'Thay nhớt', @SoLuong = 2 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemCT_PhieuSuaChua]
	@TenVatTu nvarchar(50),
	@TenTienCong nvarchar(50),
	@SoLuong int
AS
BEGIN
	DECLARE @MaPhieuSuaChua int, @MaTC int, @MaPhuTung int
	SELECT @MaPhieuSuaChua = ISNULL(MAX(MaPhieuSuaChua),1) FROM PHIEUSUACHUA

	SELECT @MaTC = MaTC FROM TIENCONG WHERE TenTienCong = @TenTienCong
	SELECT @MaPhuTung = MaPhuTung FROM KHO WHERE TenVatTuPhuTung = @TenVatTu

	INSERT INTO [dbo].[CT_PHIEUSUACHUA]([MaPhieuSuaChua],[MaTC],[MaPhuTung], [SoLuong]) VALUES (@MaPhieuSuaChua, @MaTC, @MaPhuTung, @SoLuong)

	UPDATE KHO
	SET SoLuong -= @SoLuong
	WHERE TenVatTuPhuTung = @TenVatTu
END
GO

/****** Procedure KiemTraXeDaDuocTiepNhan ******/
/****** EXEC KiemTraXeDaDuocTiepNhan @BienSo = '001001' ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[KiemTraXeDaDuocTiepNhan]
	@BienSo varchar(10)
AS
BEGIN
	SELECT *
	FROM XE x
	WHERE x.BienSo = @BienSo
END
GO

/****** Procedure LayBienSoDaTiepNhan ******/
/****** EXEC LayBienSoDaTiepNhan******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[LayBienSoDaTiepNhan]
AS
BEGIN
	SELECT BienSo
	FROM XE 
	ORDER BY BienSo ASC
END
GO

/****** Procedure LayBienSoDaLapPhieuSuaChua ******/
/****** EXEC LayBienSoDaLapPhieuSuaChua ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[LayBienSoDaLapPhieuSuaChua]
AS
BEGIN
	SELECT DISTINCT psc.BienSo
	FROM PHIEUSUACHUA psc, KHACHHANG kh
	WHERE psc.MaKH = kh.MaKH
	and kh.TienNo > 0
	ORDER BY psc.BienSo ASC
END
GO

/****** Procedure LaySoLuongVatTuHienTai ******/
/****** EXEC LaySoLuongVatTuHienTai ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[LaySoLuongVatTuHienTai]
AS
BEGIN 
	SELECT ROW_NUMBER() OVER (ORDER BY MaPhuTung) AS STT, TenVatTuPhuTung AS [Tên Vật Tư Phụ Tùng], SoLuong AS [Số lượng]
	FROM KHO
END
GO


--INSERT [dbo].[NGUOIDUNG]([TenND], [GioiTinh], [DiaChi], [NgaySinh], [DienThoai]) VALUES ( N'Nguyễn Quan Thịnh',0, N'23 Hai Bà Trưng', N'04/04/2000', N'0987887709')
EXEC [dbo].[ThemNguoiDung] @TenND =  N'Nguyễn Quan Thịnh', @GioiTinh = 0, @DiaChi = N'23 Hai Bà Trưng',@NgaySinh = N'04/04/2000', @DienThoai = N'0987887709'
INSERT [dbo].[TAIKHOAN]([MaNguoiDung], [TenDangNhap], [MatKhau], [QuyenHan]) VALUES ( 1, N'quanly01', N'quanly01', 1)

--INSERT [dbo].[NGUOIDUNG]([TenND], [GioiTinh], [DiaChi], [NgaySinh], [DienThoai]) VALUES ( N'Mai Anh Tuấn',0, N' 25 Tân Lập', N'07/05/2000', N'0985687609')
EXEC [dbo].[ThemNguoiDung] @TenND =  N'Mai Anh Tuấn', @GioiTinh = 0, @DiaChi = N' 25 Tân Lập',@NgaySinh = N'07/05/2000', @DienThoai = N'0985687609'
INSERT [dbo].[TAIKHOAN]([MaNguoiDung], [TenDangNhap], [MatKhau], [QuyenHan]) VALUES ( 2, N'quanly02', N'quanly02', 1)

--INSERT [dbo].[NGUOIDUNG]([TenND], [GioiTinh], [DiaChi], [NgaySinh], [DienThoai]) VALUES ( N'Nguyễn Ngọc Linh',1, N'53A đường Mậu Thân', N'04/09/2000', N'0985346522')
EXEC [dbo].[ThemNguoiDung] @TenND =  N'Nguyễn Ngọc Linh', @GioiTinh = 1, @DiaChi = N'53A đường Mậu Thân',@NgaySinh = N'04/09/2000', @DienThoai = N'0985346522'
INSERT [dbo].[TAIKHOAN]([MaNguoiDung], [TenDangNhap], [MatKhau], [QuyenHan]) VALUES ( 3, N'nhanvien01', N'nhanvien01', 0)

--INSERT [dbo].[NGUOIDUNG]([TenND], [GioiTinh], [DiaChi], [NgaySinh], [DienThoai]) VALUES ( N'Trần Mỹ Dung',1, N'9A Nguyễn Văn Trỗi', N'12/11/2000', N'0788390091')
EXEC [dbo].[ThemNguoiDung] @TenND =  N'Trần Mỹ Dung', @GioiTinh = 1, @DiaChi = N'9A Nguyễn Văn Trỗi',@NgaySinh = N'12/11/2000', @DienThoai = N'0788390091'
INSERT [dbo].[TAIKHOAN]([MaNguoiDung], [TenDangNhap], [MatKhau], [QuyenHan]) VALUES ( 4, N'nhanvien02', N'nhanvien02', 0)

--- Khách hàng tháng 6 năm 2023
EXEC ThemKhachHang @TenKH = N'Nguyễn Tùng Dương', @DienThoai = '0783771000', @DiaChi = N'15/3 A đường Phước Hậu, xã Phước Hồng',  @TienNo = 0 
EXEC ThemXe @BienSo = '001001', @HieuXe = 'Toyota'

EXEC ThemKhachHang @TenKH = N'Đặng Khôi Nguyên', @DienThoai = '0666987601', @DiaChi = N'23/4 B đường Long Mỹ, xã Mậu Hồng', @TienNo = 0
EXEC ThemXe @BienSo = '002002', @HieuXe = 'Kia'

EXEC ThemKhachHang @TenKH = N'Nguyễn Thị Mỹ Duyên', @DienThoai = '0888987601', @DiaChi = N'33/5 A đường Hòa Phát, xã Hồng Châu',  @TienNo = 0 
EXEC ThemXe @BienSo = '003003', @HieuXe = 'Suzuki'

--- Khách hàng tháng 5 năm 2023
--EXEC ThemKhachHang @TenKH = N'Trần Văn Minh', @DienThoai = '0783099800', @DiaChi = N'23/3 A đường Thanh Long',  @TienNo = 0 
--EXEC ThemXe @BienSo = '004004', @HieuXe = 'Suzuki'
EXEC ThemXe_2 @MaKH = 4, @BienSo = '004004', @HieuXe = 'Suzuki'

--EXEC ThemKhachHang @TenKH = N'Nguyễn My', @DienThoai = '0969453786', @DiaChi = N'13/4 B đường Nguyễn Trãi', @TienNo = 0
--EXEC ThemXe @BienSo = '005005', @HieuXe = 'Kia'
EXEC ThemXe_2 @MaKH = 5, @BienSo = '005005', @HieuXe = 'Kia'
--EXEC ThemKhachHang @TenKH = N'Lâm Văn Tài', @DienThoai = '0888227609', @DiaChi = N'133A đường Long Chu', @TienNo = 0 
--EXEC ThemXe @BienSo = '006006', @HieuXe = 'Suzuki'
EXEC ThemXe_2 @MaKH = 6, @BienSo = '006006', @HieuXe = 'Suzuki'
--- Khách hàng tháng 4 năm 2023
--EXEC ThemKhachHang @TenKH = N'Nguyễn Văn Vũ', @DienThoai = '07830435098', @DiaChi = N'3A đường Nguyễn Bỉnh Khiêm', @TienNo = 0 
--EXEC ThemXe @BienSo = '007007', @HieuXe = 'Suzuki'
EXEC ThemXe_2 @MaKH = 7, @BienSo = '007007', @HieuXe = 'Suzuki'
--EXEC ThemKhachHang @TenKH = N'Lê Ngọc Minh', @DienThoai = '0769459823', @DiaChi = N'4B đường Lê Hồng Phong', @TienNo = 0
--EXEC ThemXe @BienSo = '008008', @HieuXe = 'Kia'
EXEC ThemXe_2 @MaKH = 8, @BienSo = '008008', @HieuXe = 'Kia'
--EXEC ThemKhachHang @TenKH = N'Hứa Hoàng Linh', @DienThoai = '0834723109', @DiaChi = N'123A đường Hưng Long', @TienNo = 0 
--EXEC ThemXe @BienSo = '009009', @HieuXe = 'Kia'
EXEC ThemXe_2 @MaKH = 9, @BienSo = '009009', @HieuXe = 'Kia'
--- Khách hàng tháng 4 năm 2023
--EXEC ThemKhachHang @TenKH = N'Nguyễn Tấn Phong', @DienThoai = '0789343400', @DiaChi = N'63A đường Hồng Linh',  @TienNo = 0 
--EXEC ThemXe @BienSo = '010010', @HieuXe = 'Honda'
EXEC ThemXe_2 @MaKH = 10, @BienSo = '010010', @HieuXe = 'Honda'
--EXEC ThemKhachHang @TenKH = N'Đặng Đức Hoàng', @DienThoai = '0830998601', @DiaChi = N'9C đường Thành Long', @TienNo = 0
--EXEC ThemXe @BienSo = '011011', @HieuXe = 'Lexus'
EXEC ThemXe_2 @MaKH = 11, @BienSo = '011011', @HieuXe = 'Lexus'
--EXEC ThemKhachHang @TenKH = N'Nguyễn Văn Tân', @DienThoai = '0983409901', @DiaChi = N'16/5 B đường Châu Văn Liêm',  @TienNo = 0 
--EXEC ThemXe @BienSo = '012012', @HieuXe = 'Porsche'
EXEC ThemXe_2 @MaKH = 12, @BienSo = '012012', @HieuXe = 'Porsche'
--EXEC ThemKhachHang @TenKH = N'Trần Cúc', @DienThoai = '0990776534', @DiaChi = N'57A đường Văn Minh',  @TienNo = 0 
--EXEC ThemXe @BienSo = '013013', @HieuXe = 'Ford'
EXEC ThemXe_2 @MaKH = 13, @BienSo = '013013', @HieuXe = 'Ford'
--- Khách hàng tháng 5 năm 2023
--EXEC ThemKhachHang @TenKH = N'Nguyễn Mỹ Linh', @DienThoai = '0824123786', @DiaChi = N'56A đường Nguyễn Văn Thiệt', @TienNo = 0
--EXEC ThemXe @BienSo = '014014', @HieuXe = 'Chevrolet'
EXEC ThemXe_2 @MaKH = 14, @BienSo = '014014', @HieuXe = 'Chevrolet'
--EXEC ThemKhachHang @TenKH = N'Trần Minh Tú', @DienThoai = '0945647609', @DiaChi = N'133A đường Võ Văn Ngân', @TienNo = 0 
--EXEC ThemXe @BienSo = '015015', @HieuXe = 'Honda'
EXEC ThemXe_2 @MaKH = 15, @BienSo = '015015', @HieuXe = 'Honda'
--EXEC ThemKhachHang @TenKH = N'Lê Vũ', @DienThoai = '0787398898', @DiaChi = N'3A đường Nguyễn Thị Minh Khai', @TienNo = 0 
--EXEC ThemXe @BienSo = '016016', @HieuXe = 'Audi'
EXEC ThemXe_2 @MaKH = 16, @BienSo = '016016', @HieuXe = 'Audi'
--EXEC ThemKhachHang @TenKH = N'Lê Minh Thy', @DienThoai = '0995666823', @DiaChi = N'74B đường Võ Tấn Phát', @TienNo = 0
--EXEC ThemXe @BienSo = '017017', @HieuXe = 'BMW'
EXEC ThemXe_2 @MaKH = 17, @BienSo = '017017', @HieuXe = 'BMW'
--EXEC ThemKhachHang @TenKH = N'Võ Linh Chi', @DienThoai = '0998723109', @DiaChi = N'15A đường Mộc Hóa', @TienNo = 0 
--EXEC ThemXe @BienSo = '018018', @HieuXe = 'BMW'
EXEC ThemXe_2 @MaKH = 18, @BienSo = '018018', @HieuXe = 'BMW'

INSERT [dbo].[THAMSO]([TenThamSo], [GiaTri]) VALUES ( N'Số lượng hiệu xe', 8)
INSERT [dbo].[THAMSO]([TenThamSo], [GiaTri]) VALUES ( N'Số xe sửa chữa tối đa trong ngày', 30)
INSERT [dbo].[THAMSO]([TenThamSo], [GiaTri]) VALUES ( N'Số lượng loại phụ tùng', 28)
INSERT [dbo].[THAMSO]([TenThamSo], [GiaTri]) VALUES ( N'Số lượng loại tiền công', 70)

SET DATEFORMAT dmy;


--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'001001', '01-04-2023', 1,  200000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'002002', '02-04-2023', 2,  200000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'003003', '02-04-2023', 3,  400000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'004004', '03-04-2023', 4,  600000) 
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'005005', '05-04-2023', 5,  900000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'006006', '06-04-2023', 6,  700000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'007007', '13-04-2023', 7, 1500000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'008008', '17-04-2023', 8,  850000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'009009', '19-04-2023', 9,  300000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'010010', '05-04-2023', 10,  900000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'011011', '06-04-2023', 11,  700000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'012012', '13-04-2023', 12, 2000000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'013013', '17-04-2023', 13,  850000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'014014', '19-04-2023', 14,  400000)

INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'001001', '01-04-2023', 1,  200000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'002002', '02-04-2023', 2,  200000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'003003', '02-04-2023', 3,  400000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'004004', '03-04-2023', 4,  600000) 
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'005005', '05-04-2023', 5,  900000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'006006', '06-04-2023', 6,  700000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'007007', '13-04-2023', 7, 1500000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'008008', '17-04-2023', 8,  850000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'009009', '19-04-2023', 9,  300000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'010010', '05-04-2023', 10,  900000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'011011', '06-04-2023', 11,  700000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'012012', '13-04-2023', 12, 2000000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'013013', '17-04-2023', 13,  850000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'014014', '19-04-2023', 14,  400000)

							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (1,  200000, '06/04/2023 09:00:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (2,  200000, '06/04/2023 14:30:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (3,  400000, '06/04/2023 18:15:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (4,  600000, '15/04/2023 09:00:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (5,  900000, '15/04/2023 14:30:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (6,  700000, '16/04/2023 18:15:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (7, 1500000, '17/04/2023 09:00:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (8,  850000, '19/04/2023 14:30:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (9,  300000, '25/04/2023 18:15:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (10,  900000, '15/04/2023 14:30:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (11,  700000, '16/04/2023 18:15:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (12, 2000000, '17/04/2023 09:00:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (13,  850000, '19/04/2023 14:30:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (14,  400000, '25/04/2023 18:15:00')




--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'001001', '01-05-2023', 1, 500000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'002002', '02-05-2023', 2, 700000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'003003', '02-05-2023', 3, 500000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'004004', '04-05-2023', 4, 800000) 
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'005005', '06-05-2023', 5, 250000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'006006', '09-05-2023', 6, 650000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'007007', '14-05-2023', 7, 950000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'008008', '17-05-2023', 8, 600000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'009009', '17-05-2023', 9, 550000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'010010', '17-05-2023', 10, 250000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'015015', '28-05-2023', 15, 650000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'016016', '19-05-2023', 16, 950000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'017017', '24-05-2023', 17, 600000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'018018', '25-05-2023', 18, 550000)

INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'001001', '01-05-2023', 1, 500000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'002002', '02-05-2023', 2, 700000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'003003', '02-05-2023', 3, 500000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'004004', '04-05-2023', 4, 800000) 
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'005005', '06-05-2023', 5, 250000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'006006', '09-05-2023', 6, 650000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'007007', '14-05-2023', 7, 950000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'008008', '17-05-2023', 8, 600000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'009009', '17-05-2023', 9, 550000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'010010', '17-05-2023', 10, 250000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'015015', '28-05-2023', 15, 650000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'016016', '19-05-2023', 16, 950000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'017017', '24-05-2023', 17, 600000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'018018', '25-05-2023', 18, 550000)

							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (1, 500000, '06/05/2023 09:00:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (2, 700000, '06/05/2023 14:30:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (3, 500000, '09/05/2023 18:15:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (4, 800000, '15/05/2023 09:00:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (5, 250000, '16/05/2023 14:30:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (6, 650000, '24/05/2023 18:15:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (7, 950000, '25/05/2023 09:00:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (8, 600000, '25/05/2023 14:30:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (9, 550000, '25/05/2023 18:15:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (10, 250000, '26/05/2023 14:30:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (15, 650000, '26/05/2023 18:15:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (16, 950000, '25/05/2023 09:00:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (17, 600000, '28/05/2023 14:30:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (18, 550000, '29/05/2023 18:15:00')


--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'001001', '01-06-2023', 1, 1000000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'002002', '01-06-2023', 2,  350000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'003003', '02-06-2023', 3,  600000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'004004', '09-06-2023', 4,  700000) 
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'008008', '14-06-2023', 8,  900000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'009009', '16-06-2023', 9,  450000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'010010', '17-06-2023', 10, 900000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'013013', '17-06-2023', 13, 450000)
--INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'014014', '19-06-2023', 14, 500000)

INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'001001', '01-06-2023', 1, 1000000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'002002', '01-06-2023', 2,  350000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'003003', '02-06-2023', 3,  600000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'004004', '09-06-2023', 4,  700000) 
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'008008', '14-06-2023', 8,  900000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'009009', '16-06-2023', 9,  450000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'010010', '17-06-2023', 10, 900000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'013013', '17-06-2023', 13, 450000)
INSERT [dbo].[PHIEUSUACHUA_2]([BienSo], [NgaySuaChua], [MaKH],  [TongTien]) VALUES (N'014014', '19-06-2023', 14, 500000)

							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (1,  1000000, '06/06/2023 09:00:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (2,  350000, '06/06/2023 14:30:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (3,  600000, '06/06/2023 18:15:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (4,  700000, '15/06/2023 09:00:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (8,  900000, '19/06/2023 14:30:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (9,  450000, '20/06/2023 18:15:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (10,  900000, '20/06/2023 14:30:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (13,  450000, '21/06/2023 14:30:00')
							INSERT [dbo].[PHIEUTHUTIEN_2]([MaKH], [TienThu], [NgayThuTien]) VALUES (14,  500000, '21/06/2023 18:15:00')


INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Bánh xe', 100, 500000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Lọc dầu', 200, 100000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Lọc gió', 300, 80000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Ống xả', 150, 250000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Lọc nhiên liệu', 120, 60000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Bình dầu', 80, 200000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Giảm sóc', 250, 350000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Công tắc đèn', 200, 50000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Dây curoa', 180, 120000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Vành đúc', 120, 350000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Máy nổ', 10, 1500000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Ly hợp', 30, 800000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Bộ phanh', 50, 200000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Đèn pha', 80, 100000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Cụm điều khiển', 25, 150000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Ốp lưng ghế', 60, 50000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Cảm biến áp suất lốp', 15, 200000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Dây điện', 100, 30000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Máy phát điện', 5, 2000000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Ống nước', 90, 60000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Đèn hậu', 120, 80000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Gương chiếu hậu', 80, 100000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Cần gạt nước', 200, 30000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Đèn xi-nhan', 100, 40000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Đèn trần', 80, 60000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Vòi rửa xe', 50, 150000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Bơm xịt nước', 70, 120000)
INSERT [dbo].[KHO] ([TenVatTuPhuTung], [SoLuong], [DonGia]) VALUES (N'Phanh tay', 40, 180000)


-- @Thang = 4
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Bánh xe', @TonDau = 100, @PhatSinh = 60, @TonCuoi = 40
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Lọc dầu', @TonDau = 200, @PhatSinh = 100, @TonCuoi = 150
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Lọc gió', @TonDau = 300, @PhatSinh = 150, @TonCuoi = 250
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Ống xả', @TonDau = 150, @PhatSinh = 70, @TonCuoi = 100
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Lọc nhiên liệu', @TonDau = 120, @PhatSinh = 50, @TonCuoi = 100
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Bình dầu', @TonDau = 80, @PhatSinh = 30, @TonCuoi = 70
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Giảm sóc', @TonDau = 250, @PhatSinh = 100, @TonCuoi = 200
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Công tắc đèn', @TonDau = 200, @PhatSinh = 80, @TonCuoi = 180
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Dây curoa', @TonDau = 180, @PhatSinh = 70, @TonCuoi = 160
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Vành đúc', @TonDau = 120, @PhatSinh = 40, @TonCuoi = 100
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Máy nổ', @TonDau = 10, @PhatSinh = 5, @TonCuoi = 9
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Ly hợp', @TonDau = 30, @PhatSinh = 15, @TonCuoi = 25
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Bộ phanh', @TonDau = 50, @PhatSinh = 25, @TonCuoi = 40
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Đèn pha', @TonDau = 80, @PhatSinh = 30, @TonCuoi = 70
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Cụm điều khiển', @TonDau = 25, @PhatSinh = 10, @TonCuoi = 20
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Ốp lưng ghế', @TonDau = 60, @PhatSinh = 25, @TonCuoi = 50
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Cảm biến áp suất lốp', @TonDau = 15, @PhatSinh = 5, @TonCuoi = 12
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Dây điện', @TonDau = 100, @PhatSinh = 50, @TonCuoi = 95
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Máy phát điện', @TonDau = 5, @PhatSinh = 3, @TonCuoi = 4
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Ống nước', @TonDau = 90, @PhatSinh = 35, @TonCuoi = 80
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Đèn hậu', @TonDau = 120, @PhatSinh = 40, @TonCuoi = 110
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Gương chiếu hậu', @TonDau = 80, @PhatSinh = 30, @TonCuoi = 70
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Cần gạt nước', @TonDau = 200, @PhatSinh = 80, @TonCuoi = 180
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Đèn xi-nhan', @TonDau = 100, @PhatSinh = 40, @TonCuoi = 90
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Đèn trần', @TonDau = 80, @PhatSinh = 30, @TonCuoi = 70
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Vòi rửa xe', @TonDau = 50, @PhatSinh = 20, @TonCuoi = 40
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Bơm xịt nước', @TonDau = 70, @PhatSinh = 30, @TonCuoi = 60
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Phanh tay', @TonDau = 40, @PhatSinh = 15, @TonCuoi = 35

-- @Thang = 5
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Bánh xe', @TonDau = 40, @PhatSinh = 60, @TonCuoi = 100
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Lọc dầu', @TonDau = 150, @PhatSinh = 100, @TonCuoi = 250
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Lọc gió', @TonDau = 250, @PhatSinh = 150, @TonCuoi = 400
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Ống xả', @TonDau = 100, @PhatSinh = 70, @TonCuoi = 170
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Lọc nhiên liệu', @TonDau = 100, @PhatSinh = 50, @TonCuoi = 150
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Bình dầu', @TonDau = 70, @PhatSinh = 30, @TonCuoi = 100
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Giảm sóc', @TonDau = 200, @PhatSinh = 100, @TonCuoi = 300
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Công tắc đèn', @TonDau = 180, @PhatSinh = 80, @TonCuoi = 260
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Dây curoa', @TonDau = 160, @PhatSinh = 70, @TonCuoi = 230
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Vành đúc', @TonDau = 100, @PhatSinh = 40, @TonCuoi = 140
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Máy nổ', @TonDau = 9, @PhatSinh = 5, @TonCuoi = 14
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Ly hợp', @TonDau = 25, @PhatSinh = 15, @TonCuoi = 40
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Bộ phanh', @TonDau = 40, @PhatSinh = 25, @TonCuoi = 65
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Đèn pha', @TonDau = 70, @PhatSinh = 30, @TonCuoi = 100
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Cụm điều khiển', @TonDau = 20, @PhatSinh = 10, @TonCuoi = 30
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Ốp lưng ghế', @TonDau = 50, @PhatSinh = 25, @TonCuoi = 75
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Cảm biến áp suất lốp', @TonDau = 12, @PhatSinh = 5, @TonCuoi = 17
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Dây điện', @TonDau = 95, @PhatSinh = 50, @TonCuoi = 145
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Máy phát điện', @TonDau = 4, @PhatSinh = 3, @TonCuoi = 7
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Ống nước', @TonDau = 80, @PhatSinh = 35, @TonCuoi = 115
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Đèn hậu', @TonDau = 110, @PhatSinh = 40, @TonCuoi = 150
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Gương chiếu hậu', @TonDau = 70, @PhatSinh = 30, @TonCuoi = 100
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Cần gạt nước', @TonDau = 180, @PhatSinh = 80, @TonCuoi = 260
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Đèn xi-nhan', @TonDau = 90, @PhatSinh = 40, @TonCuoi = 130
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Đèn trần', @TonDau = 70, @PhatSinh = 30, @TonCuoi = 100
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Vòi rửa xe', @TonDau = 40, @PhatSinh = 20, @TonCuoi = 60
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Bơm xịt nước', @TonDau = 60, @PhatSinh = 30, @TonCuoi = 90
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Phanh tay', @TonDau = 35, @PhatSinh = 15, @TonCuoi = 50




--INSERT [dbo].[BAOCAOTON] ([ThoiDiemBaoCao]) VALUES ('01/06/2023 09:00:00')
INSERT [dbo].[BAOCAOTON] ([ThoiDiemBaoCao]) VALUES ('01/05/2023 09:00:00')
INSERT [dbo].[BAOCAOTON] ([ThoiDiemBaoCao]) VALUES ('01/04/2023 09:00:00')

INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,1,100,0,90)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,2,200,0,160)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,3,300,0,250)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,4,150,0,140)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,5,120,0,110)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,6,80,0,50)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,7,250,0,200)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,8,200,0,150)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,9,180,0,190)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,10,120,0,130)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,11,10,0,8)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,12,30,0,25)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,13,50,0,35)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,14,80,0,70)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,15,25,0,35)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,16,60,0,55)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,17,15,0,20)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,18,100,0,90)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,19,5,0,7)


INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,1,90,0,100)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,2,160,0,160)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,3,250,0,240)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,4,140,0,100)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,5,110,0,100)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,6,50,0,65)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,7,200,0,190)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,8,150,0,160)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,9,190,0,180)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,10,130,0,120)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,11,8,0,15)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,12,25,0,25)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,13,35,0,45)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,14,70,0,90)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,15,35,0,30)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,16,55,0,45)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,17,20,0,15)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,18,90,0,95)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,19,7,0,15)

--INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (3,1,100,0,100)
--INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (3,2,200,0,200)
--INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (3,3,300,0,300)

INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay bánh xe', 50000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay lọc dầu', 20000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay lọc gió', 15000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay ống xả', 30000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa động cơ', 100000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa hệ thống phanh', 80000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa hệ thống lái', 70000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa hệ thống điện', 50000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay lọc nhiên liệu', 10000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa hệ thống làm mát', 60000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay bình dầu', 40000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa hệ thống treo', 90000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay giảm sóc', 25000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa hệ thống điều khiển', 60000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay công tắc đèn', 10000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa hệ thống phun nhiên liệu', 70000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay dây curoa', 20000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa hệ thống điện tử', 80000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa vết trầy trên vành đúc', 50000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Kiểm tra lực căng của vành đúc', 20000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay van ở vành đúc', 40000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay vỏ xe', 30000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa hệ thống truyền động', 90000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay máy nổ', 50000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay ly hợp', 40000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay bộ phanh', 25000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay đèn pha', 10000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay cụm điều khiển', 20000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay ốp lưng ghế', 10000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay cảm biến áp suất lốp', 30000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay dây điện', 5000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay máy phát điện', 50000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay ống nước', 50000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa ống nước', 70000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay đèn hậu', 80000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa đèn hậu', 90000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay gương chiếu hậu', 100000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa gương chiếu hậu', 100000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay cần gạt nước', 30000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa cần gạt nước', 40000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay đèn xi-nhan', 40000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa đèn xi-nhan', 50000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay đèn trần', 60000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa đèn trần', 70000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay vòi rửa xe', 150000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa vòi rửa xe', 160000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay bơm xịt nước', 120000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa bơm xịt nước', 130000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay phanh tay', 180000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Sửa phanh tay', 190000)
-- Các TIENCONG khác liên quan đến các vật tư phụ tùng khác

INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Rửa xe', 50000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Vệ sinh nội thất', 40000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Kiểm tra định kỳ', 30000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Trợ giúp cứu hộ', 70000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Điều chỉnh cân bằng', 60000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Lắp đặt phụ kiện', 50000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Kiểm tra hệ thống', 80000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Chuẩn đoán lỗi', 90000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Nạp ga điều hòa', 40000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Phục hồi động cơ', 120000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Kiểm tra động cơ', 90000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Lắp đặt màn hình', 60000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay pin', 50000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Vệ sinh hệ thống làm mát', 70000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Tháo lắp đèn hậu', 30000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Lắp đặt camera hành trình', 80000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Kiểm tra hệ thống phanh', 60000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Điều chỉnh hệ thống lái', 70000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Thay dầu hộp số', 40000)
INSERT [dbo].[TIENCONG] ([TenTienCong], [ChiPhi]) VALUES (N'Vệ sinh hệ thống điều hòa', 50000)


USE [master]
GO
ALTER DATABASE [QuanLyGarage] SET  READ_WRITE 
GO