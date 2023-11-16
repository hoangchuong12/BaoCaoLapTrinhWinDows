CREATE DATABASE QLdoannhanh	
use QLdoannhanh	
/*Table SinhVien*/
CREATE TABLE TaiKhoan
(
	[Email] NCHAR(100) NOT NULL PRIMARY KEY, 
    [taiKhoan] NVARCHAR(100) NOT NULL, 
	[MatKhau] NVARCHAR(200) NOT NULL
)
GO
CREATE TABLE BanAn (
    MaBanAn INT IDENTITY(1,1) PRIMARY KEY,
    TenBanAn NVARCHAR(255) NOT NULL
);
GO
-- Tạo bảng LoaiThucAn
CREATE TABLE LoaiThucAn (
    MaLoaiThucAn INT IDENTITY(1,1) PRIMARY KEY,
    TenLoaiThucAn NVARCHAR(255) NOT NULL
);
GO
-- Tạo bảng ThucAn
CREATE TABLE ThucAn (
    MaThucAn INT IDENTITY(1,1) PRIMARY KEY,
    MaLoaiThucAn INT FOREIGN KEY REFERENCES LoaiThucAn(MaLoaiThucAn),
    TenThucAn NVARCHAR(255) NOT NULL,
    GiaThucAn DECIMAL(10,2) NOT NULL
);
GO
-- Tạo bảng HoaDon
CREATE TABLE HoaDon (
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    NgayTao DATE NOT NULL,
    NgayKetThuc DATE,
    MaBanAn INT FOREIGN KEY REFERENCES BanAn(MaBanAn),
    TongTien DECIMAL(10,2) NOT NULL
);
Go
ALTER TABLE HoaDon
ADD IsPaid bit NOT NULL DEFAULT 0;
GO
-- Tạo bảng ChiTietHoaDon
CREATE TABLE ChiTietHoaDon (
    MaChiTietHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    MaHoaDon INT FOREIGN KEY REFERENCES HoaDon(MaHoaDon),
    MaThucAn INT FOREIGN KEY REFERENCES ThucAn(MaThucAn),
    DonGia DECIMAL(10,2) NOT NULL,
    SoLuong INT NOT NULL,
    ThanhTien DECIMAL(10,2) NOT NULL
);
GO
/*--------------*/
/*ALTER TABLE SinhVien ADD CONSTRAINT FK_SinhVien_Khoa FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)*/

Go
INSERT INTO TaiKhoan VALUES(N'chuong1207@gmail.com',N'chuong1207',N'chuong')
INSERT INTO TaiKhoan VALUES(N'chuong10c6@gmail.com',N'chuong10c6',N'chuong')
GO
INSERT INTO BanAn (TenBanAn) VALUES
('Ban 4'),
('Ban 5'),
('Ban 6');
GO

-- Thêm dữ liệu mẫu cho bảng LoaiThucAn
INSERT INTO LoaiThucAn (TenLoaiThucAn) VALUES
('Mi Cay'),
('Nuoc Uong');
GO

-- Thêm dữ liệu mẫu cho bảng ThucAn
INSERT INTO ThucAn (MaLoaiThucAn, TenThucAn, GiaThucAn) VALUES
(1, 'Mi Cay Hai San', 40000),
(1, 'Mi Cay Bo', 45000),
(1, 'Mi Cay Dui Ga', 45000),
(1, 'Mi Cay Thap Cam', 55000),
(2, 'Coca Cola', 15000),
(2, 'Pepsi', 15000),
(2, 'Sting', 15000);
GO

-- Thêm dữ liệu mẫu cho bảng HoaDon
INSERT INTO HoaDon (NgayTao, NgayKetThuc, MaBanAn, TongTien) VALUES
('2023-10-24', NULL, 1, 0),
('2023-10-23', '2023-10-23', 2, 85000);
GO

-- Thêm dữ liệu mẫu cho bảng ChiTietHoaDon
INSERT INTO ChiTietHoaDon (MaHoaDon, MaThucAn, DonGia, SoLuong, ThanhTien) VALUES
(1, 1, 40000, 1, 40000),
(1, 2, 45000, 1, 45000),
(2, 3, 15000, 2, 30000),
(2, 4, 30000, 1, 30000);
GO
SELECT *FROM TaiKhoan
SELECT *FROM ChiTietHoaDon
SELECT *FROM HoaDon
SELECT *FROM ThucAn
SELECT *FROM LoaiThucAn
SELECT *FROM BanAn

