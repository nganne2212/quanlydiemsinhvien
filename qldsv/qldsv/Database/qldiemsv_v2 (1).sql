USE master
GO

DROP DATABASE IF EXISTS qldiemsv
GO

CREATE DATABASE qldiemsv
GO

USE qldiemsv
GO

CREATE TABLE [NguoiDung] (
  [MaNguoiDung] int IDENTITY(1,1) PRIMARY KEY,
  [TenDangNhap] nvarchar(50) NOT NULL,
  [MatKhau] nvarchar(255) NOT NULL,
  [VaiTro] nvarchar(20) NOT NULL,
  [TrangThai] nvarchar(20) NOT NULL
)
GO

CREATE TABLE [Khoa] (
  [MaKhoa] varchar(10) PRIMARY KEY,
  [TenKhoa] nvarchar(100) NOT NULL
)
GO

CREATE TABLE [GiangVien] (
  [MaGiangVien] varchar(20) PRIMARY KEY,
  [HoTen] nvarchar(100) NOT NULL,
  [Email] nvarchar(100) NOT NULL,
  [MaKhoa] varchar(10) NOT NULL,
  [MaNguoiDung] int NOT NULL
)
GO

CREATE TABLE [Lop] (
  [MaLop] varchar(20) PRIMARY KEY,
  [TenLop] nvarchar(50) NOT NULL,
  [MaKhoa] varchar(10) NOT NULL,
  [MaGiangVien] varchar(20) NULL
)
GO

CREATE TABLE [SinhVien] (
  [MaSinhVien] varchar(20) PRIMARY KEY,
  [HoTen] nvarchar(100) NOT NULL,
  [NgaySinh] date NULL,
  [GioiTinh] nvarchar(5) NOT NULL,
  [Email] nvarchar(100) NULL,
  [SoDienThoai] nvarchar(15) NULL,
  [Trangthai] nvarchar(20) NOT NULL,
  [MaLop] varchar(20) NOT NULL,
  [MaNguoiDung] int NOT NULL
)
GO

CREATE TABLE [MonHoc] (
  [MaMonHoc] varchar(20) PRIMARY KEY,
  [TenMon] nvarchar(100) NOT NULL,
  [SoTinChi] int NOT NULL,
  [HeSoChuyenCan] float NOT NULL,
  [HeSoKT1] float NOT NULL,
  [HeSoKT2] float NOT NULL,
  [HeSoCuoiKy] float NOT NULL
)
GO

CREATE TABLE [HocKy] (
  [MaHocKy] int IDENTITY(1,1) PRIMARY KEY,
  [TenHocKy] nvarchar(20) NOT NULL,
  [NamHoc] nvarchar(20) NOT NULL,
  [Trangthai] nvarchar(20) NOT NULL
)
GO

CREATE TABLE [LopHocPhan] (
  [MaLHP] varchar(20) PRIMARY KEY,
  [MaMonHoc] varchar(20) NOT NULL,
  [MaGiangVien] varchar(20) NOT NULL,
  [MaHocKy] int NOT NULL,
  [NgayBatDau] date NOT NULL,
  [NgayKetThuc] date NOT NULL
)
GO

CREATE TABLE [DangKyHP] (
  [MaDangKy] int IDENTITY(1,1) PRIMARY KEY,
  [MaSinhVien] varchar(20) NOT NULL,
  [MaLHP] varchar(20) NOT NULL,
  [NgayDangKy] date NOT NULL
)
GO

CREATE TABLE [Diem] (
  [MaDiem] int IDENTITY(1,1) PRIMARY KEY,
  [MaDangKy] int NOT NULL,
  [ChuyenCan] float NULL,
  [Kiemtra1] float NULL,
  [Kiemtra2] float NULL,
  [CuoiKy] float NULL,
  [TongKet] float NULL,
  [TrangThai] nvarchar(20) NOT NULL,
  [LanHoc] int NOT NULL,
  [Loaihoc] nvarchar(20) NOT NULL,
  [NguonGoc] nvarchar(20) NOT NULL
)
GO

CREATE TABLE [PhucKhao] (
  [MaPhucKhao] int IDENTITY(1,1) PRIMARY KEY,
  [MaDangKy] int NOT NULL,
  [LyDo] nvarchar(255) NOT NULL,
  [NgayGui] date NOT NULL,
  [TrangThai] nvarchar(20) NOT NULL
)
GO

CREATE TABLE [KetQuaPhucKhao] (
  [MaKetQua] int IDENTITY(1,1) PRIMARY KEY,
  [MaPhucKhao] int NOT NULL,
  [MaGiangVien] varchar(20) NOT NULL,
  [DiemCu] float NOT NULL,
  [DiemMoi] float NOT NULL,
  [NhanXet] nvarchar(255) NULL,
  [NgayXuLy] date NOT NULL,
  [KetLuan] nvarchar(20) NOT NULL
)
GO

CREATE TABLE [CanhBaoHocVu] (
  [MaCanhBao] int IDENTITY(1,1) PRIMARY KEY,
  [MaSinhVien] varchar(20) NOT NULL,
  [MaHocKy] int NOT NULL,
  [SoKyDaBiCB] int NOT NULL,
  [DiemHK] float NOT NULL,
  [TBTL] float NOT NULL,
  [TCTL] float NOT NULL,
  [LyDo] nvarchar(200) NOT NULL,
  [MucCanhBao] nvarchar(20) NOT NULL,
  [TrangThai] nvarchar(20) NOT NULL
)
GO

CREATE TABLE [PhongHoc] (
  [MaPhong] int IDENTITY(1,1) PRIMARY KEY,
  [TenPhong] nvarchar(50) NOT NULL
)
GO

CREATE TABLE [LichHoc] (
  [MaLHP] varchar(20) NOT NULL,
  [MaPhong] int NOT NULL,
  [Thu] int NOT NULL,
  [CaHoc] int NOT NULL,
  PRIMARY KEY ([MaLHP], [Thu], [CaHoc])
)
GO

-- UNIQUE INDEX
CREATE UNIQUE INDEX [UQ_DangKyHP] ON [DangKyHP] (MaSinhVien, MaLHP)
GO
CREATE UNIQUE INDEX [UQ_LichHoc] ON [LichHoc] (MaPhong, Thu, CaHoc)
GO

-- FOREIGN KEYS
ALTER TABLE [GiangVien] ADD CONSTRAINT FK_GiangVien_Khoa
  FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
GO
ALTER TABLE [GiangVien] ADD CONSTRAINT FK_GiangVien_NguoiDung
  FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
GO
ALTER TABLE [Lop] ADD CONSTRAINT FK_Lop_Khoa
  FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
GO
ALTER TABLE [Lop] ADD CONSTRAINT FK_Lop_GiangVien
  FOREIGN KEY (MaGiangVien) REFERENCES GiangVien(MaGiangVien)
GO
ALTER TABLE [SinhVien] ADD CONSTRAINT FK_SinhVien_Lop
  FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
GO
ALTER TABLE [SinhVien] ADD CONSTRAINT FK_SinhVien_NguoiDung
  FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
GO
ALTER TABLE [LopHocPhan] ADD CONSTRAINT FK_LopHocPhan_MonHoc
  FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc)
GO
ALTER TABLE [LopHocPhan] ADD CONSTRAINT FK_LopHocPhan_GiangVien
  FOREIGN KEY (MaGiangVien) REFERENCES GiangVien(MaGiangVien)
GO
ALTER TABLE [LopHocPhan] ADD CONSTRAINT FK_LopHocPhan_HocKy
  FOREIGN KEY (MaHocKy) REFERENCES HocKy(MaHocKy)
GO
ALTER TABLE [DangKyHP] ADD CONSTRAINT FK_DangKyHP_SinhVien
  FOREIGN KEY (MaSinhVien) REFERENCES SinhVien(MaSinhVien)
GO
ALTER TABLE [DangKyHP] ADD CONSTRAINT FK_DangKyHP_LopHocPhan
  FOREIGN KEY (MaLHP) REFERENCES LopHocPhan(MaLHP)
GO
ALTER TABLE [Diem] ADD CONSTRAINT FK_Diem_DangKyHP
  FOREIGN KEY (MaDangKy) REFERENCES DangKyHP(MaDangKy)
GO
ALTER TABLE [PhucKhao] ADD CONSTRAINT FK_PhucKhao_DangKyHP
  FOREIGN KEY (MaDangKy) REFERENCES DangKyHP(MaDangKy)
GO
ALTER TABLE [KetQuaPhucKhao] ADD CONSTRAINT FK_KetQuaPhucKhao_PhucKhao
  FOREIGN KEY (MaPhucKhao) REFERENCES PhucKhao(MaPhucKhao)
GO
ALTER TABLE [KetQuaPhucKhao] ADD CONSTRAINT FK_KetQuaPhucKhao_GiangVien
  FOREIGN KEY (MaGiangVien) REFERENCES GiangVien(MaGiangVien)
GO
ALTER TABLE [CanhBaoHocVu] ADD CONSTRAINT FK_CanhBaoHocVu_SinhVien
  FOREIGN KEY (MaSinhVien) REFERENCES SinhVien(MaSinhVien)
GO
ALTER TABLE [CanhBaoHocVu] ADD CONSTRAINT FK_CanhBaoHocVu_HocKy
  FOREIGN KEY (MaHocKy) REFERENCES HocKy(MaHocKy)
GO
ALTER TABLE [LichHoc] ADD CONSTRAINT FK_LichHoc_LopHocPhan
  FOREIGN KEY (MaLHP) REFERENCES LopHocPhan(MaLHP)
GO
ALTER TABLE [LichHoc] ADD CONSTRAINT FK_LichHoc_PhongHoc
  FOREIGN KEY (MaPhong) REFERENCES PhongHoc(MaPhong)
GO

-- INSERT tài khoản Admin mặc định

INSERT INTO NguoiDung (TenDangNhap, MatKhau, VaiTro, TrangThai)
VALUES ('admin', '$2a$12$M/PYnXAedE47JGtWkm1BDO26UWFVwcwU6X9aXGM/CBO1nrGIrq/Su', 'Admin', 'Active')
UPDATE NguoiDung 
SET MatKhau = '$2a$12$uOJPgbWOhk5MQlur5HEvguJjFkZGhjl3r486DxgqErH4AbZYs7hLK'
WHERE TenDangNhap = 'admin'
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES ('CNTT', 'Cong nghe thong tin')
-- 2. Insert NguoiDung cho GV
INSERT INTO NguoiDung (TenDangNhap, MatKhau, VaiTro, TrangThai)
VALUES ('GV001', '$2a$12$jwSkgnk3xnAd/C6ZwqABpejJpaeUTePuwFms79aPBRRiFPlBacNJS', 'GiangVien', 'Active')

-- 3. Lấy MaNguoiDung vừa tạo
SELECT MaNguoiDung FROM NguoiDung WHERE TenDangNhap = 'GV001'

-- 4. Insert GiangVien (thay X bằng MaNguoiDung vừa lấy)
INSERT INTO GiangVien (MaGiangVien, HoTen, Email, MaKhoa, MaNguoiDung)
VALUES ('GV001', 'Nguyen Van A', 'gv001@email.com', 'CNTT', 6)

ALTER TABLE CanhBaoHocVu 
ALTER COLUMN TrangThai nvarchar(20) NULL