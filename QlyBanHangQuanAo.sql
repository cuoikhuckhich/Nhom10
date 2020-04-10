--tạo CSDL
Create Database QlyBanHangQuanAo
On 
(	Name = QLbh_QA_data,
	Filename = 'D:\Quynhtrang\test\qlybh_qa.mdf',
	size = 5,
	Maxsize = 10,
	filegrowth = 2
)
Log on
(	Name = qlbn_qa_log,
	Filename = 'D:\Quynhtrang\test\qlybh_qa.ldf',
	size = 5mb,
	Filegrowth = 2mb
)--TẠO BẢNG
Create table TheLoai
(
   Maloai nvarchar(20) primary key not null,
  Tenloai char(20) not null,
 )
 Create table Co
(
   Maco nvarchar(20) primary key not null,
  Tenco char(20) not null,
  )
  Create table ChatLieu
(
   Machatlieu nvarchar(20) primary key not null,
  Tenchatlieu char(20) not null,
  )
  Create table Mau
(
   Mamau nvarchar(20) primary key not null,
  Tenmau char(20) not null,
  )
  Create table DoiTuong
(
   Madoituong nvarchar(20) primary key not null,
  Tendoituong char(20) not null,
  )
  Create table Mua
(
   Mamua nvarchar(20) primary key not null,
  Tenmua char(20) not null,
  )
   Create table CongViec
	 ( 
	   MaCV nvarchar(20) primary key not null,
	   TenCV nvarchar(20) not null,
	   )
	   

	   Create table KhachHang
	   (
	       Makhach nvarchar(20) primary key not null,
	       Tenkhach nvarchar(20) not null,
	       Diachi nvarchar(20) not null,
	       Dienthoai int not null
	   )
	   create table NhaCungCap
	   (
	       MaNCC nvarchar(20) primary key not null,
	       TenNCC nvarchar(20) not null,
	       Diachi nvarchar(20) not null,
	       DienThoai int not null ,
	   )
	   create table NoiSanXuat
	   (
	   MaNSX nvarchar(20) primary key not null,
	   TenNSX nvarchar(20) not null,
	   )

	    Create table NhanVien
	 (
	   MaNV nvarchar(20) primary key not null,
	   TenNV nvarchar(20) not null,
	   Gioitinh nvarchar(20) not null,
	   Ngaysinh datetime,
	   Diachi nvarchar(20) not null,
	   Dienthoai int not null,
	   MaCV nvarchar(20) not null,
	   foreign key (MaCV)  references dbo.CongViec(MaCV),

	   )

Create table SanPham
(
   Maquanao nvarchar(20) primary key not null,
   Tenquanao char(20) not null,
   Maloai nvarchar(20) not null,
   Maco  nvarchar(20) not null,
   Machatlieu  nvarchar(20) not null,
   Mamau nvarchar(20) not null,
   Madoituong nvarchar(20) not null,
   Mamua nvarchar(20) not null,
   MaNSX nvarchar(20) not null,
   Soluong  int ,
   Anh  nvarchar(100) not null,
   Đongianhap int not null,
   Đongiaban int not null,
   foreign key (Maloai ) references dbo.Theloai(Maloai),
   foreign key (Maco ) references dbo.Co(Maco),
   foreign key (Machatlieu ) references dbo.ChatLieu(Machatlieu),
   foreign key (Mamau ) references dbo.Mau(Mamau),
   foreign key (Madoituong) references dbo.DoiTuong(Madoituong),
   foreign key (Mamua ) references dbo.Mua(Mamua),
   foreign key (MaNSX )  references dbo.NoiSanXuat(MaNSX),


   )

   Create table HoaDonBan
   (
     SoHDB nvarchar(20) primary key not null,
	 MaNV nvarchar(20) not null,
	 Ngayban datetime not null,
	 Makhach nvarchar(20) not null,
	 Tongtien int not null,
	 foreign key (Makhach )  references dbo.KhachHang(Makhach),
	 )

	 Create table ChiTietHDBan
	 (
	 SoHDB nvarchar(20),
	 Maquanao nvarchar(20),
	 Soluong int not null,
	 Giamgia int not null,
	 Thanhtien int not null,
	 primary key(SoHDB, Maquanao),
	 foreign key (Maquanao )  references dbo.SanPham(Maquanao),
	 )

	  Create table HoaDonNhap
	 (
	 SoHDN nvarchar(20) primary key not null,
	 MaNV nvarchar(20) not null,
	 Ngaynhap datetime not null,
	 MaNCC nvarchar(20) not null,
	 TongTien int not null,
	 foreign key (MaNV )  references dbo.NhanVien(MaNV),
	 foreign key (MaNCC )  references dbo.NhaCungCap(MaNCC),
	 )

	 Create table ChiTietHDNhap
	 (
	 SoHDN nvarchar(20),
	 Maquanao nvarchar(20),
	 Soluong int not null,
	 Dongia int not null,
	 Giamgia int not null,
	 Thanhtien int not null,
	 primary key(SoHDN,Maquanao),
	 foreign key (Maquanao )  references dbo.SanPham(Maquanao),

	 )
	  Insert into TheLoai(Maloai,Tenloai) Values ('A1', 'ao')
	 Insert into TheLoai(Maloai,Tenloai) Values ('A2', 'Quan')
	 Insert into TheLoai(Maloai,Tenloai) Values ('A3', 'Ao Lot')

	  Insert into Co(Maco,Tenco) Values ('S', 'S37')
	  Insert into Co(Maco,Tenco) Values ('L', 'L38')
	  Insert into Co(Maco,Tenco) Values ('L', 'L38')

	  Insert into ChatLieu(Machatlieu,Tenchatlieu) Values ('AB1', 'Lua')
	  Insert into ChatLieu(Machatlieu,Tenchatlieu) Values ('AB2', 'Dui')
	  Insert into ChatLieu(Machatlieu,Tenchatlieu) Values ('AB3', 'cotong')

	   Insert into Mau(Mamau,Tenmau) Values ('T1', 'Trang ngoc')
	   Insert into Mau(Mamau,Tenmau) Values ('T2', 'Trang xanh')
	   Insert into Mau(Mamau,Tenmau) Values ('D1', 'Do Tuoi')

	   Insert into DoiTuong(Madoituong,Tendoituong) Values ('Nam1', 'tre em')
       Insert into DoiTuong(Madoituong,Tendoituong) Values ('Nam2', 'nam') 
	   Insert into DoiTuong(Madoituong,Tendoituong) Values ('Nam3', 'Trung nien')

	   Insert into Mua(Mamua,Tenmua) Values ('MX', 'Mua Xuan')
	   Insert into Mua(Mamua,Tenmua) Values ('MH', 'Mua He')
	   Insert into Mua(Mamua,Tenmua) Values ('MT', 'Mua Thu')

	    Insert into CongViec(MaCV,TenCV) Values ('QLy', 'Quan Ly')
		 Insert into CongViec(MaCV,TenCV) Values ('BHang', 'Ban Hang')
		 Insert into CongViec(MaCV,TenCV) Values ('DD', 'Don dep kho')

		 Insert into KhachHang(Makhach,Tenkhach,Diachi,Dienthoai) Values ('001', 'C.Hang','Time City',0912345678)
		 Insert into KhachHang(Makhach,Tenkhach,Diachi,Dienthoai) Values ('002', 'C.Minh','101 le trong tan',0912345808)
		 Insert into KhachHang(Makhach,Tenkhach,Diachi,Dienthoai) Values ('003', 'C.Trang','Time City',0912345678)

		  Insert into NhaCungCap(MaNCC,TenNCC,Diachi,Dienthoai) Values ('MAnh', 'Nha CC minh anh','khu CN Bac ninh',0912345678)
		  Insert into NhaCungCap(MaNCC,TenNCC,Diachi,Dienthoai) Values ('SLong', 'Nha CC Sinh Long','khu CN Bac Hoa',1900252555)

		  insert into NoiSanXuat(MaNSX,TenNSX) values ('NM1','Nha may QQT')
		  insert into NoiSanXuat(MaNSX,TenNSX) values ('NM2','Nha may TTb')
		  insert into NoiSanXuat(MaNSX,TenNSX) values ('NM3','Nha may Binh hanh')

		  
		 Insert into NhanVien(MaNV,TenNV,Gioitinh,Ngaysinh,Diachi,Dienthoai,MaCV) values('AT','AnhTu','Nu',19/2/2000,'37 truong chinh',0916867345,'QLy')
		 Insert into NhanVien(MaNV,TenNV,Gioitinh,Ngaysinh,Diachi,Dienthoai,MaCV) values('QT','Quynh Trang','Nu',20/5/1999,'37 Truong Dinh',0921456987,'BHang')
		 Insert into NhanVien(MaNV,TenNV,Gioitinh,Ngaysinh,Diachi,Dienthoai,MaCV) values('ML','Mai Linh','Nu',10/6/1998,'12 Chua Boc',0234468909,'DD')

				Insert into SanPham(Maquanao,Tenquanao,MaLoai,Maco,Machatlieu,Mamau,Madoituong,Mamua,MaNSX,Soluong,Anh,Đongianhap,Đongiaban)
			   Values ('Ao', 'Ao somi','A1','S','AB1','T1','Nam1','MX','NM1',2,'anh',150000,180000)
		   Insert into SanPham(Maquanao,Tenquanao,MaLoai,Maco,Machatlieu,Mamau,Madoituong,Mamua,MaNSX,Soluong,Anh,Đongianhap,Đongiaban)
			   Values ('Ao1', 'Ao coc tay','A1','S','AB2','T2','Nam2','MX','NM2',2,'anh',150000,180000)
		 Insert into SanPham(Maquanao,Tenquanao,MaLoai,Maco,Machatlieu,Mamau,Madoituong,Mamua,MaNSX,Soluong,Anh,Đongianhap,Đongiaban)
			   Values ('Quan', 'Quan jean','A2','S','AB3','D1','Nam2','MX','NM3',2,'anh',150000,180000)

		 Insert into HoaDonBan(SoHDB,MaNV,Ngayban,Makhach,Tongtien) values('1','AT',5/4/2020,'001',180000)
		 Insert into HoaDonBan(SoHDB,MaNV,Ngayban,Makhach,Tongtien) values('2','AT',5/4/2020,'002',880000)
		 Insert into HoaDonBan(SoHDB,MaNV,Ngayban,Makhach,Tongtien) values('3','AT',5/4/2020,'003',380000)

		 Insert into ChiTietHDBan(SoHDB,Maquanao,Soluong,Giamgia,Thanhtien) values('1','Ao',2,30000,150000)
		 Insert into ChiTietHDBan(SoHDB,Maquanao,Soluong,Giamgia,Thanhtien) values('2','Quan',2,40000,150000)

		 Insert into HoaDonNhap(SoHDN,MaNV,Ngaynhap,MaNCC,TongTien) values('2','AT',3/5/2020,'MAnh',15000000)
		 Insert into HoaDonNhap(SoHDN,MaNV,Ngaynhap,MaNCC,TongTien) values('3','AT',2/5/2020,'SLong',38000000)

		 Insert into ChiTietHDNhap(SoHDN,Maquanao,Soluong,Dongia,Giamgia,Thanhtien) values('1','Ao',1800,150000,54000000,216000000)
		 Insert into ChiTietHDNhap(SoHDN,Maquanao,Soluong,Dongia,Giamgia,Thanhtien) values('1','Ao1',180,150000,5400000,21600000)
		 Insert into ChiTietHDNhap(SoHDN,Maquanao,Soluong,Dongia,Giamgia,Thanhtien) values('1','Quan',180,150000,5400000,21600000)



