USE [master]
GO
/****** Object:  Database [QLHocSinh]    Script Date: 06/08/2014 14:14:46 ******/
CREATE DATABASE [QLHocSinh]
GO
ALTER DATABASE [QLHocSinh] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLHocSinh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLHocSinh] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QLHocSinh] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QLHocSinh] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QLHocSinh] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QLHocSinh] SET ARITHABORT OFF
GO
ALTER DATABASE [QLHocSinh] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QLHocSinh] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QLHocSinh] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QLHocSinh] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QLHocSinh] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QLHocSinh] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QLHocSinh] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QLHocSinh] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QLHocSinh] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QLHocSinh] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QLHocSinh] SET  DISABLE_BROKER
GO
ALTER DATABASE [QLHocSinh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QLHocSinh] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QLHocSinh] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QLHocSinh] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QLHocSinh] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QLHocSinh] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QLHocSinh] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QLHocSinh] SET  READ_WRITE
GO
ALTER DATABASE [QLHocSinh] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QLHocSinh] SET  MULTI_USER
GO
ALTER DATABASE [QLHocSinh] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QLHocSinh] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLHocSinh', N'ON'
GO
USE [QLHocSinh]
GO
/****** Object:  Table [dbo].[HocKy]    Script Date: 06/08/2014 14:14:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocKy](
	[MaHK] [int] IDENTITY(1,1) NOT NULL,
	[TenHK] [nvarchar](50) NULL,
	[NamHoc] [nvarchar](50) NULL,
 CONSTRAINT [PK_HocKy] PRIMARY KEY CLUSTERED 
(
	[MaHK] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiDiem]    Script Date: 06/08/2014 14:14:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDiem](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiDiem] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoi]    Script Date: 06/08/2014 14:14:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoi](
	[MaKhoi] [int] IDENTITY(1,1) NOT NULL,
	[TenKhoi] [nvarchar](10) NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_Khoi] PRIMARY KEY CLUSTERED 
(
	[MaKhoi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyDinh]    Script Date: 06/08/2014 14:14:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinh](
	[MaQD] [int] IDENTITY(1,1) NOT NULL,
	[TenQD] [nvarchar](50) NULL,
	[NoiDung] [nvarchar](100) NULL,
 CONSTRAINT [PK_QuyDinh] PRIMARY KEY CLUSTERED 
(
	[MaQD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 06/08/2014 14:14:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [int] IDENTITY(1,1) NOT NULL,
	[TenMH] [nvarchar](50) NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 06/08/2014 14:14:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [int] IDENTITY(1,1) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
	[SiSo] [int] NULL,
	[MaKhoi] [int] NOT NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 06/08/2014 14:14:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHS] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[MaLop] [int] NULL,
 CONSTRAINT [PK_HocSinh] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 06/08/2014 14:14:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diem](
	[MaHS] [int] NOT NULL,
	[MaMH] [int] NOT NULL,
	[MaHK] [int] NOT NULL,
	[MaLoaiDiem] [int] NOT NULL,
	[Diem] [float] NOT NULL,
 CONSTRAINT [PK_Diem] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC,
	[MaMH] ASC,
	[MaHK] ASC,
	[MaLoaiDiem] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Lop_Khoi]    Script Date: 06/08/2014 14:14:47 ******/
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Khoi] FOREIGN KEY([MaKhoi])
REFERENCES [dbo].[Khoi] ([MaKhoi])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_Khoi]
GO
/****** Object:  ForeignKey [FK_HocSinh_Lop]    Script Date: 06/08/2014 14:14:47 ******/
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_Lop]
GO
/****** Object:  ForeignKey [FK_Diem_HocKy]    Script Date: 06/08/2014 14:14:47 ******/
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_HocKy] FOREIGN KEY([MaHK])
REFERENCES [dbo].[HocKy] ([MaHK])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_HocKy]
GO
/****** Object:  ForeignKey [FK_Diem_HocSinh]    Script Date: 06/08/2014 14:14:47 ******/
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_HocSinh] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinh] ([MaHS])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_HocSinh]
GO
/****** Object:  ForeignKey [FK_Diem_LoaiDiem]    Script Date: 06/08/2014 14:14:47 ******/
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_LoaiDiem] FOREIGN KEY([MaLoaiDiem])
REFERENCES [dbo].[LoaiDiem] ([MaLoai])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_LoaiDiem]
GO
/****** Object:  ForeignKey [FK_Diem_MonHoc]    Script Date: 06/08/2014 14:14:47 ******/
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_MonHoc] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_MonHoc]
GO


insert into LoaiDiem(TenLoai) values(N'Điểm 15 phút')
insert into LoaiDiem(TenLoai) values(N'Điểm 1 tiết')
insert into LoaiDiem(TenLoai) values(N'Điểm cuối học kỳ')

insert into HocKy(TenHK, NamHoc) values(N'Học kỳ 1', N'2013-2014')
insert into HocKy(TenHK, NamHoc) values(N'Học kỳ 2', N'2013-2014')
insert into HocKy(TenHK, NamHoc) values(N'Học kỳ 1', N'2014-2015')
insert into HocKy(TenHK, NamHoc) values(N'Học kỳ 2', N'2014-2015')

insert into MonHoc(TenMH) values(N'Toán')
insert into MonHoc(TenMH) values(N'Lý')
insert into MonHoc(TenMH) values(N'Hóa')
insert into MonHoc(TenMH) values(N'Sinh')
insert into MonHoc(TenMH) values(N'Sử')
insert into MonHoc(TenMH) values(N'Địa')
insert into MonHoc(TenMH) values(N'Văn')
insert into MonHoc(TenMH) values(N'Đạo đức')
insert into MonHoc(TenMH) values(N'Thể dục')

insert into Khoi(TenKhoi, SoLuong) values(N'Khối 10', 4)
insert into Khoi(TenKhoi, SoLuong) values(N'Khối 11', 3)
insert into Khoi(TenKhoi, SoLuong) values(N'Khối 12', 2)

insert into Lop(TenLop, SiSo, MaKhoi) values(N'10A1', 0, 1)
insert into Lop(TenLop, SiSo, MaKhoi) values(N'10A2', 0, 1)
insert into Lop(TenLop, SiSo, MaKhoi) values(N'10A3', 0, 1)
insert into Lop(TenLop, SiSo, MaKhoi) values(N'10A4', 0, 1)
insert into Lop(TenLop, SiSo, MaKhoi) values(N'11A1', 0, 2)
insert into Lop(TenLop, SiSo, MaKhoi) values(N'11A2', 0, 2)
insert into Lop(TenLop, SiSo, MaKhoi) values(N'11A3', 0, 2)
insert into Lop(TenLop, SiSo, MaKhoi) values(N'12A1', 0, 3)
insert into Lop(TenLop, SiSo, MaKhoi) values(N'12A2', 0, 3)

insert into HocSinh(HoTen, GioiTinh, DiaChi, Email, NgaySinh, Malop) values(N'Nguyễn Văn A', N'Nam', N'123', N'nguyen@gmail.com', '1996-09-13', 1)
insert into HocSinh(HoTen, GioiTinh, DiaChi, Email, NgaySinh, Malop) values(N'Nguyễn Văn B', N'Nam', N'123', N'nguyen2@gmail.com', '1996-09-13', 2)
insert into HocSinh(HoTen, GioiTinh, DiaChi, Email, NgaySinh, Malop) values(N'Nguyễn Văn C', N'Nam', N'123', N'nguyen3@gmail.com', '1996-09-13', 1)
insert into HocSinh(HoTen, GioiTinh, DiaChi, Email, NgaySinh, Malop) values(N'Nguyễn Văn D', N'Nam', N'123', N'nguyen4@gmail.com', '1996-09-13', 1)
insert into HocSinh(HoTen, GioiTinh, DiaChi, Email, NgaySinh, Malop) values(N'Nguyễn Văn E', N'Nam', N'123', N'nguyen5@gmail.com', '1996-09-13', 3)

insert into Diem(MaHS, MaHK, MaLoaiDiem, MaMH, Diem) values(1, 1, 2, 3, 10)
insert into Diem(MaHS, MaHK, MaLoaiDiem, MaMH, Diem) values(2, 1, 2, 3, 10)
insert into Diem(MaHS, MaHK, MaLoaiDiem, MaMH, Diem) values(4, 1, 2, 3, 10)
insert into Diem(MaHS, MaHK, MaLoaiDiem, MaMH, Diem) values(1, 1, 2, 3, 10)
insert into Diem(MaHS, MaHK, MaLoaiDiem, MaMH, Diem) values(2, 1, 2, 4, 10)
insert into Diem(MaHS, MaHK, MaLoaiDiem, MaMH, Diem) values(2, 1, 2, 5, 10)
insert into Diem(MaHS, MaHK, MaLoaiDiem, MaMH, Diem) values(2, 1, 3, 5, 10)
insert into Diem(MaHS, MaHK, MaLoaiDiem, MaMH, Diem) values(2, 1, 1, 5, 10)