﻿use master
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
insert into GiaoVien(MaGV,TenGV,DiaChi,SoDienThoai) values('GV001','Nguyễn Văn A','P .Linh Chiểu - Q. Thủ  Đức','0987654432')
insert into GiaoVien(MaGV,TenGV,DiaChi,SoDienThoai) values('GV002','Phạm Văn B','Quận 9','0909374852')
insert into GiaoVien(MaGV,TenGV,DiaChi,SoDienThoai) values('GV003','Lê Thị Phượng','Quận 7','0987654432')
insert into GiaoVien(MaGV,TenGV,DiaChi,SoDienThoai) values('GV004','Ngô Quốc Hùng','Quận 4','0967323834')
insert into GiaoVien(MaGV,TenGV,DiaChi,SoDienThoai) values('GV005','Nguyễn Thị Huệ','Quận3','0168345234')
insert into GiaoVien(MaGV,TenGV,DiaChi,SoDienThoai) values('GV006','Lê Văn Toàn','Quận 1','0392393434')



create table Lop
(
	MaLop varchar(10) primary key,
	TenLop nvarchar(100) not null,
	SoLuongSV int
)
--nhap du lieu
insert into Lop(MaLop,TenLop,SoLuongSV) values('L001','Toán Rời Rạc Và Lý Thuyêt Đồ Thị',50)
insert into Lop(MaLop,TenLop,SoLuongSV) values('L002','Cấu Trúc Máy Tính Và Hợp Ngữ',50)
insert into Lop(MaLop,TenLop,SoLuongSV) values('L003','Hệ Điều Hành',50)
insert into Lop(MaLop,TenLop,SoLuongSV) values('L004','Kỹ Thuật Lập Trình',50)
insert into Lop(MaLop,TenLop,SoLuongSV) values('L005','Mạng Máy Tính Căn Bản',50)
insert into Lop(MaLop,TenLop,SoLuongSV) values('L006','Cơ Sở Dữ Liệu',50)
insert into Lop(MaLop,TenLop,SoLuongSV) values('L007','Lập Trình Hướng Đới Tượng',50)

create table MonHoc
(
	MaMH varchar(10) primary key,
	TenMonHoc nvarchar(50),
	SoChi int,
	SoTiet int,
	Khoa nvarchar(50)
)
--nhap dl
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH001','Toán Rời Rạc Và Lý Thuyêt Đồ Thị',4,5,'CNTT')
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH002','Cấu Trúc Máy Tính Và Hợp Ngữ',4,5,'CNTT')
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH003','Hệ Điều Hành',4,5,'CNTT')
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH004','Kỹ Thuật Lập Trình',4,5,'CNTT')
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH005','Mạng Máy Tính Căn Bản',4,5,'CNTT')
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH006','Cơ Sở Dữ Liệu',4,5,'CNTT')
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH007','Lập Trình Hướng Đối Tượng',4,5,'CNTT')
insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) values('MH008','Công Nghệ Phận Mềm',4,5,'CNTT')

create table Phong
(
	MaPhong varchar(10) primary key,
	TenPhong nvarchar(50) not null,
	SoMay int
)
--nhap dl
insert into Phong(MaPhong,TenPhong,SoMay) values('P001','PM1',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P002','PM2',45)
insert into Phong(MaPhong,TenPhong,SoMay) values('P003','PM3',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P004','PM4',40)
insert into Phong(MaPhong,TenPhong,SoMay) values('P005','PM5',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P006','A5-201',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P007','A5-202',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P008','A5-203',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P009','A5-204',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P010','A5-301',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P011','A5-302',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P012','A5-303',50)
insert into Phong(MaPhong,TenPhong,SoMay) values('P013','A5-304',50)


create table ThoiGian
(
	MaTG varchar(10) primary key,
	Tiet nvarchar(30)
)
insert into ThoiGian(MaTG,Tiet) values('TG001','1-5')
insert into ThoiGian(MaTG,Tiet) values('TG002','1-4')
insert into ThoiGian(MaTG,Tiet) values('TG003','1-3')
insert into ThoiGian(MaTG,Tiet) values('TG004','1-2')
insert into ThoiGian(MaTG,Tiet) values('TG005','3-5')
insert into ThoiGian(MaTG,Tiet) values('TG006','3-4')
insert into ThoiGian(MaTG,Tiet) values('TG007','7-12')
insert into ThoiGian(MaTG,Tiet) values('TG008','7-11')
insert into ThoiGian(MaTG,Tiet) values('TG009','7-10')
insert into ThoiGian(MaTG,Tiet) values('TG010','7-8')
insert into ThoiGian(MaTG,Tiet) values('TG011','9-12')
insert into ThoiGian(MaTG,Tiet) values('TG012','9-11')
insert into ThoiGian(MaTG,Tiet) values('TG013','9-10')


create table Account
(
	TenDangNhap varchar(20) primary key,
	MatKhau nvarchar(20) not null,
	Quyen int not null
)
--nhap dl
insert into Account(TenDangNhap,MatKhau,Quyen) values('admin','1234',1)
insert into Account(TenDangNhap,MatKhau,Quyen) values('GV001','GV001',2)
insert into Account(TenDangNhap,MatKhau,Quyen) values('GV002','GV002',2)
insert into Account(TenDangNhap,MatKhau,Quyen) values('GV003','GV003',2)
insert into Account(TenDangNhap,MatKhau,Quyen) values('GV004','GV004',2)
insert into Account(TenDangNhap,MatKhau,Quyen) values('GV005','GV005',2)
insert into Account(TenDangNhap,MatKhau,Quyen) values('GV006','GV006',2)
insert into Account(TenDangNhap,MatKhau,Quyen) values('GV007','GV007',2)


create table LichDay
(
	MaGV varchar(10) not null foreign key references GiaoVien(MaGV),
	MaMH varchar(10) not null foreign key references MonHoc(MaMH),
	MaLop varchar(10) not null foreign key references Lop(MaLop),
	MaPhong varchar(10) not null foreign key references Phong(MaPhong),
	MaTG varchar(10) not null foreign key references ThoiGian(MaTG),
	Ngay date not null,
	Tuan int not null,
	Thu nvarchar(20) not null,
	Buoi nvarchar(20) not null
	constraint PK_KhoaChinh primary key(MaGV,MaMH,MaLop,MaPhong,MaTG,Ngay,Tuan,Thu,Buoi)
)
