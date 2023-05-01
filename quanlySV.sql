CREATE DATABASE QLSINHVIEN
USE QLSINHVIEN

CREATE TABLE KHOA(
MaKhoa varchar(10) Primary key NOT NULL,
TenKhoa nvarchar(20),
SoCBGV int
)
CREATE TABLE LOP(
MaLop varchar(10) Primary key NOT NULL,
TenLop nvarchar(20),
MaKhoa varchar(10) foreign key references KHOA(MaKhoa) on delete cascade on update cascade
)
CREATE TABLE SINHVIEN(
Masv varchar(10) Primary key NOT NULL,
HoTen nvarchar(25),
NgaySinh date,
GioiTinh bit,
NienKhoa varchar(10) NULL,
MaLop varchar(10) foreign key references LOP(MaLop) on delete cascade on update cascade NULL
)
CREATE TABLE USERS(
Masv varchar(10) foreign key references SINHVIEN(Masv) on delete cascade on update cascade NOT NULL,
MatKhau varchar(10) NOT NULL,
LoaiTaikhoan bit NOT NULL,
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
TenMH nvarchar(20),
DiemThi Float
)
Insert into KHOA(MaKhoa, TenKhoa, SoCBGV) VALUES
('TCNH', N'Tài chính Ngân Hàng', 20),
('SPT', N'Sư Phạm Toán', 13),
('CNTT', N'Công Nghệ Thông Tin', 25),
('QTKD', N'Quản Trị Kinh Doanh', 17),
('QTKS', N'Quản Trị Khách Sạn', 30),
('KT', N'Kế Toán', 18),
('NNA', N'Ngôn Ngữ Anh', 22);

Insert into LOP(MaLop, TenLop, MaKhoa) VALUES
('01', 'K21D', 'SPT'),
('02', 'K21A', 'SPT'),
('03', 'K20B', 'TCNH'),
('04', 'K24C', 'CNTT'),
('05', 'K24A', 'CNTT'),
('06', 'K22A', 'QTKS'),
('07', 'K25B', 'QTKD'),
('08', 'K25A', 'NNA');

Insert into SINHVIEN(Masv, HoTen, NgaySinh, GioiTinh, NienKhoa, MaLop) VALUES
('10001', N'Phan Lưu Diễm Quỳnh', '1986-05-20', 0, null, null),
('10002', N'Phạm Minh Nhật', '1990-09-04', 1, null, null),
('10003', N'Lê Thái Học', '1989-12-30', 1, null, null),
('24002', N'Phạm Tín Đức', '1999-07-19', 1, '2010-2014', '05'),
('25038', N'Dương Thị Khánh Linh', '2000-10-05', 0, '2011-2015', '06'),
('21508', N'Trần Anh Tuấn', '1996-12-07', 1, '2008-2012', '01'),
('22321', N'Trần Ngọc Yến Linh', '1997-02-04', 0, '2009-2013', '07'),
('24001', N'Lê Đức Anh', '1999-10-02', 1, '2010-2014', '04'),
('20401', N'Nguyễn Quốc Hùng', '1995-06-23', 1, '2007-2011', '03'),
('25037', N'Phan Như Như', '2000-02-02', 0, '2011-2015', '06'),
('24003', N'Hoàng Duy Anh', '1999-04-15', 1, '2010-2014', '04'),
('21509', N'Phạm Thị Quỳnh Hoa', '1996-04-18', 0, '2008-2012', '01'),
('20402', N'Hồ Trà My', '1995-09-30', 0, '2007-2011', '03'),
('21510', N'Lê Văn Hải', '1996-11-06', 1, '2008-2012', '02'),
('21511', N'Đinh Văn Huy', '1996-03-24', 1, '2008-2012', '01'),
('21512', N'Tô Nhật Linh', '1996-08-17', 0, '2008-2012', '01'),
('25039', N'Trình Thị Cẩm Vy', '2000-04-05', 0, '2011-2015', '08'),
('25040', N'Trịnh Thị Bích Phượng', '2000-03-11', 0, '2011-2015', '06'),
('25041', N'Võ Ngọc Tài', '2000-11-11', 1, '2011-2015', '08'),
('25042', N'Phạm Thảo My', '2000-04-09', 0, '2011-2015', '08'),
('24004', N'Trần Thanh An', '1999-10-09', 1, '2010-2014', '04');

Insert into USERS(Masv, MatKhau, LoaiTaikhoan) VALUES
('10001', 'admin123@', 0),
('22321', 'linh123@', 1);


Insert into MONHOC(MaMH, TenMH, TinChi, SoTiet) VALUES
('mh01', N'Xác Suất Thống Kê', 3, 30),
('mh02', N'Tổng Quan Du Lịch', 2, 5),
('mh03', N'Kinh Tế Vĩ Mô', 3, 31),
('mh04', N'Nguyên Lý Thống Kê', 3, 30),
('mh05', N'Lập Trình Web', 3, 30),
('mh06', N'Ngữ Pháp Tiếng Anh', 4, 20);

Insert into KETQUA(MaMH, Masv, TenMH, DiemThi) VALUES
('mh01', '21508', N'Xác Suất Thống Kê', 8.3),
('mh02', '25037', N'Tổng Quan Du Lịch',9.8),
('mh03', '22321', N'Kinh Tế Vĩ Mô', 6.5),
('mh04', '20401', N'Nguyên Lý Thống Kê',4.8),
('mh05', '24001', N'Lập Trình Web', 7.3),
('mh05', '24002', N'Lập Trình Web', 5.8),
('mh06', '25039', N'Ngữ Pháp Tiếng Anh', 9.9),
('mh03', '25039', N'Kinh Tế Vĩ Mô', 7.2),
('mh06', '25042', N'Ngữ Pháp Tiếng Anh', 6.4),
('mh06', '25041', N'Ngữ Pháp Tiếng Anh', 4.6),
('mh02', '25038', N'Tổng Quan Du Lịch', 7.8);