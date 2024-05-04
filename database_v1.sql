USE [database_v1]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 04/05/2024 18:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[MaSoGiangVien] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[MatKhau] [varchar](100) NOT NULL,
	[HoVaTen] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[HocHam] [nvarchar](50) NOT NULL,
	[SoDienThoai] [varchar](20) NOT NULL,
	[CCCD] [varchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSoGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopDay]    Script Date: 04/05/2024 18:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopDay](
	[MaLopDay] [int] NOT NULL,
	[SoBuoiDay] [int] NOT NULL,
	[Nhom] [varchar](10) NOT NULL,
	[ToTH] [varchar](10) NOT NULL,
	[MaSoGiangVien] [varchar](100) NOT NULL,
	[MaSoMonHoc] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLopDay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopDay_NgayDay]    Script Date: 04/05/2024 18:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopDay_NgayDay](
	[NgayDay] [date] NOT NULL,
	[MaLopDay] [int] NOT NULL,
	[CaDay] [int] NULL,
	[Phong] [varchar](10) NULL,
	[TrangThai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[NgayDay] ASC,
	[MaLopDay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 04/05/2024 18:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaSoMonHoc] [varchar](100) NOT NULL,
	[TenMonHoc] [nvarchar](100) NOT NULL,
	[SoTinChi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSoMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanTriVien]    Script Date: 04/05/2024 18:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanTriVien](
	[TenDangNhap] [varchar](100) NOT NULL,
	[MatKhau] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 04/05/2024 18:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSoSinhVien] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[MatKhau] [varchar](100) NOT NULL,
	[HoVaTen] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[SoDienThoai] [varchar](100) NOT NULL,
	[CCCD] [varchar](100) NOT NULL,
	[ChuyenNganh] [nvarchar](100) NOT NULL,
	[KhoaTuyenSinh] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSoSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien_LopDay]    Script Date: 04/05/2024 18:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien_LopDay](
	[MaLopDay] [int] NOT NULL,
	[MaSoSinhVien] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLopDay] ASC,
	[MaSoSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongBao]    Script Date: 04/05/2024 18:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongBao](
	[NoiDung] [nvarchar](1000) NOT NULL,
	[ThoiGianGui] [date] NOT NULL,
	[TieuDe] [nvarchar](100) NOT NULL,
	[MaThongBao] [int] NOT NULL,
	[TenDangNhap] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThongBao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongBao_GiangVien]    Script Date: 04/05/2024 18:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongBao_GiangVien](
	[MaThongBao] [int] NOT NULL,
	[MaSoGiangVien] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThongBao] ASC,
	[MaSoGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongBao_SinhVien]    Script Date: 04/05/2024 18:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongBao_SinhVien](
	[MaThongBao] [int] NOT NULL,
	[MaSoSinhVien] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThongBao] ASC,
	[MaSoSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YeuCauBaoBu]    Script Date: 04/05/2024 18:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuCauBaoBu](
	[NgayBaoBu] [date] NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
	[MaBaoBu] [int] NOT NULL,
	[MaBaoVang] [int] NOT NULL,
	[MaLopDay] [int] NOT NULL,
	[MaSoGiangVien] [varchar](100) NOT NULL,
	[CaBu] [int] NULL,
	[PhongBu] [varchar](10) NULL,
	[LoiNhan] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBaoBu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YeuCauBaoVang]    Script Date: 04/05/2024 18:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuCauBaoVang](
	[NgayBaoVang] [date] NOT NULL,
	[LyDoBaoVang] [nvarchar](500) NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
	[MaBaoVang] [int] NOT NULL,
	[MaSoGiangVien] [varchar](100) NOT NULL,
	[MaLopDay] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBaoVang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[GiangVien] ([MaSoGiangVien], [Email], [MatKhau], [HoVaTen], [NgaySinh], [GioiTinh], [HocHam], [SoDienThoai], [CCCD], [DiaChi]) VALUES (N'FIT001', N'tranthanhphuoc@tdtu.edu.vn', N'TranThanhPhuoc123', N'Trần Thanh Phước', CAST(N'1999-01-01' AS Date), N'Nam', N'TS', N'0764186912', N'079203034187', N'C119 TDTU')
GO
INSERT [dbo].[LopDay] ([MaLopDay], [SoBuoiDay], [Nhom], [ToTH], [MaSoGiangVien], [MaSoMonHoc]) VALUES (1, 15, N'N05', N'T05', N'FIT001', N'502045')
GO
INSERT [dbo].[LopDay_NgayDay] ([NgayDay], [MaLopDay], [CaDay], [Phong], [TrangThai]) VALUES (CAST(N'2024-04-23' AS Date), 1, 1, N'B203', N'ĐANG HIỆU LỰC')
INSERT [dbo].[LopDay_NgayDay] ([NgayDay], [MaLopDay], [CaDay], [Phong], [TrangThai]) VALUES (CAST(N'2024-04-25' AS Date), 1, 2, N'B203', N'VẮNG')
INSERT [dbo].[LopDay_NgayDay] ([NgayDay], [MaLopDay], [CaDay], [Phong], [TrangThai]) VALUES (CAST(N'2024-05-04' AS Date), 1, 2, N'B303', N'BÙ')
GO
INSERT [dbo].[MonHoc] ([MaSoMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'502045', N'Công nghệ phần mềm', 4)
INSERT [dbo].[MonHoc] ([MaSoMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'504046', N'Nhập môn xử lý ngôn ngữ tự nhiên', 3)
INSERT [dbo].[MonHoc] ([MaSoMonHoc], [TenMonHoc], [SoTinChi]) VALUES (N'505047', N'Khai thác dữ liệu và Khai phá trí thức', 4)
GO
INSERT [dbo].[QuanTriVien] ([TenDangNhap], [MatKhau]) VALUES (N'admin', N'admin')
GO
INSERT [dbo].[SinhVien] ([MaSoSinhVien], [Email], [MatKhau], [HoVaTen], [NgaySinh], [GioiTinh], [SoDienThoai], [CCCD], [ChuyenNganh], [KhoaTuyenSinh]) VALUES (N'52100987', N'52100987@student.tdtu.edu.vn', N'52100987', N'Đặng Minh Phong', CAST(N'2003-10-26' AS Date), N'Nam', N'0764186912', N'070707070707', N'Mạng máy tính và Truyền thông dữ liệu', N'2021')
INSERT [dbo].[SinhVien] ([MaSoSinhVien], [Email], [MatKhau], [HoVaTen], [NgaySinh], [GioiTinh], [SoDienThoai], [CCCD], [ChuyenNganh], [KhoaTuyenSinh]) VALUES (N'52100988', N'52100988@gmail.com', N'Phong1', N'Phony', CAST(N'2024-04-25' AS Date), N'Nữ', N'0123123123', N'090019209310', N'Khoa học máy tính', N'2021')
GO
INSERT [dbo].[SinhVien_LopDay] ([MaLopDay], [MaSoSinhVien]) VALUES (1, N'52100987')
INSERT [dbo].[SinhVien_LopDay] ([MaLopDay], [MaSoSinhVien]) VALUES (1, N'52100988')
GO
INSERT [dbo].[ThongBao] ([NoiDung], [ThoiGianGui], [TieuDe], [MaThongBao], [TenDangNhap]) VALUES (N'Yêu cầu được chấp thuận', CAST(N'2024-05-02' AS Date), N'DUYỆT YÊU CẦU', 1, N'admin')
INSERT [dbo].[ThongBao] ([NoiDung], [ThoiGianGui], [TieuDe], [MaThongBao], [TenDangNhap]) VALUES (N'Ngày này vắng nhé các em', CAST(N'2024-05-02' AS Date), N'BÁO VẮNG', 2, N'admin')
INSERT [dbo].[ThongBao] ([NoiDung], [ThoiGianGui], [TieuDe], [MaThongBao], [TenDangNhap]) VALUES (N'YÊU CẦU ĐƯỢC DUYỆT', CAST(N'2024-05-03' AS Date), N'XÉT DUYỆT YÊU CẦU', 3, N'admin')
INSERT [dbo].[ThongBao] ([NoiDung], [ThoiGianGui], [TieuDe], [MaThongBao], [TenDangNhap]) VALUES (N'NGÀY NÀY VẮNG', CAST(N'2024-05-03' AS Date), N'BÁO VẮNG', 4, N'admin')
INSERT [dbo].[ThongBao] ([NoiDung], [ThoiGianGui], [TieuDe], [MaThongBao], [TenDangNhap]) VALUES (N'ádad', CAST(N'2024-05-03' AS Date), N'ádas', 5, N'admin')
INSERT [dbo].[ThongBao] ([NoiDung], [ThoiGianGui], [TieuDe], [MaThongBao], [TenDangNhap]) VALUES (N'ádasd', CAST(N'2024-05-03' AS Date), N'đấ', 6, N'admin')
INSERT [dbo].[ThongBao] ([NoiDung], [ThoiGianGui], [TieuDe], [MaThongBao], [TenDangNhap]) VALUES (N'ádasd', CAST(N'2024-05-03' AS Date), N'ádasd', 7, N'admin')
INSERT [dbo].[ThongBao] ([NoiDung], [ThoiGianGui], [TieuDe], [MaThongBao], [TenDangNhap]) VALUES (N'YÊU CẦU BÁO BÙ ĐƯỢC CHẤP THUẬN
Môn: (502045) Công nghệ phần mềm
Ngày bù: 04/05/2024 00:00:00
Ca bù: 2
Nhóm: N05, Tổ: T05', CAST(N'2024-05-04' AS Date), N'DUYỆT YÊU CẦU BÁO BÙ', 8, N'admin')
INSERT [dbo].[ThongBao] ([NoiDung], [ThoiGianGui], [TieuDe], [MaThongBao], [TenDangNhap]) VALUES (N'Giảng viên: Trần Thanh Phước
Môn: (502045) Công nghệ phần mềm
Ngày vắng: 25/04/2024 00:00:00
Ngày bù: 04/05/2024 00:00:00
Ca bù: 2
Nhóm: N05, Tổ: T05
Lời nhắn từ giảng viên: Bù ngày này các em nhé <3', CAST(N'2024-05-04' AS Date), N'THÔNG BÁO LỊCH HỌC BÙ', 9, N'admin')
GO
INSERT [dbo].[ThongBao_GiangVien] ([MaThongBao], [MaSoGiangVien]) VALUES (1, N'FIT001')
INSERT [dbo].[ThongBao_GiangVien] ([MaThongBao], [MaSoGiangVien]) VALUES (3, N'FIT001')
INSERT [dbo].[ThongBao_GiangVien] ([MaThongBao], [MaSoGiangVien]) VALUES (5, N'FIT001')
INSERT [dbo].[ThongBao_GiangVien] ([MaThongBao], [MaSoGiangVien]) VALUES (6, N'FIT001')
INSERT [dbo].[ThongBao_GiangVien] ([MaThongBao], [MaSoGiangVien]) VALUES (8, N'FIT001')
GO
INSERT [dbo].[ThongBao_SinhVien] ([MaThongBao], [MaSoSinhVien]) VALUES (2, N'52100987')
INSERT [dbo].[ThongBao_SinhVien] ([MaThongBao], [MaSoSinhVien]) VALUES (2, N'52100988')
INSERT [dbo].[ThongBao_SinhVien] ([MaThongBao], [MaSoSinhVien]) VALUES (4, N'52100987')
INSERT [dbo].[ThongBao_SinhVien] ([MaThongBao], [MaSoSinhVien]) VALUES (4, N'52100988')
INSERT [dbo].[ThongBao_SinhVien] ([MaThongBao], [MaSoSinhVien]) VALUES (7, N'52100987')
INSERT [dbo].[ThongBao_SinhVien] ([MaThongBao], [MaSoSinhVien]) VALUES (7, N'52100988')
INSERT [dbo].[ThongBao_SinhVien] ([MaThongBao], [MaSoSinhVien]) VALUES (9, N'52100987')
INSERT [dbo].[ThongBao_SinhVien] ([MaThongBao], [MaSoSinhVien]) VALUES (9, N'52100988')
GO
INSERT [dbo].[YeuCauBaoBu] ([NgayBaoBu], [TrangThai], [MaBaoBu], [MaBaoVang], [MaLopDay], [MaSoGiangVien], [CaBu], [PhongBu], [LoiNhan]) VALUES (CAST(N'2024-05-04' AS Date), N'CHẤP NHẬN', 1, 2, 1, N'FIT001', 2, N'B303', N'Bù ngày này các em nhé <3')
GO
INSERT [dbo].[YeuCauBaoVang] ([NgayBaoVang], [LyDoBaoVang], [TrangThai], [MaBaoVang], [MaSoGiangVien], [MaLopDay]) VALUES (CAST(N'2024-04-23' AS Date), N'Mệt', N'CHƯA XỬ LÝ', 1, N'FIT001', 1)
INSERT [dbo].[YeuCauBaoVang] ([NgayBaoVang], [LyDoBaoVang], [TrangThai], [MaBaoVang], [MaSoGiangVien], [MaLopDay]) VALUES (CAST(N'2024-04-25' AS Date), N'Mệt quá', N'CHẤP NHẬN', 2, N'FIT001', 1)
GO
ALTER TABLE [dbo].[LopDay]  WITH CHECK ADD FOREIGN KEY([MaSoGiangVien])
REFERENCES [dbo].[GiangVien] ([MaSoGiangVien])
GO
ALTER TABLE [dbo].[LopDay]  WITH CHECK ADD FOREIGN KEY([MaSoMonHoc])
REFERENCES [dbo].[MonHoc] ([MaSoMonHoc])
GO
ALTER TABLE [dbo].[LopDay_NgayDay]  WITH CHECK ADD FOREIGN KEY([MaLopDay])
REFERENCES [dbo].[LopDay] ([MaLopDay])
GO
ALTER TABLE [dbo].[SinhVien_LopDay]  WITH CHECK ADD FOREIGN KEY([MaLopDay])
REFERENCES [dbo].[LopDay] ([MaLopDay])
GO
ALTER TABLE [dbo].[SinhVien_LopDay]  WITH CHECK ADD FOREIGN KEY([MaSoSinhVien])
REFERENCES [dbo].[SinhVien] ([MaSoSinhVien])
GO
ALTER TABLE [dbo].[ThongBao]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[QuanTriVien] ([TenDangNhap])
GO
ALTER TABLE [dbo].[ThongBao_GiangVien]  WITH CHECK ADD FOREIGN KEY([MaSoGiangVien])
REFERENCES [dbo].[GiangVien] ([MaSoGiangVien])
GO
ALTER TABLE [dbo].[ThongBao_GiangVien]  WITH CHECK ADD FOREIGN KEY([MaThongBao])
REFERENCES [dbo].[ThongBao] ([MaThongBao])
GO
ALTER TABLE [dbo].[ThongBao_SinhVien]  WITH CHECK ADD FOREIGN KEY([MaSoSinhVien])
REFERENCES [dbo].[SinhVien] ([MaSoSinhVien])
GO
ALTER TABLE [dbo].[ThongBao_SinhVien]  WITH CHECK ADD FOREIGN KEY([MaThongBao])
REFERENCES [dbo].[ThongBao] ([MaThongBao])
GO
ALTER TABLE [dbo].[YeuCauBaoBu]  WITH CHECK ADD FOREIGN KEY([MaBaoVang])
REFERENCES [dbo].[YeuCauBaoVang] ([MaBaoVang])
GO
ALTER TABLE [dbo].[YeuCauBaoBu]  WITH CHECK ADD FOREIGN KEY([MaLopDay])
REFERENCES [dbo].[LopDay] ([MaLopDay])
GO
ALTER TABLE [dbo].[YeuCauBaoBu]  WITH CHECK ADD FOREIGN KEY([MaSoGiangVien])
REFERENCES [dbo].[GiangVien] ([MaSoGiangVien])
GO
ALTER TABLE [dbo].[YeuCauBaoVang]  WITH CHECK ADD FOREIGN KEY([MaSoGiangVien])
REFERENCES [dbo].[GiangVien] ([MaSoGiangVien])
GO
ALTER TABLE [dbo].[YeuCauBaoVang]  WITH CHECK ADD  CONSTRAINT [FK_YeuCauBaoVang_LopDay] FOREIGN KEY([MaLopDay])
REFERENCES [dbo].[LopDay] ([MaLopDay])
GO
ALTER TABLE [dbo].[YeuCauBaoVang] CHECK CONSTRAINT [FK_YeuCauBaoVang_LopDay]
GO
