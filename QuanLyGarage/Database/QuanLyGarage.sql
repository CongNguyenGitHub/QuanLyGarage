﻿USE [master]
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
	[TienCong] [int]  NOT NULL,
	[TienPhuTung] [int] NOT NULL,
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

/****** EXEC [dbo].[USP_DangNhap] @TenDN = 'quanly01', @MatKhau = 'quanly01' ******/
/****** UC-1: Đăng nhập: USP_DangNhap ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE	PROCEDURE [dbo].[usp_dangnhap]
	@TenDangNhap nvarchar(20),
	@MatKhau varchar(20)
AS
BEGIN
	SELECT *
	FROM TAIKHOAN
	WHERE TenDangNhap = @TenDangNhap and MatKhau = @MatKhau
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
			(	COUNT(psc.MaPhieuSuaChua) * 100 / (Select COUNT (*)
												   FROM PHIEUTHUTIEN ptt, PHIEUSUACHUA psc
												   WHERE ptt.MaKH = psc.MaKH
												   and MONTH(ptt.NgayThuTien) = @Thang
												   and YEAR(ptt.NgayThuTien) = @Nam)
			) AS [Tỉ lệ %]
	FROM XE x, PHIEUTHUTIEN ptt, PHIEUSUACHUA psc
	WHERE x.MaKH = ptt.MaKH 
	and ptt.MaKH = psc.MaKH
	and MONTH(NgayThuTien) = @Thang
	and YEAR(NgayThuTien) = @Nam
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
	FROM PHIEUTHUTIEN
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
	SELECT nd.TenND, nd.NgaySinh, 
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


/****** Procedure ThemNguoiDung ******/
/****** EXEC ThemNguoiDung @TenND = 'Trần Văn Khánh', @GioiTinh = 0, @DiaChi = '45A đường Ngô Quyền', @NgaySinh = '04/04/2000', @DienThoai = '0989912344' ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemNguoiDung]
	@TenND nvarchar(50),
	@NgaySinh date,
	@GioiTinh int = NULL,
	@DienThoai varchar(20),
	@DiaChi nvarchar(100)
AS
BEGIN
	INSERT INTO NGUOIDUNG([TenND], [NgaySinh],[GioiTinh],[DienThoai], [DiaChi]) VALUES(@TenND, @NgaySinh,@GioiTinh, @DienThoai, @DiaChi)
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

	UPDATE KHACHHANG
	SET TienNo -= @SoTien
	WHERE MaKH = @MaKH
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

/****** Procedure LaySoLoaiVatTuHienTai /
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

/****** Procedure LaySoLoaiTienCongHienTai /
/ EXEC LaySoLoaiTienCongHienTai ******/
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

INSERT [dbo].[NGUOIDUNG]([TenND], [GioiTinh], [DiaChi], [NgaySinh], [DienThoai]) VALUES ( N'Nguyễn Quan Thịnh',0, N'23 Hai Bà Trưng', N'04/04/2000', N'0987887709')
INSERT [dbo].[TAIKHOAN]([MaNguoiDung], [TenDangNhap], [MatKhau], [QuyenHan]) VALUES ( 1, N'quanly01', N'quanly01', 1)

INSERT [dbo].[NGUOIDUNG]([TenND], [GioiTinh], [DiaChi], [NgaySinh], [DienThoai]) VALUES ( N'Mai Anh Tuấn',0, N' 25 Tân Lập', N'07/05/2000', N'0985687609')
INSERT [dbo].[TAIKHOAN]([MaNguoiDung], [TenDangNhap], [MatKhau], [QuyenHan]) VALUES ( 2, N'quanly02', N'quanly02', 1)

INSERT [dbo].[NGUOIDUNG]([TenND], [GioiTinh], [DiaChi], [NgaySinh], [DienThoai]) VALUES ( N'Nguyễn Ngọc Linh',1, N'53A đường Mậu Thân', N'04/09/2000', N'0985346522')
INSERT [dbo].[TAIKHOAN]([MaNguoiDung], [TenDangNhap], [MatKhau], [QuyenHan]) VALUES ( 3, N'nhanvien01', N'nhanvien01', 0)

INSERT [dbo].[NGUOIDUNG]([TenND], [GioiTinh], [DiaChi], [NgaySinh], [DienThoai]) VALUES ( N'Trần Mỹ Dung',1, N'9A Nguyễn Văn Trỗi', N'12/11/2000', N'0788390091')
INSERT [dbo].[TAIKHOAN]([MaNguoiDung], [TenDangNhap], [MatKhau], [QuyenHan]) VALUES ( 4, N'nhanvien02', N'nhanvien02', 0)

--- Khách hàng tháng 6 năm 2023
EXEC ThemKhachHang @TenKH = N'Nguyễn Tùng Dương', @DienThoai = '0783771000', @DiaChi = N'15/3 A đường Phước Hậu, xã Phước Hồng',  @TienNo = 0 
EXEC ThemXe @BienSo = '001001', @HieuXe = 'Toyota'

EXEC ThemKhachHang @TenKH = N'Đặng Khôi Nguyên', @DienThoai = '0666987601', @DiaChi = N'23/4 B đường Long Mỹ, xã Mậu Hồng', @TienNo = 0
EXEC ThemXe @BienSo = '002002', @HieuXe = 'Kia'

EXEC ThemKhachHang @TenKH = N'Nguyễn Thị Mỹ Duyên', @DienThoai = '0888987601', @DiaChi = N'33/5 A đường Hòa Phát, xã Hồng Châu',  @TienNo = 0 
EXEC ThemXe @BienSo = '003003', @HieuXe = 'Suzuki'

--- Khách hàng tháng 5 năm 2023
EXEC ThemKhachHang @TenKH = N'Trần Văn Minh', @DienThoai = '0783099800', @DiaChi = N'23/3 A đường Thanh Long',  @TienNo = 0 
EXEC ThemXe @BienSo = '004004', @HieuXe = 'Suzuki'

EXEC ThemKhachHang @TenKH = N'Nguyễn My', @DienThoai = '0969453786', @DiaChi = N'13/4 B đường Nguyễn Trãi', @TienNo = 0
EXEC ThemXe @BienSo = '005005', @HieuXe = 'Kia'

EXEC ThemKhachHang @TenKH = N'Lâm Văn Tài', @DienThoai = '0888227609', @DiaChi = N'133A đường Long Chu', @TienNo = 0 
EXEC ThemXe @BienSo = '006006', @HieuXe = 'Suzuki'

--- Khách hàng tháng 4 năm 2023
EXEC ThemKhachHang @TenKH = N'Nguyễn Văn Vũ', @DienThoai = '07830435098', @DiaChi = N'3A đường Nguyễn Bỉnh Khiêm', @TienNo = 0 
EXEC ThemXe @BienSo = '007007', @HieuXe = 'Suzuki'

EXEC ThemKhachHang @TenKH = N'Lê Ngọc Minh', @DienThoai = '0769459823', @DiaChi = N'4B đường Lê Hồng Phong', @TienNo = 0
EXEC ThemXe @BienSo = '008008', @HieuXe = 'Kia'

EXEC ThemKhachHang @TenKH = N'Hứa Hoàng Linh', @DienThoai = '0834723109', @DiaChi = N'123A đường Hưng Long', @TienNo = 0 
EXEC ThemXe @BienSo = '009009', @HieuXe = 'Kia'

INSERT [dbo].[THAMSO]([TenThamSo], [GiaTri]) VALUES ( N'Số lượng hiệu xe', 10)
INSERT [dbo].[THAMSO]([TenThamSo], [GiaTri]) VALUES ( N'Số xe sửa chữa tối đa trong ngày', 30)
INSERT [dbo].[THAMSO]([TenThamSo], [GiaTri]) VALUES ( N'Số lượng loại phụ tùng', 200)
INSERT [dbo].[THAMSO]([TenThamSo], [GiaTri]) VALUES ( N'Số lượng loại tiền công', 100)

SET DATEFORMAT dmy;

INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH], [TienCong], [TienPhuTung], [TongTien]) VALUES (N'001001', '01-04-2023', 1, 0, 0, 0)
INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH], [TienCong], [TienPhuTung], [TongTien]) VALUES (N'002002', '02-04-2023', 2, 0, 0, 0)
INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH], [TienCong], [TienPhuTung], [TongTien]) VALUES (N'003003', '03-04-2023', 3, 0, 0, 0)
INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH], [TienCong], [TienPhuTung], [TongTien]) VALUES (N'004004', '04-05-2023', 4, 0, 0, 0) 
INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH], [TienCong], [TienPhuTung], [TongTien]) VALUES (N'005005', '05-05-2023', 5, 0, 0, 0)
INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH], [TienCong], [TienPhuTung], [TongTien]) VALUES (N'006006', '06-05-2023', 6, 0, 0, 0)
INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH], [TienCong], [TienPhuTung], [TongTien]) VALUES (N'007007', '07-06-2023', 7, 0, 0, 0)
INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH], [TienCong], [TienPhuTung], [TongTien]) VALUES (N'008008', '08-06-2023', 8, 0, 0, 0)
INSERT [dbo].[PHIEUSUACHUA]([BienSo], [NgaySuaChua], [MaKH], [TienCong], [TienPhuTung], [TongTien]) VALUES (N'009009', '09-06-2023', 9, 0, 0, 0)


INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (1, 100000, '01/04/2023 09:00:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (2, 200000, '02/04/2023 14:30:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (3, 400000, '03/04/2023 18:15:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (4, 600000, '15/04/2023 09:00:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (5, 900000, '15/04/2023 14:30:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (6, 700000, '16/04/2023 18:15:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (7, 150000, '17/04/2023 09:00:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (8, 850000, '18/04/2023 14:30:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (9, 300000, '25/04/2023 18:15:00')

INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (1, 500000, '02/05/2023 09:00:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (2, 700000, '04/05/2023 14:30:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (3, 500000, '09/05/2023 18:15:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (4, 800000, '15/05/2023 09:00:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (5, 250000, '16/05/2023 14:30:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (6, 650000, '24/05/2023 18:15:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (7, 950000, '25/05/2023 09:00:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (8, 600000, '28/05/2023 14:30:00')
INSERT [dbo].[PHIEUTHUTIEN]([MaKH], [TienThu], [NgayThuTien]) VALUES (9, 550000, '29/05/2023 18:15:00')

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

EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Bánh xe', @TonDau = 100, @PhatSinh = 60, @TonCuoi = 20
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Lọc dầu', @TonDau = 120, @PhatSinh = 50, @TonCuoi = 60
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Lọc gió', @TonDau = 120, @PhatSinh = 100, @TonCuoi = 90
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Ống xả', @TonDau = 150, @PhatSinh = 80, @TonCuoi = 70
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Lọc nhiên liệu', @TonDau = 120, @PhatSinh = 40, @TonCuoi = 80
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Bình dầu', @TonDau = 80, @PhatSinh = 20, @TonCuoi = 60
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Giảm sóc', @TonDau = 250, @PhatSinh = 100, @TonCuoi = 150
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Công tắc đèn', @TonDau = 200, @PhatSinh = 80, @TonCuoi = 120
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Dây curoa', @TonDau = 180, @PhatSinh = 60, @TonCuoi = 120
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Vành đúc', @TonDau = 120, @PhatSinh = 40, @TonCuoi = 80
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Máy nổ', @TonDau = 10, @PhatSinh = 5, @TonCuoi = 15
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Ly hợp', @TonDau = 30, @PhatSinh = 10, @TonCuoi = 20
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Bộ phanh', @TonDau = 50, @PhatSinh = 20, @TonCuoi = 30
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Đèn pha', @TonDau = 80, @PhatSinh = 30, @TonCuoi = 50
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Cụm điều khiển', @TonDau = 25, @PhatSinh = 15, @TonCuoi = 10
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Ốp lưng ghế', @TonDau = 60, @PhatSinh = 25, @TonCuoi = 35
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Cảm biến áp suất lốp', @TonDau = 15, @PhatSinh = 10, @TonCuoi = 15
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Dây điện', @TonDau = 100, @PhatSinh = 50, @TonCuoi = 100
EXEC InsertBaoCaoTonKho45 @Thang = 4, @Nam = 2023, @TenVatTuPhuTung = N'Máy phát điện', @TonDau = 5, @PhatSinh = 3, @TonCuoi = 7

EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Kính chắn', @TonDau = 65, @PhatSinh = 75, @TonCuoi = 40
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Bánh xe', @TonDau = 80, @PhatSinh = 80, @TonCuoi = 50
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Cửa kính', @TonDau = 90, @PhatSinh = 180, @TonCuoi = 150
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Ống xả', @TonDau = 150, @PhatSinh = 80, @TonCuoi = 70
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Lọc nhiên liệu', @TonDau = 120, @PhatSinh = 60, @TonCuoi = 100
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Bình dầu', @TonDau = 80, @PhatSinh = 30, @TonCuoi = 80
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Giảm sóc', @TonDau = 250, @PhatSinh = 120, @TonCuoi = 230
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Công tắc đèn', @TonDau = 200, @PhatSinh = 80, @TonCuoi = 120
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Dây curoa', @TonDau = 180, @PhatSinh = 90, @TonCuoi = 100
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Vành đúc', @TonDau = 120, @PhatSinh = 40, @TonCuoi = 80
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Máy nổ', @TonDau = 10, @PhatSinh = 5, @TonCuoi = 15
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Ly hợp', @TonDau = 30, @PhatSinh = 10, @TonCuoi = 20
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Bộ phanh', @TonDau = 50, @PhatSinh = 20, @TonCuoi = 30
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Đèn pha', @TonDau = 80, @PhatSinh = 30, @TonCuoi = 50
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Cụm điều khiển', @TonDau = 25, @PhatSinh = 15, @TonCuoi = 20
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Ốp lưng ghế', @TonDau = 60, @PhatSinh = 25, @TonCuoi = 35
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Cảm biến áp suất lốp', @TonDau = 15, @PhatSinh = 10, @TonCuoi = 15
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Dây điện', @TonDau = 100, @PhatSinh = 50, @TonCuoi = 100
EXEC InsertBaoCaoTonKho45 @Thang = 5, @Nam = 2023, @TenVatTuPhuTung = N'Máy phát điện', @TonDau = 5, @PhatSinh = 3, @TonCuoi = 7



INSERT [dbo].[BAOCAOTON] ([ThoiDiemBaoCao]) VALUES ('01/06/2023 09:00:00')
INSERT [dbo].[BAOCAOTON] ([ThoiDiemBaoCao]) VALUES ('01/05/2023 09:00:00')
INSERT [dbo].[BAOCAOTON] ([ThoiDiemBaoCao]) VALUES ('01/04/2023 09:00:00')

INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,1,100,0,100)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,2,200,0,200)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (1,3,300,0,300)

INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,1,100,0,100)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,2,200,0,200)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (2,3,300,0,300)

INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (3,1,100,0,100)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (3,2,200,0,200)
INSERT [dbo].[CT_BAOCAOTON] ([MaBCT], [MaPhuTung], [TonDau], [PhatSinh], [TonCuoi]) VALUES (3,3,300,0,300)

INSERT [dbo].[TienCong]([TenTienCong], [ChiPhi]) 
VALUES (N'Thay nhớt', 100),
       (N'Vệ sinh nội thất', 150),
       (N'Kiểm tra động cơ', 200),
       (N'Thay bộ lọc gió', 80),
       (N'Thay dầu phanh', 120),
       (N'Bảo dưỡng hệ thống phanh', 180),
       (N'Thay bình ắc quy', 100),
       (N'Kiểm tra hệ thống treo', 160),
       (N'Thay bóng đèn', 50),
       (N'Vệ sinh hệ thống làm mát', 130),
       (N'Kiểm tra hệ thống điện', 90),
       (N'Thay côn trống', 140),
       (N'Vệ sinh buồng đốt', 110),
       (N'Thay dây đai truyền động', 170),
       (N'Kiểm tra hệ thống làm nhiên liệu', 150),
       (N'Thay cầu chì', 70),
       (N'Vệ sinh hệ thống điều hòa', 160),
       (N'Kiểm tra hệ thống làm phanh', 180),
       (N'Thay bujít', 60),
       (N'Vệ sinh bộ lọc không khí', 100),
       (N'Kiểm tra hệ thống treo', 160),
       (N'Thay cổ pô', 130),
       (N'Vệ sinh hệ thống phanh', 180),
       (N'Kiểm tra hệ thống điều khiển', 120),
       (N'Thay ống xả', 150),
       (N'Vệ sinh hệ thống làm mát', 130),
       (N'Kiểm tra hệ thống nạp nhiên liệu', 140),
       (N'Thay bộ điều khiển động cơ', 200),
       (N'Vệ sinh hệ thống điện', 90),
       (N'Kiểm tra hệ thống điều hòa', 160),
       (N'Thay bơm xăng', 120),
       (N'Vệ sinh hệ thống phun xăng', 140),
       (N'Kiểm tra hệ thống làm nhiên liệu', 150),
       (N'Thay cầu chì', 70),
       (N'Vệ sinh bộ lọc không khí', 100),
       (N'Kiểm tra hệ thống treo', 160),
       (N'Thay cổ pô', 130),
       (N'Vệ sinh hệ thống phanh', 180),
       (N'Kiểm tra hệ thống điều khiển', 120),
       (N'Thay ống xả', 150),
       (N'Vệ sinh hệ thống làm mát', 130),
       (N'Kiểm tra hệ thống nạp nhiên liệu', 140),
       (N'Thay bộ điều khiển động cơ', 200),
       (N'Vệ sinh hệ thống điện', 90),
       (N'Kiểm tra hệ thống điều hòa', 160),
       (N'Thay bơm xăng', 120),
       (N'Vệ sinh hệ thống phun xăng', 140)

USE [master]
GO
ALTER DATABASE [QuanLyGarage] SET  READ_WRITE 
GO