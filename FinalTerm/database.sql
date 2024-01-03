USE [database]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 03/01/2024 20:26:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nchar](10) NOT NULL,
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[ChucVu] [nvarchar](50) NULL,
	[NgayGiaNhap] [date] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ThemNhanVien]    Script Date: 03/01/2024 20:26:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemNhanVien]
    @TenDangNhap NVARCHAR(50),
    @TenNhanVien NVARCHAR(50),
	@MatKhau NVARCHAR(50),
	@ChucVu NVARCHAR(50)
AS
BEGIN
    DECLARE @MaxMaNhanVien NVARCHAR(10)

    SELECT @MaxMaNhanVien = MAX(MaNhanVien)
    FROM NhanVien

    IF @MaxMaNhanVien IS NULL
        SET @MaxMaNhanVien = 'NV00000000'

    DECLARE @So INT
    SET @So = CAST(SUBSTRING(@MaxMaNhanVien, 3, LEN(@MaxMaNhanVien)) AS INT) + 1
    DECLARE @MaMoi NVARCHAR(10)
    SET @MaMoi = 'NV' + RIGHT('00000000' + CAST(@So AS NVARCHAR(8)), 8)

    INSERT INTO NhanVien (MaNhanVien, TenNhanVien, TenDangNhap, MatKhau, ChucVu, NgayGiaNhap)
    VALUES (@MaMoi, @TenNhanVien, @TenDangNhap, @MatKhau, @ChucVu, GETDATE())
END
GO
