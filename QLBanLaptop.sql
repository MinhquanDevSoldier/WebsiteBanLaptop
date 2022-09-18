Delete QLBanLaptop
go
create database QLBanLaptop
go
use QLBanLaptop
-- Tai khoan Quan tri
go
-- Admin la all quyen
-- accountant quan ly tai chinh, xuat hoa don database
-- warehousestaff quan ly xuat nhap san pham vao kho tren database
-- Marketing quan ly quang cao tren website
create table Permission
(
	ID varchar(30) primary key,
	Description nvarchar(255) not null,
)
insert into dbo.Permission values ('Admin',N'Quản trị viên')
insert into dbo.Permission values ('Accountant',N'Bộ phận tài chính')
insert into dbo.Permission values ('WarehouseStaff',N'Bộ phận kho')
insert into dbo.Permission values ('Marketing',N'Bộ phận quảng cáo')
go
create table Admin
(
	UserName varchar(50) primary key,
	Password varchar(100) not null,
	permissionID varchar(30) not null,
	foreign key(permissionID) references Permission(ID)
)
insert into dbo.Admin values ('Admin','abc@123','Admin')
--
go
create table Product
(
	ProductID varchar(125) primary key,
	Name nvarchar(500) not null,
	BasePrice float not null,
	AfterDiscount float not null,
	ProductPhoto varchar(1000),
	PromotionID varchar(16)
)
go
create table Promotion
(
	PromotionID varchar(16) primary key,
	Description nvarchar(255) not null,
	DiscountNum float,
	TypeDiscount varchar(16) not null, 
)
go
create table TypeDiscount
(
	TypeDiscountID varchar(16) primary key,
	Description nvarchar(255) not null,
)
go