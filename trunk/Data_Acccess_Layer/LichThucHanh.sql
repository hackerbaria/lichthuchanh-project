USE [master]
GO
/****** Object:  Database [LichThucHanh]    Script Date: 11/13/2014 9:52:08 PM ******/
CREATE DATABASE [LichThucHanh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LichThucHanh', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.DUONG\MSSQL\DATA\LichThucHanh.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LichThucHanh_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.DUONG\MSSQL\DATA\LichThucHanh_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LichThucHanh] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LichThucHanh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LichThucHanh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LichThucHanh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LichThucHanh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LichThucHanh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LichThucHanh] SET ARITHABORT OFF 
GO
ALTER DATABASE [LichThucHanh] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LichThucHanh] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [LichThucHanh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LichThucHanh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LichThucHanh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LichThucHanh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LichThucHanh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LichThucHanh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LichThucHanh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LichThucHanh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LichThucHanh] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LichThucHanh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LichThucHanh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LichThucHanh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LichThucHanh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LichThucHanh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LichThucHanh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LichThucHanh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LichThucHanh] SET RECOVERY FULL 
GO
ALTER DATABASE [LichThucHanh] SET  MULTI_USER 
GO
ALTER DATABASE [LichThucHanh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LichThucHanh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LichThucHanh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LichThucHanh] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'LichThucHanh', N'ON'
GO
USE [LichThucHanh]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/13/2014 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[TenDangNhap] [varchar](20) NOT NULL,
	[MatKhau] [nvarchar](20) NOT NULL,
	[Quyen] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 11/13/2014 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGV] [varchar](10) NOT NULL,
	[TenGV] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [varchar](13) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LichDay]    Script Date: 11/13/2014 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LichDay](
	[MaGV] [varchar](10) NOT NULL,
	[MaMH] [varchar](10) NOT NULL,
	[MaLop] [varchar](10) NOT NULL,
	[MaPhong] [varchar](10) NOT NULL,
	[MaTG] [varchar](10) NOT NULL,
	[Ngay] [date] NOT NULL,
	[Tuan] [int] NOT NULL,
	[Thu] [nvarchar](20) NOT NULL,
	[Buoi] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_KhoaChinh] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC,
	[MaMH] ASC,
	[MaLop] ASC,
	[MaPhong] ASC,
	[MaTG] ASC,
	[Ngay] ASC,
	[Tuan] ASC,
	[Thu] ASC,
	[Buoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 11/13/2014 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [varchar](10) NOT NULL,
	[TenLop] [nvarchar](100) NOT NULL,
	[SoLuongSV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 11/13/2014 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [varchar](10) NOT NULL,
	[TenMonHoc] [nvarchar](50) NULL,
	[SoChi] [int] NULL,
	[SoTiet] [int] NULL,
	[Khoa] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 11/13/2014 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [varchar](10) NOT NULL,
	[TenPhong] [nvarchar](50) NOT NULL,
	[SoMay] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThoiGian]    Script Date: 11/13/2014 9:52:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThoiGian](
	[MaTG] [varchar](10) NOT NULL,
	[Tiet] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Account] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'admin', N'1234', 1)
INSERT [dbo].[Account] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'GV001', N'GV001', 2)
INSERT [dbo].[Account] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'GV002', N'GV002', 2)
INSERT [dbo].[Account] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'GV003', N'GV003', 2)
INSERT [dbo].[Account] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'GV004', N'GV004', 2)
INSERT [dbo].[Account] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'GV005', N'GV005', 2)
INSERT [dbo].[Account] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'GV006', N'GV006', 2)
INSERT [dbo].[Account] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'GV007', N'GV007', 2)
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DiaChi], [SoDienThoai]) VALUES (N'GV001', N'Nguy?n Van A', N'P .Linh Chi?u - Q. Th?  Ð?c', N'0987654432')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DiaChi], [SoDienThoai]) VALUES (N'GV002', N'Ph?m Van B', N'Qu?n 9', N'0909374852')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DiaChi], [SoDienThoai]) VALUES (N'GV003', N'Lê Th? Phu?ng', N'Qu?n 7', N'0987654432')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DiaChi], [SoDienThoai]) VALUES (N'GV004', N'Ngô Qu?c Hùng', N'Qu?n 4', N'0967323834')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DiaChi], [SoDienThoai]) VALUES (N'GV005', N'Nguy?n Th? Hu?', N'Qu?n3', N'0168345234')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DiaChi], [SoDienThoai]) VALUES (N'GV006', N'Lê Van Toàn', N'Qu?n 1', N'0392393434')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoLuongSV]) VALUES (N'L001', N'Toán R?i R?c Và Lý Thuyêt Ð? Th?', 50)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoLuongSV]) VALUES (N'L002', N'C?u Trúc Máy Tính Và H?p Ng?', 50)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoLuongSV]) VALUES (N'L003', N'H? Ði?u Hành', 50)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoLuongSV]) VALUES (N'L004', N'K? Thu?t L?p Trình', 50)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoLuongSV]) VALUES (N'L005', N'M?ng Máy Tính Can B?n', 50)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoLuongSV]) VALUES (N'L006', N'Co S? D? Li?u', 50)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [SoLuongSV]) VALUES (N'L007', N'L?p Trình Hu?ng Ð?i Tu?ng', 50)
INSERT [dbo].[MonHoc] ([MaMH], [TenMonHoc], [SoChi], [SoTiet], [Khoa]) VALUES (N'MH001', N'Toán R?i R?c Và Lý Thuyêt Ð? Th?', 4, 5, N'CNTT')
INSERT [dbo].[MonHoc] ([MaMH], [TenMonHoc], [SoChi], [SoTiet], [Khoa]) VALUES (N'MH002', N'C?u Trúc Máy Tính Và H?p Ng?', 4, 5, N'CNTT')
INSERT [dbo].[MonHoc] ([MaMH], [TenMonHoc], [SoChi], [SoTiet], [Khoa]) VALUES (N'MH003', N'H? Ði?u Hành', 4, 5, N'CNTT')
INSERT [dbo].[MonHoc] ([MaMH], [TenMonHoc], [SoChi], [SoTiet], [Khoa]) VALUES (N'MH004', N'K? Thu?t L?p Trình', 4, 5, N'CNTT')
INSERT [dbo].[MonHoc] ([MaMH], [TenMonHoc], [SoChi], [SoTiet], [Khoa]) VALUES (N'MH005', N'M?ng Máy Tính Can B?n', 4, 5, N'CNTT')
INSERT [dbo].[MonHoc] ([MaMH], [TenMonHoc], [SoChi], [SoTiet], [Khoa]) VALUES (N'MH006', N'Co S? D? Li?u', 4, 5, N'CNTT')
INSERT [dbo].[MonHoc] ([MaMH], [TenMonHoc], [SoChi], [SoTiet], [Khoa]) VALUES (N'MH007', N'L?p Trình Hu?ng Ð?i Tu?ng', 4, 5, N'CNTT')
INSERT [dbo].[MonHoc] ([MaMH], [TenMonHoc], [SoChi], [SoTiet], [Khoa]) VALUES (N'MH008', N'Công Ngh? Ph?n M?m', 4, 5, N'CNTT')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [SoMay]) VALUES (N'P001', N'PM1', 50)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [SoMay]) VALUES (N'P002', N'PM2', 45)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [SoMay]) VALUES (N'P003', N'PM3', 50)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [SoMay]) VALUES (N'P004', N'PM4', 40)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [SoMay]) VALUES (N'P005', N'PM5', 50)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [SoMay]) VALUES (N'P006', N'A5-201', 50)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [SoMay]) VALUES (N'P007', N'A5-202', 50)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [SoMay]) VALUES (N'P008', N'A5-203', 50)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [SoMay]) VALUES (N'P009', N'A5-204', 50)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [SoMay]) VALUES (N'P010', N'A5-301', 50)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [SoMay]) VALUES (N'P011', N'A5-302', 50)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [SoMay]) VALUES (N'P012', N'A5-303', 50)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [SoMay]) VALUES (N'P013', N'A5-304', 50)
INSERT [dbo].[ThoiGian] ([MaTG], [Tiet]) VALUES (N'TG001', N'1-5')
INSERT [dbo].[ThoiGian] ([MaTG], [Tiet]) VALUES (N'TG002', N'1-4')
INSERT [dbo].[ThoiGian] ([MaTG], [Tiet]) VALUES (N'TG003', N'1-3')
INSERT [dbo].[ThoiGian] ([MaTG], [Tiet]) VALUES (N'TG004', N'1-2')
INSERT [dbo].[ThoiGian] ([MaTG], [Tiet]) VALUES (N'TG005', N'3-5')
INSERT [dbo].[ThoiGian] ([MaTG], [Tiet]) VALUES (N'TG006', N'3-4')
INSERT [dbo].[ThoiGian] ([MaTG], [Tiet]) VALUES (N'TG007', N'7-12')
INSERT [dbo].[ThoiGian] ([MaTG], [Tiet]) VALUES (N'TG008', N'7-11')
INSERT [dbo].[ThoiGian] ([MaTG], [Tiet]) VALUES (N'TG009', N'7-10')
INSERT [dbo].[ThoiGian] ([MaTG], [Tiet]) VALUES (N'TG010', N'7-8')
INSERT [dbo].[ThoiGian] ([MaTG], [Tiet]) VALUES (N'TG011', N'9-12')
INSERT [dbo].[ThoiGian] ([MaTG], [Tiet]) VALUES (N'TG012', N'9-11')
INSERT [dbo].[ThoiGian] ([MaTG], [Tiet]) VALUES (N'TG013', N'9-10')
ALTER TABLE [dbo].[LichDay]  WITH CHECK ADD FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[LichDay]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[LichDay]  WITH CHECK ADD FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[LichDay]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[LichDay]  WITH CHECK ADD FOREIGN KEY([MaTG])
REFERENCES [dbo].[ThoiGian] ([MaTG])
GO
USE [master]
GO
ALTER DATABASE [LichThucHanh] SET  READ_WRITE 
GO
