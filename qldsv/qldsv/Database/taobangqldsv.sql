USE master
GO

DROP DATABASE IF EXISTS qldiemsv
GO

CREATE DATABASE qldiemsv
GO

USE qldiemsv
GO

CREATE TABLE [NguoiDung] (
  [MaNguoiDung] int PRIMARY KEY,
  [TenDangNhap] nvarchar(50),
  [MatKhau] nvarchar(255),
  [VaiTro] nvarchar(20),
  [TrangThai] nvarchar(20)
)
GO

CREATE TABLE [Khoa] (
  [MaKhoa] varchar(10) PRIMARY KEY,
  [TenKhoa] nvarchar(100)
)
GO

CREATE TABLE [GiangVien] (
  [MaGiangVien] varchar(20) PRIMARY KEY,
  [HoTen] nvarchar(100),
  [Email] nvarchar(100),
  [MaKhoa] varchar(10),
  [MaNguoiDung] int
)
GO

CREATE TABLE [Lop] (
  [MaLop] varchar(20) PRIMARY KEY,
  [TenLop] nvarchar(50),
  [MaKhoa] varchar(10),
  [MaGiangVien] varchar(20)
)
GO

CREATE TABLE [SinhVien] (
  [MaSinhVien] varchar(20) PRIMARY KEY,
  [HoTen] nvarchar(100),
  [NgaySinh] date,
  [GioiTinh] nvarchar(5),
  [Email] nvarchar(100),
  [SoDienThoai] nvarchar(15),
  [Trangthai] nvarchar(20),
  [MaLop] varchar(20),
  [MaNguoiDung] int
)
GO

CREATE TABLE [MonHoc] (
  [MaMonHoc] varchar(20) PRIMARY KEY,
  [TenMon] nvarchar(100),
  [SoTinChi] int,
  [HeSoChuyenCan] float,
  [HeSoKT1] float,
  [HeSoKT2] float,
  [HeSoCuoiKy] float
)
GO

CREATE TABLE [HocKy] (
  [MaHocKy] int PRIMARY KEY,
  [TenHocKy] nvarchar(20),
  [NamHoc] nvarchar(20),
  [Trangthai] nvarchar(20)
)
GO

CREATE TABLE [LopHocPhan] (
  [MaLHP] varchar(20) PRIMARY KEY,
  [MaMonHoc] varchar(20),
  [MaGiangVien] varchar(20),
  [MaHocKy] int,
  [NgayBatDau] date,
  [NgayKetThuc] date
)
GO

CREATE TABLE [DangKyHP] (
  [MaDangKy] int PRIMARY KEY,
  [MaSinhVien] varchar(20),
  [MaLHP] varchar(20),
  [NgayDangKy] date
)
GO

CREATE TABLE [Diem] (
  [MaDiem] int PRIMARY KEY,
  [MaDangKy] int,
  [ChuyenCan] float,
  [Kiemtra1] float,
  [Kiemtra2] float,
  [CuoiKy] float,
  [TongKet] float,
  [TrangThai] nvarchar(20),
  [LanHoc] int,
  [Loaihoc] nvarchar(20),
  [NguonGoc] nvarchar(20)
)
GO

CREATE TABLE [PhucKhao] (
  [MaPhucKhao] int PRIMARY KEY,
  [MaDangKy] int,
  [LyDo] nvarchar(255),
  [NgayGui] date,
  [TrangThai] nvarchar(20)
)
GO

CREATE TABLE [KetQuaPhucKhao] (
  [MaKetQua] int PRIMARY KEY,
  [MaPhucKhao] int,
  [MaGiangVien] varchar(20),
  [DiemCu] float,
  [DiemMoi] float,
  [NhanXet] nvarchar(255),
  [NgayXuLy] date,
  [KetLuan] nvarchar(20)
)
GO

CREATE TABLE [CanhBaoHocVu] (
  [MaCanhBao] int PRIMARY KEY,
  [MaSinhVien] varchar(20),
  [MaHocKy] int,
  [SoKyDaBiCB] int,
  [DiemHK] float,
  [TBTL] float,
  [TCTL] float,
  [LyDo] nvarchar(200),
  [MucCanhBao] nvarchar(20),
  [TrangThai] nvarchar(20)
)
GO

CREATE TABLE [PhongHoc] (
  [MaPhong] int PRIMARY KEY,
  [TenPhong] nvarchar(50)
)
GO

CREATE TABLE [LichHoc] (
  [MaLHP] varchar(20),
  [MaPhong] int,
  [Thu] int,
  [CaHoc] int,
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