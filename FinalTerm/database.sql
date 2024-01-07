USE [database]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 07/01/2024 13:27:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [varchar](10) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
	[NgayTao] [date] NOT NULL,
	[SoDienThoai] [nvarchar](50) NOT NULL,
	[Tuoi] [int] NOT NULL,
	[GioiTinh] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ThemTaiKhoan]    Script Date: 07/01/2024 13:27:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemTaiKhoan]
    @TenDangNhap VARCHAR(10),
	@MatKhau VARCHAR(50),
	@TenNhanVien NVARCHAR(50),
	@ChucVu NVARCHAR(50),
	@SoDienThoai NVARCHAR(50),
	@Tuoi INT,
	@GioiTinh NVARCHAR(50),
	@NgaySinh DATE
AS
BEGIN
    INSERT INTO TaiKhoan (TenDangNhap, MatKhau, TenNhanVien, ChucVu, NgayTao, SoDienThoai, Tuoi, GioiTinh, NgaySinh)
    VALUES (@TenDangNhap, @MatKhau, @TenNhanVien, @ChucVu, GETDATE(), @SoDienThoai, @Tuoi, @GioiTinh, @NgaySinh)
END
GO
