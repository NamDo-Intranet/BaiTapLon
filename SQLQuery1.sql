CREATE DATABASE QLSINHVIEN
USE QLSINHVIEN

CREATE TABLE KHOA(
MaKhoa varchar(10) Primary key,
TenKhoa nvarchar(20),
SoCBGV int
)
CREATE TABLE LOP(
MaLop varchar(10) Primary key,
TenLop nvarchar(20),
MaKhoa varchar(10) foreign key references KHOA(MaKhoa) on delete cascade on update cascade
)
CREATE TABLE SINHVIEN(
Masv varchar(10) Primary key,
HoTen nvarchar(25),
NgaySinh date,
GioiTinh bit,
NienKhoa varchar(10),
MaLop varchar(10) foreign key references LOP(MaLop) on delete cascade on update cascade
)
CREATE TABLE USERS(
Masv varchar(10) foreign key references SINHVIEN(Masv) on delete cascade on update cascade,
MatKhau varchar(10) NOT NULL,
UNIQUE(Masv)
)
CREATE TABLE MONHOC(
MaMH varchar(10) Primary key,
TenMH nvarchar(20),
TinChi int,
SoTiet int
)
CREATE TABLE KETQUA(
MaMH varchar(10) foreign key references MONHOC(MaMH) on delete cascade on update cascade,
Masv varchar(10) foreign key references SINHVIEN(Masv) on delete cascade on update cascade,
DiemThi Float
)
Insert into KHOA(MaKhoa, TenKhoa, SoCBGV) VALUES
('TCNH', N'Tài chính Ngân Hàng', 20),
('SPT', N'Sư Phạm Toán', 13),
('CNTT', N'Công Nghệ Thông Tin', 25),
('QTKD', N'Quản Trị Kinh Doanh', 17),
('QTKS', N'Quản Trị Khách Sạn', 30),
('NNA', N'Ngôn Ngữ Anh', 23);
Insert into LOP(MaLop, TenLop, MaKhoa) VALUES
('01', 'K21D', 'SPT'),
('02', 'K21A', 'SPT'),
('03', 'K20B', 'TCNH'),
('04', 'K24C', 'CNTT'),
('05', 'K24A', 'CNTT'),
('06', 'K22A', 'QTKS'),
('07', 'K25B', 'QTKD');

Insert into SINHVIEN(Masv, HoTen, NgaySinh, GioiTinh, NienKhoa, MaLop) VALUES
('21507', N'Phan Lưu Diễm Quỳnh', '1996-05-20', 0, '2008-2012', '02'),
('21508', N'Trần Anh Tuấn', '1996-12-07', 1, '2008-2012', '01'),
('20401', N'Nguyễn Quốc Hùng', '1995-06-23', 1, '2007-2011', '03'),
('22321', N'Trần Ngọc Yến Linh', '1997-02-04', 0, '2009-2013', '06'),
('24001', N'Lê Đức Anh', '1999-10-02', 1, '2010-2014', '04'),
('24002', N'Phạm Tiến Đức', '1999-07-19', 1, '2010-2014', '05'),
('25037', N'Phan Như Như', '2000-02-02', 0, '2011-2015', '07'),
('25038', N'Phạm Đức Chinh', '2000-12-05', 1, '2011-2015', '07');
Insert into USERS(Masv, MatKhau) VALUES
('21507', 'quynh123@');

Insert into MONHOC(MaMH, TenMH, TinChi, SoTiet) VALUES
('mh01', N'Xác Suất Thống Kê', 3, 30),
('mh02', N'Tổng Quan Du Lịch', 2, 5),
('mh03', N'Kinh Tế Vĩ Mô', 3, 31),
('mh04', N'Nguyên Lý THống Kê', 3, 30),
('mh05', N'Lập Trình Web', 3, 30);

Insert into KETQUA(MaMH, Masv, DiemThi) VALUES
('mh01', '21508', 8.3),
('mh02', '25037', 9.8),
('mh03', '22321', 6.5),
('mh04', '20401', 4.8),
('mh05', '24001', 7.3),
('mh05', '24002', 5.8);