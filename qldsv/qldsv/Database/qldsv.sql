CREATE TABLE [NguoiDung] (
  [MaNguoiDung] int PRIMARY KEY,
  [TenDangNhap] nvarchar(50),
  [MatKhau] nvarchar(255),
  [VaiTro] nvarchar(20),
  [TrangThai] nvarchar(20)
)
GO

CREATE TABLE [Khoa] (
  [MaKhoa] int PRIMARY KEY,
  [TenKhoa] nvarchar(100)
)
GO

CREATE TABLE [Lop] (
  [MaLop] int PRIMARY KEY,
  [TenLop] nvarchar(50),
  [MaKhoa] int
)
GO

CREATE TABLE [SinhVien] (
  [MaSinhVien] int PRIMARY KEY,
  [HoTen] nvarchar(100),
  [NgaySinh] date,
  [GioiTinh] nvarchar(5),
  [Email] nvarchar(100),
  [SoDienThoai] nvarchar(15),
  [Trangthai] nvarchar(20),
  [MaLop] int,
  [MaNguoiDung] int
)
GO

CREATE TABLE [GiangVien] (
  [MaGiangVien] int PRIMARY KEY,
  [HoTen] nvarchar(100),
  [Email] nvarchar(100),
  [MaKhoa] int,
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
  [MaLHP] int PRIMARY KEY,
  [MaMonHoc] varchar(20),
  [MaGiangVien] int,
  [MaHocKy] int,
  [NgayBatDau] date,
  [NgayKetThuc] date
)
GO

CREATE TABLE [DangKyHP] (
  [MaDangKy] int PRIMARY KEY,
  [MaSinhVien] int,
  [MaLHP] int,
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
  [MaGiangVien] int,
  [DiemCu] float,
  [DiemMoi] float,
  [NhanXet] nvarchar(255),
  [NgayXuLy] date,
  [KetLuan] nvarchar(20)
)
GO

CREATE TABLE [CanhBaoHocVu] (
  [MaCanhBao] int PRIMARY KEY,
  [MaSinhVien] int,
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
  [MaLHP] int,
  [MaPhong] int,
  [Thu] int,
  [CaHoc] int,
  PRIMARY KEY ([MaLHP], [Thu], [CaHoc])
)
GO

CREATE TABLE [CoVanHocTap] (
  [MaLop] int,
  [MaGiangVien] int,
  [NgayPhanCong] date,
  PRIMARY KEY ([MaLop])
)
GO

CREATE UNIQUE INDEX [DangKyHP_index_0] ON [DangKyHP] ("MaSinhVien", "MaLHP")
GO

CREATE UNIQUE INDEX [LichHoc_index_1] ON [LichHoc] ("MaPhong", "Thu", "CaHoc")
GO

EXEC sp_addextendedproperty
@name = N'Column_Description',
@value = 'Active / Inactive / BiKhoa',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table',  @level1name = 'NguoiDung',
@level2type = N'Column', @level2name = 'TrangThai';
GO

EXEC sp_addextendedproperty
@name = N'Table_Description',
@value = 'Lưu điểm theo từng lần học; dùng TongKet để hiển thị và có thể thay đổi sau phúc khảo',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table',  @level1name = 'Diem';
GO

EXEC sp_addextendedproperty
@name = N'Column_Description',
@value = 'ChuaXacNhan / DaXacNhan',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table',  @level1name = 'Diem',
@level2type = N'Column', @level2name = 'TrangThai';
GO

EXEC sp_addextendedproperty
@name = N'Column_Description',
@value = 'LanDau / HocLai / CaiThien',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table',  @level1name = 'Diem',
@level2type = N'Column', @level2name = 'Loaihoc';
GO

EXEC sp_addextendedproperty
@name = N'Column_Description',
@value = 'GiangVien / PhucKhao',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table',  @level1name = 'Diem',
@level2type = N'Column', @level2name = 'NguonGoc';
GO

EXEC sp_addextendedproperty
@name = N'Column_Description',
@value = 'ChoDuyet / DangXuLy / DaXuLy ',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table',  @level1name = 'PhucKhao',
@level2type = N'Column', @level2name = 'TrangThai';
GO

EXEC sp_addextendedproperty
@name = N'Column_Description',
@value = 'GiuNguyen / ThayDoi',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table',  @level1name = 'KetQuaPhucKhao',
@level2type = N'Column', @level2name = 'KetLuan';
GO

ALTER TABLE [Lop] ADD FOREIGN KEY ([MaKhoa]) REFERENCES [Khoa] ([MaKhoa])
GO

ALTER TABLE [SinhVien] ADD FOREIGN KEY ([MaLop]) REFERENCES [Lop] ([MaLop])
GO

ALTER TABLE [SinhVien] ADD FOREIGN KEY ([MaNguoiDung]) REFERENCES [NguoiDung] ([MaNguoiDung])
GO

ALTER TABLE [GiangVien] ADD FOREIGN KEY ([MaKhoa]) REFERENCES [Khoa] ([MaKhoa])
GO

ALTER TABLE [GiangVien] ADD FOREIGN KEY ([MaNguoiDung]) REFERENCES [NguoiDung] ([MaNguoiDung])
GO

ALTER TABLE [LopHocPhan] ADD FOREIGN KEY ([MaMonHoc]) REFERENCES [MonHoc] ([MaMonHoc])
GO

ALTER TABLE [LopHocPhan] ADD FOREIGN KEY ([MaGiangVien]) REFERENCES [GiangVien] ([MaGiangVien])
GO

ALTER TABLE [LopHocPhan] ADD FOREIGN KEY ([MaHocKy]) REFERENCES [HocKy] ([MaHocKy])
GO

ALTER TABLE [DangKyHP] ADD FOREIGN KEY ([MaSinhVien]) REFERENCES [SinhVien] ([MaSinhVien])
GO

ALTER TABLE [DangKyHP] ADD FOREIGN KEY ([MaLHP]) REFERENCES [LopHocPhan] ([MaLHP])
GO

ALTER TABLE [Diem] ADD FOREIGN KEY ([MaDangKy]) REFERENCES [DangKyHP] ([MaDangKy])
GO

ALTER TABLE [PhucKhao] ADD FOREIGN KEY ([MaDangKy]) REFERENCES [DangKyHP] ([MaDangKy])
GO

ALTER TABLE [KetQuaPhucKhao] ADD FOREIGN KEY ([MaPhucKhao]) REFERENCES [PhucKhao] ([MaPhucKhao])
GO

ALTER TABLE [KetQuaPhucKhao] ADD FOREIGN KEY ([MaGiangVien]) REFERENCES [GiangVien] ([MaGiangVien])
GO

ALTER TABLE [CanhBaoHocVu] ADD FOREIGN KEY ([MaSinhVien]) REFERENCES [SinhVien] ([MaSinhVien])
GO

ALTER TABLE [CanhBaoHocVu] ADD FOREIGN KEY ([MaHocKy]) REFERENCES [HocKy] ([MaHocKy])
GO

ALTER TABLE [LichHoc] ADD FOREIGN KEY ([MaLHP]) REFERENCES [LopHocPhan] ([MaLHP])
GO

ALTER TABLE [LichHoc] ADD FOREIGN KEY ([MaPhong]) REFERENCES [PhongHoc] ([MaPhong])
GO

ALTER TABLE [CoVanHocTap] ADD FOREIGN KEY ([MaLop]) REFERENCES [Lop] ([MaLop])
GO

ALTER TABLE [CoVanHocTap] ADD FOREIGN KEY ([MaGiangVien]) REFERENCES [GiangVien] ([MaGiangVien])
GO
