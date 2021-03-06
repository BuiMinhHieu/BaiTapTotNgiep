USE [master]
GO
/****** Object:  Database [Buiminhhieu_Qlthuhocphi_17]    Script Date: 03/25/2018 3:46:17 PM ******/
CREATE DATABASE [Buiminhhieu_Qlthuhocphi_17]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Buiminhhieu_Qlthuhocphi_17', FILENAME = N'E:\Thuc Tap Tot Nghiep\Qlthuhocphi_Buiminhhieu_17\Buiminhhieu_Qlthuhocphi_17.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Buiminhhieu_Qlthuhocphi_17_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Buiminhhieu_Qlthuhocphi_17_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Buiminhhieu_Qlthuhocphi_17].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET ARITHABORT OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET  MULTI_USER 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Buiminhhieu_Qlthuhocphi_17]
GO
/****** Object:  Table [dbo].[BienLai]    Script Date: 03/25/2018 3:46:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BienLai](
	[Idbienlai] [varchar](10) NOT NULL,
	[Ngaythu] [date] NULL,
	[Nguoithu] [nvarchar](50) NULL,
	[Bantru] [nvarchar](50) NULL,
	[Tienan] [int] NULL,
	[Sotiennop] [int] NULL,
	[Tongtien] [int] NULL,
	[Idhocsinh] [varchar](10) NULL,
 CONSTRAINT [PK_BienLai] PRIMARY KEY CLUSTERED 
(
	[Idbienlai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DoiTuongMienGiam]    Script Date: 03/25/2018 3:46:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DoiTuongMienGiam](
	[Iddoituong] [varchar](10) NOT NULL,
	[Tendoituong] [nvarchar](50) NULL,
	[Mucmiengiam] [int] NULL,
 CONSTRAINT [PK_DoiTuongMienGiam] PRIMARY KEY CLUSTERED 
(
	[Iddoituong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 03/25/2018 3:46:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HocSinh](
	[Idhocsinh] [varchar](10) NOT NULL,
	[Tenhocsinh] [nvarchar](50) NULL,
	[NS] [date] NULL,
	[GT] [nvarchar](50) NULL,
	[DC] [nvarchar](50) NULL,
	[Iddoituong] [varchar](10) NULL,
	[Idlop] [varchar](10) NULL,
 CONSTRAINT [PK_HocSinh] PRIMARY KEY CLUSTERED 
(
	[Idhocsinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 03/25/2018 3:46:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lop](
	[Idlop] [varchar](10) NOT NULL,
	[Tenlop] [nvarchar](50) NULL,
	[Siso] [int] NULL,
	[Idmucthu] [varchar](10) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[Idlop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MucThu]    Script Date: 03/25/2018 3:46:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MucThu](
	[Idmucthu] [varchar](10) NOT NULL,
	[Sotien] [int] NULL,
	[Ngayapdung] [date] NULL,
	[Namhoc] [nvarchar](50) NULL,
 CONSTRAINT [PK_MucThu] PRIMARY KEY CLUSTERED 
(
	[Idmucthu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TheoDoiLichAn]    Script Date: 03/25/2018 3:46:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TheoDoiLichAn](
	[Idphieu] [varchar](10) NOT NULL,
	[Thangnam] [date] NULL,
	[Songaynghi] [int] NULL,
	[Ghichu] [nvarchar](50) NULL,
	[Idhocsinh] [varchar](10) NULL,
 CONSTRAINT [PK_TheoDoiLichAn] PRIMARY KEY CLUSTERED 
(
	[Idphieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BienLai] ([Idbienlai], [Ngaythu], [Nguoithu], [Bantru], [Tienan], [Sotiennop], [Tongtien], [Idhocsinh]) VALUES (N'BL001', CAST(0xC83D0B00 AS Date), N'Nguyễn Thị Xuân', NULL, NULL, 4000000, 4000000, N'HS001')
INSERT [dbo].[BienLai] ([Idbienlai], [Ngaythu], [Nguoithu], [Bantru], [Tienan], [Sotiennop], [Tongtien], [Idhocsinh]) VALUES (N'Bl002', CAST(0xD8360B00 AS Date), N'Chu Thị Sao', N'Có', 350000, 3000000, 3350000, N'HS013')
INSERT [dbo].[BienLai] ([Idbienlai], [Ngaythu], [Nguoithu], [Bantru], [Tienan], [Sotiennop], [Tongtien], [Idhocsinh]) VALUES (N'BL003', CAST(0x4C320B00 AS Date), N'Bùi Thị Huyền', NULL, NULL, 2500000, 2500000, N'HS010')
INSERT [dbo].[BienLai] ([Idbienlai], [Ngaythu], [Nguoithu], [Bantru], [Tienan], [Sotiennop], [Tongtien], [Idhocsinh]) VALUES (N'BL004', CAST(0x523D0B00 AS Date), N'Lương Thị Thảo', N'Có', 1000000, 4000000, 5000000, N'HS014')
INSERT [dbo].[BienLai] ([Idbienlai], [Ngaythu], [Nguoithu], [Bantru], [Tienan], [Sotiennop], [Tongtien], [Idhocsinh]) VALUES (N'Bl005', CAST(0xD2390B00 AS Date), N'Trần Thị Thu', N'Có', 450000, 3500000, 3950000, N'HS002')
INSERT [dbo].[DoiTuongMienGiam] ([Iddoituong], [Tendoituong], [Mucmiengiam]) VALUES (N'DT001', N'Gia đình chính sách', 3000000)
INSERT [dbo].[DoiTuongMienGiam] ([Iddoituong], [Tendoituong], [Mucmiengiam]) VALUES (N'DT002', N'Hộ nghèo', 1500000)
INSERT [dbo].[DoiTuongMienGiam] ([Iddoituong], [Tendoituong], [Mucmiengiam]) VALUES (N'DT003', N'Cận  nghèo', 1000000)
INSERT [dbo].[DoiTuongMienGiam] ([Iddoituong], [Tendoituong], [Mucmiengiam]) VALUES (N'DT004', N'Học sinh có hoàn cảnh khó khăn', 2000000)
INSERT [dbo].[DoiTuongMienGiam] ([Iddoituong], [Tendoituong], [Mucmiengiam]) VALUES (N'DT005', N'Dân tộc thiểu số', 500000)
INSERT [dbo].[DoiTuongMienGiam] ([Iddoituong], [Tendoituong], [Mucmiengiam]) VALUES (N'DT006', N'Con thương binh liệt sĩ', 3000000)
INSERT [dbo].[DoiTuongMienGiam] ([Iddoituong], [Tendoituong], [Mucmiengiam]) VALUES (N'DT007', N'Học sinh bị tàn tật khuyết tật', 2500000)
INSERT [dbo].[DoiTuongMienGiam] ([Iddoituong], [Tendoituong], [Mucmiengiam]) VALUES (N'DT008', N'Hoc sinh trường nội trú', 3500000)
INSERT [dbo].[DoiTuongMienGiam] ([Iddoituong], [Tendoituong], [Mucmiengiam]) VALUES (N'DT009', N'Con cán bộ công nhân viên chức', 1000000)
INSERT [dbo].[DoiTuongMienGiam] ([Iddoituong], [Tendoituong], [Mucmiengiam]) VALUES (N'DT010', N'Con hạ sĩ quan chiến sĩ', 500000)
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS001', N'Bùi Minh Hiếu', CAST(0x3E2E0B00 AS Date), N'Nam', N'Hà Nội', N'DT002', N'L010')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS002', N'Nguyễn Văn Tiến', CAST(0x940C0000 AS Date), N'Nam', N'Hà Nôi', N'DT005', N'L001')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS003', N'Lương Thị Thảo', CAST(0x3E2F0B00 AS Date), N'Nữ', N'Bắc Giang', NULL, N'L003')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS004', N'Nguyễn Thị Tuyết Mai', CAST(0x3A340B00 AS Date), N'Nữ', N'Phú Thọ', NULL, N'L004')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS005', N'Bùi Tùng Lâm', CAST(0x66330B00 AS Date), N'Nam', N'Hưng Yên', N'DT003', N'L001')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS006', N'Lê Xuân Hoàng', CAST(0x11340B00 AS Date), N'Nam', N'Hà Nội', NULL, N'L009')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS007', N'Lưu Đình Phong', CAST(0x592C0B00 AS Date), N'Nam', N'Vĩnh Phúc', NULL, N'L005')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS008', N'Nguyễn Thành Hiệp', CAST(0xAB250B00 AS Date), N'Nam', N'Hà Nội', NULL, N'L004')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS009', N'Nguyễn Thị Quy', CAST(0x65240B00 AS Date), N'Nữ', N'Thanh Hóa', N'DT003', N'L004')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS010', N'Bùi Văn Đức', CAST(0x1D260B00 AS Date), N'Nam', N'Đà Nẵng', NULL, N'L007')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS011', N'Nguyễn Thị Huyền', CAST(0xCB300B00 AS Date), N'Nữ', N'Hòa Bình', N'DT010', N'L002')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS012', N'Đinh Lệ Thu', CAST(0x6D200B00 AS Date), N'Nữ', N'Hà Nam', N'DT005', N'L001')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS013', N'Bùi Minh Luân', CAST(0x68200B00 AS Date), N'Nam', N'Nam Định', NULL, N'L010')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS014', N'Trần Văn Quang', CAST(0xA5330B00 AS Date), N'Nam', N'Hà Tây', N'DT001', N'L008')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS015', N'Nguyễn Quang Sáng', CAST(0x1E2E0B00 AS Date), N'Nam', N'Tuyên Quang', N'DT004', N'L006')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS016', N'Chu Thị Đại', CAST(0x991F0B00 AS Date), N'Nữ', N'Hà Nội', NULL, N'L006')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS017', N'Nguyễn Văn Tiểu', CAST(0x342A0B00 AS Date), N'Nam', N'Yên Bái', N'DT007', N'L004')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS018', N'Vừng Thị Xuân', CAST(0x57310B00 AS Date), N'Nữ', N'Sơn La', N'DT008', N'L003')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS019', N'Đỗ Duy Đạt', CAST(0x102C0B00 AS Date), N'Nam', N'Hà Nội', NULL, N'L002')
INSERT [dbo].[HocSinh] ([Idhocsinh], [Tenhocsinh], [NS], [GT], [DC], [Iddoituong], [Idlop]) VALUES (N'HS020', N'Bùi Thị Hậu', CAST(0xC1330B00 AS Date), N'Nữ', N'Ninh Bình', N'DT002', N'L010')
INSERT [dbo].[Lop] ([Idlop], [Tenlop], [Siso], [Idmucthu]) VALUES (N'L001', N'1A', 26, N'MT001')
INSERT [dbo].[Lop] ([Idlop], [Tenlop], [Siso], [Idmucthu]) VALUES (N'L002', N'1B', 30, N'MT005')
INSERT [dbo].[Lop] ([Idlop], [Tenlop], [Siso], [Idmucthu]) VALUES (N'L003', N'2A', 31, N'MT003')
INSERT [dbo].[Lop] ([Idlop], [Tenlop], [Siso], [Idmucthu]) VALUES (N'L004', N'2B', 40, N'MT002')
INSERT [dbo].[Lop] ([Idlop], [Tenlop], [Siso], [Idmucthu]) VALUES (N'L005', N'3A', 23, N'MT004')
INSERT [dbo].[Lop] ([Idlop], [Tenlop], [Siso], [Idmucthu]) VALUES (N'L006', N'3B', 33, N'MT002')
INSERT [dbo].[Lop] ([Idlop], [Tenlop], [Siso], [Idmucthu]) VALUES (N'L007', N'4A', 31, N'MT005')
INSERT [dbo].[Lop] ([Idlop], [Tenlop], [Siso], [Idmucthu]) VALUES (N'L008', N'4B', 28, N'MT002')
INSERT [dbo].[Lop] ([Idlop], [Tenlop], [Siso], [Idmucthu]) VALUES (N'L009', N'5A', 41, N'MT001')
INSERT [dbo].[Lop] ([Idlop], [Tenlop], [Siso], [Idmucthu]) VALUES (N'L010', N'5B', 30, N'MT004')
INSERT [dbo].[MucThu] ([Idmucthu], [Sotien], [Ngayapdung], [Namhoc]) VALUES (N'MT001', 3500000, CAST(0x6E390B00 AS Date), N'2015-2016')
INSERT [dbo].[MucThu] ([Idmucthu], [Sotien], [Ngayapdung], [Namhoc]) VALUES (N'MT002', 3000000, CAST(0x94360B00 AS Date), N'2013-2014')
INSERT [dbo].[MucThu] ([Idmucthu], [Sotien], [Ngayapdung], [Namhoc]) VALUES (N'MT003', 3150000, CAST(0x01380B00 AS Date), N'2014-2014')
INSERT [dbo].[MucThu] ([Idmucthu], [Sotien], [Ngayapdung], [Namhoc]) VALUES (N'MT004', 2500000, CAST(0x4C320B00 AS Date), N'2010-2011')
INSERT [dbo].[MucThu] ([Idmucthu], [Sotien], [Ngayapdung], [Namhoc]) VALUES (N'MT005', 4000000, CAST(0x493C0B00 AS Date), N'2017-2018')
INSERT [dbo].[TheoDoiLichAn] ([Idphieu], [Thangnam], [Songaynghi], [Ghichu], [Idhocsinh]) VALUES (N'P001', CAST(0xF03D0B00 AS Date), 1, N'Nghỉ ngày: 14', N'HS001')
INSERT [dbo].[TheoDoiLichAn] ([Idphieu], [Thangnam], [Songaynghi], [Ghichu], [Idhocsinh]) VALUES (N'P002', CAST(0xD43D0B00 AS Date), NULL, NULL, N'HS002')
INSERT [dbo].[TheoDoiLichAn] ([Idphieu], [Thangnam], [Songaynghi], [Ghichu], [Idhocsinh]) VALUES (N'P003', CAST(0x0F3E0B00 AS Date), 5, N'Nghỉ ngày: 5,11,15,23,37', N'HS006')
INSERT [dbo].[TheoDoiLichAn] ([Idphieu], [Thangnam], [Songaynghi], [Ghichu], [Idhocsinh]) VALUES (N'P004', CAST(0x2D3E0B00 AS Date), 2, N'Nghỉ ngày:20', N'HS020')
INSERT [dbo].[TheoDoiLichAn] ([Idphieu], [Thangnam], [Songaynghi], [Ghichu], [Idhocsinh]) VALUES (N'P005', CAST(0x4C3E0B00 AS Date), NULL, NULL, N'HS009')
ALTER TABLE [dbo].[BienLai]  WITH CHECK ADD  CONSTRAINT [FK_BienLai_HocSinh] FOREIGN KEY([Idhocsinh])
REFERENCES [dbo].[HocSinh] ([Idhocsinh])
GO
ALTER TABLE [dbo].[BienLai] CHECK CONSTRAINT [FK_BienLai_HocSinh]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_DoiTuongMienGiam] FOREIGN KEY([Iddoituong])
REFERENCES [dbo].[DoiTuongMienGiam] ([Iddoituong])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_DoiTuongMienGiam]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_Lop] FOREIGN KEY([Idlop])
REFERENCES [dbo].[Lop] ([Idlop])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_Lop]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_MucThu1] FOREIGN KEY([Idmucthu])
REFERENCES [dbo].[MucThu] ([Idmucthu])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_MucThu1]
GO
ALTER TABLE [dbo].[TheoDoiLichAn]  WITH CHECK ADD  CONSTRAINT [FK_TheoDoiLichAn_HocSinh] FOREIGN KEY([Idhocsinh])
REFERENCES [dbo].[HocSinh] ([Idhocsinh])
GO
ALTER TABLE [dbo].[TheoDoiLichAn] CHECK CONSTRAINT [FK_TheoDoiLichAn_HocSinh]
GO
USE [master]
GO
ALTER DATABASE [Buiminhhieu_Qlthuhocphi_17] SET  READ_WRITE 
GO


-------------DTMG------------------------
create proc them_doituong (@ma varchar(10), @ten nvarchar(50), @miengiam int)
as
begin
insert into DoiTuongMienGiam(Iddoituong, Tendoituong, Mucmiengiam)
values(@ma,@ten,@miengiam)
end

create proc sua_doituong (@ma varchar(10), @ten nvarchar(50), @miengiam int)
as
begin
update DoiTuongMienGiam
set Tendoituong= @ten,
Mucmiengiam =@miengiam
where  Iddoituong=@ma
end

create proc xoa_doituong (@ma varchar(10))
as
begin
delete DoiTuongMienGiam
where Iddoituong = @ma
end

---------------------muc thu-------------------
create proc them_mucthu (@ma varchar(10), @sotien int, @ngayapdung date, @namhoc nvarchar(50))
as
begin
insert into MucThu(Idmucthu, Sotien, Ngayapdung, Namhoc)
values(@ma,@sotien,@ngayapdung,@namhoc)
end

create proc sua_mucthu (@ma varchar(10), @sotien int, @ngayapdung date, @namhoc nvarchar(50))
as
begin
update MucThu
set Sotien= @sotien,
Ngayapdung =@ngayapdung,
Namhoc = @namhoc
where  Idmucthu=@ma
end

create proc xoa_mucthu (@ma varchar(10))
as
begin
delete MucThu
where Idmucthu = @ma
end

------------------- HOC SINH------------------
create proc them_hocsinh (@ma varchar(10),@ten nvarchar(50), @ns date, @gt nvarchar(50), @dc nvarchar(50),  @madt varchar(10), @mal varchar(10), @bantru nvarchar(50))
as
begin
insert into HocSinh(Idhocsinh, Tenhocsinh, NS, GT, DC, Iddoituong, Idlop, Bantru)
values(@ma,@ten,@ns, @gt, @dc, @madt, @mal, @bantru)
end

CREATE PROC sua_hocsinh (@ma varchar(10),@ten nvarchar(50), @ns date, @gt nvarchar(50), @dc nvarchar(50),  @madt varchar(10), @mal varchar(10), @bantru nvarchar(50))
as
begin
update hocsinh
set Tenhocsinh= @ten,
NS= @ns,
GT= @gt,
DC = @dc,
Iddoituong= @madt,
Idlop=  @mal,
Bantru = @bantru
where Idhocsinh=@ma
end

create proc xoa_hocsinh (@ma varchar(10))
as
begin
delete HocSinh 
where Idhocsinh = @ma
end

------------ lớp-------------
create proc them_lop (@ma varchar(10), @ten nvarchar(50), @siso int, @mamt varchar(10))
as
begin
insert into Lop(Idlop, Tenlop, Siso, Idmucthu)
values(@ma,@ten,@siso, @mamt )
end

create proc sua_lop (@ma varchar(10), @ten nvarchar(50), @siso int, @mamt varchar(10))
as
begin
update Lop
set Tenlop= @ten,
Siso =@siso,
Idmucthu = @mamt
where  Idlop=@ma
end

create proc xoa_lop (@ma varchar(10))
as
begin
delete Lop
where Idlop = @ma
end

-------------theo doi lich an--------------
create proc them_theodoilichan (@ma varchar(10), @thangnam date, @songaynghi int, @ghichu nvarchar(50), @mahs varchar(10))
as
begin
insert into TheoDoiLichAn(Idphieu, Thangnam, Songaynghi, Ghichu, Idhocsinh)
values(@ma,@thangnam, @songaynghi, @ghichu, @mahs )
end

alter proc sua_theodoilichan(@ma varchar(10), @songaynghi int, @ghichu nvarchar(50))
as
begin
update TheoDoiLichAn
set 
Songaynghi =@songaynghi,
Ghichu = @ghichu

where  Idphieu=@ma
end
create proc xoa_theodoilichan (@ma varchar(10))
as
begin
delete TheoDoiLichAn
where Idphieu = @ma
end

---- triger bien lai ban tru---------
alter trigger thembienlai
on BienLai
instead of insert 
as
begin
declare @Idbienlai varchar(10)
declare @Thangnam date
declare @Nguoithu nvarchar(50)
declare @Bantru int
declare @Tienan int
declare @Sotiennop int 
declare @Tongtien int
declare @Idhocsinh varchar(10)
declare @Songaynghi int
declare @Idlop varchar(10)
declare @Idmucthu varchar(10)
declare @Sotien int
declare @Iddoituong varchar(10)
declare @Mucmiengiam int

select @Idbienlai = idbienlai from inserted
select @Thangnam = thangnam from inserted
select @Nguoithu = nguoithu from inserted
select @Idhocsinh = idhocsinh from inserted
select @Bantru = Bantru from HocSinh where Idhocsinh = @Idhocsinh
select @Songaynghi = Songaynghi from TheoDoiLichAn where Idhocsinh = @Idhocsinh 
select @Idlop = Idlop from HocSinh where Idhocsinh = @Idhocsinh
select @Idmucthu = Idmucthu from Lop where Idlop = @Idlop
select @Sotien = Sotien from MucThu where Idmucthu =  @Idmucthu
select @Iddoituong = Iddoituong from HocSinh where Idhocsinh = @Idhocsinh
select @Mucmiengiam = Mucmiengiam from DoiTuongMienGiam where Iddoituong = @Iddoituong
select @Sotiennop = @Sotien - @Mucmiengiam
if(@Bantru = 1)
begin
SET  @Tienan = (20 - @Songaynghi) * 20000
SET  @Tongtien = @Tienan  + @Sotiennop
end
else 
begin
SET  @Tongtien = @Sotiennop
end
begin 
insert into BienLai
values(@Idbienlai, @Thangnam, @Nguoithu, @Bantru, @Tienan, @Sotiennop, @Tongtien,@Idhocsinh)
end 
end

-----------thu tuc bien lai----------------
alter proc them_bienlai (@ma varchar(10), @thangnam date, @nguoithu nvarchar(50),  @idhocsinh varchar(10))
as
begin
insert into BienLai(Idbienlai, Thangnam, Nguoithu, Idhocsinh)
values(@ma, @thangnam, @nguoithu,  @idhocsinh)
end
them_bienlai 'BL032' , '02/21/2012',N'Nguyen thi thu' , 'HS005'
them_bienlai 'BL033','02/28/1997',N'abc','HS001'
them_bienlai 'BL034','02/28/1997',N'abc','HS001'
them_bienlai 'BL035','02/28/1997',N'abc','HS001'
them_bienlai 'BL036','02/28/1997',N'abc','HS001'
them_bienlai 'BL037','02/28/1997',N'abc','HS001'
select * from BienLai



--nếu học sinh đã in biên lai của tháng đps rồi thì không cho in nữa. theo dõi theo idhoc sinh và theo doi theo  thang nam