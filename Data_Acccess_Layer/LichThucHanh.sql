use master
go
create database LichThucHanh
go
use LichThucHanh
go
create table GiaoVien
(
	MaGV varchar(10) primary key,
	TenGV nvarchar(50) not null,
	DiaChi nvarchar(50),
	SoDienThoai varchar(13)
)
--nhap du lieu
insert into GiaoVien(MaGV,TenGV,DiaChi,SoDienThoai) values('doan',N'Thầy Đinh Công Đoan',N'P .Linh Chiểu - Q. Thủ  Đức','0987654432')
insert into GiaoVien(MaGV,TenGV,DiaChi,SoDienThoai) values('dao',N'Thầy Nguyễn Minh Đạo',N'Quận 9','0909374852')
insert into GiaoVien(MaGV,TenGV,DiaChi,SoDienThoai) values('tu',N'Thầy Trần Công Tú',N'Quận 7','0987654432')
insert into GiaoVien(MaGV,TenGV,DiaChi,SoDienThoai) values('van',N'Cô Nguyễn Thị Thanh Vân',N'Quận 4','0967323834')
insert into GiaoVien(MaGV,TenGV,DiaChi,SoDienThoai) values('khoan',N'Thầy Khoan',N'Quận3','0168345234')
insert into GiaoVien(MaGV,TenGV,DiaChi,SoDienThoai) values('trung',N'Thầy Trung',N'Quận 1','0392393434')



create table Lop
(
	MaLop varchar(10) primary key,
	TenLop nvarchar(100) not null,
	SoLuongSV int
)
--nhap du lieu
insert into Lop(MaLop,TenLop,SoLuongSV) values('091101A',N'Kỹ Sư 09 1',40)
insert into Lop(MaLop,TenLop,SoLuongSV) values('091101B',N'Kỹ Sư 09 2',60)
insert into Lop(MaLop,TenLop,SoLuongSV) values('091101C',N'Kỹ Sư 09 3',70)
insert into Lop(MaLop,TenLop,SoLuongSV) values('101101A',N'Kỹ Sư 10 1',54)
insert into Lop(MaLop,TenLop,SoLuongSV) values('101101B',N'Kỹ Sư 10 1',55)
insert into Lop(MaLop,TenLop,SoLuongSV) values('101109A',N'Sư Phạm 10 1',78)
insert into Lop(MaLop,TenLop,SoLuongSV) values('111109A',N'Sư Phạm 11',90)

create table MonHoc
(
	MaMH varchar(10) primary key,
	TenMonHoc nvarchar(50),
	SoChi int,
	SoTiet int,
	Khoa nvarchar(50)
)
--nhap dl
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH001',N'Toán Rời Rạc Và Lý Thuyêt Đồ Thị',4,5,'CNTT')
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH002',N'Cấu Trúc Máy Tính Và Hợp Ngữ',4,5,'CNTT')
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH003',N'Hệ Điều Hành',4,5,'CNTT')
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH004',N'Kỹ Thuật Lập Trình',4,5,'CNTT')
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH005',N'Mạng Máy Tính Căn Bản',4,5,'CNTT')
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH006',N'Cơ Sở Dữ Liệu',4,5,'CNTT')
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH007',N'Lập Trình Hướng Đối Tượng',4,5,'CNTT')
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH008',N'Công Nghệ Phận Mềm',4,5,'CNTT')

create table Phong
(
	MaPhong varchar(10) primary key,
	TenPhong nvarchar(50) not null,
	SoMay int
)
--nhap dl
insert into Phong(MaPhong,TenPhong,SoMay) values('P001',N'PM1',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P002',N'PM2',45)
insert into Phong(MaPhong,TenPhong,SoMay) values('P003',N'PM3',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P004',N'PM4',40)
insert into Phong(MaPhong,TenPhong,SoMay) values('P005',N'PM5',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P006',N'A5-201',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P007',N'A5-202',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P008',N'A5-203',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P009',N'A5-204',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P010',N'A5-301',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P011',N'A5-302',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P012',N'A5-303',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P013',N'A5-304',50)

create table Account
(
	TenDangNhap varchar(10) primary key foreign key references GiaoVien(MaGV),
	MatKhau nvarchar(20) not null,
	Quyen int not null
)
--nhap dl
insert into Account(TenDangNhap,MatKhau,Quyen) values('doan','doan',2)
insert into Account(TenDangNhap,MatKhau,Quyen) values('van','van',2)
insert into Account(TenDangNhap,MatKhau,Quyen) values('trung','trung',2)
insert into Account(TenDangNhap,MatKhau,Quyen) values('khoan','khoan',2)

create table LichDayLyThuyet
(
	MaGV varchar(10) not null foreign key references GiaoVien(MaGV),
	MaMH varchar(10) not null foreign key references MonHoc(MaMH),
	MaLop varchar(10) not null foreign key references Lop(MaLop),
	MaPhong varchar(10) null foreign key references Phong(MaPhong),
	Ngay date null,
	Tuan int not null,
	Thu nvarchar(20) not null,
	Tiet nvarchar(20) not null,
	constraint PK_KhoaChinh primary key(MaGV,MaMH,MaLop,Tuan,Thu,Tiet)
)
create table LichDayThucHanh
(
	MaGV varchar(10) not null foreign key references GiaoVien(MaGV),
	MaMH varchar(10) not null foreign key references MonHoc(MaMH),
	MaLop varchar(10) not null foreign key references Lop(MaLop),
	MaPhong varchar(10) null foreign key references Phong(MaPhong),
	Ngay date null,
	Tuan int not null,
	Thu nvarchar(20) not null,
	Tiet nvarchar(20) not null,
	constraint PK_KhoaChinh2 primary key(MaGV,MaMH,MaLop,Tuan,Thu,Tiet)
)


create table Admin
(
	TenDangNhap varchar(10) primary key,
	MatKhau nvarchar(20) not null,
	Quyen int not null
)

--nhap dl
insert into Admin(TenDangNhap,MatKhau,Quyen) values('admin','admin',1)
