USE [master]
GO
/****** Object:  Database [ManagerCD]    Script Date: 12/28/2021 9:47:22 PM ******/
CREATE DATABASE [ManagerCD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ManagerCD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ManagerCD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ManagerCD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ManagerCD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ManagerCD] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ManagerCD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ManagerCD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ManagerCD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ManagerCD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ManagerCD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ManagerCD] SET ARITHABORT OFF 
GO
ALTER DATABASE [ManagerCD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ManagerCD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ManagerCD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ManagerCD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ManagerCD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ManagerCD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ManagerCD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ManagerCD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ManagerCD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ManagerCD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ManagerCD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ManagerCD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ManagerCD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ManagerCD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ManagerCD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ManagerCD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ManagerCD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ManagerCD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ManagerCD] SET  MULTI_USER 
GO
ALTER DATABASE [ManagerCD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ManagerCD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ManagerCD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ManagerCD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ManagerCD] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ManagerCD] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ManagerCD] SET QUERY_STORE = OFF
GO
USE [ManagerCD]
GO
/****** Object:  UserDefinedFunction [dbo].[ufn_removeMark]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ufn_removeMark] (@text nvarchar(max))
RETURNS nvarchar(max)
AS
BEGIN
	SET @text = LOWER(@text)
	DECLARE @textLen int = LEN(@text)
	IF @textLen > 0
	BEGIN
		DECLARE @index int = 1
		DECLARE @lPos int
		DECLARE @SIGN_CHARS nvarchar(100) = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýđð'
		DECLARE @UNSIGN_CHARS varchar(100) = 'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyydd'

		WHILE @index <= @textLen
		BEGIN
			SET @lPos = CHARINDEX(SUBSTRING(@text,@index,1),@SIGN_CHARS)
			IF @lPos > 0
			BEGIN
				SET @text = STUFF(@text,@index,1,SUBSTRING(@UNSIGN_CHARS,@lPos,1))
			END
			SET @index = @index + 1
		END
	END
	RETURN @text
END
GO
/****** Object:  Table [dbo].[Account]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[displayname] [nvarchar](50) NULL,
	[type] [int] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idKH] [int] NULL,
	[TotalPrice] [int] NULL,
	[NgayThue] [date] NULL,
	[NgayTra] [date] NULL,
	[DaThanhToan] [tinyint] NULL,
 CONSTRAINT [PK_Rent] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NULL,
	[idCD] [int] NULL,
	[count] [int] NULL,
 CONSTRAINT [PK_BillInfo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NameCCD] [nvarchar](50) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CD]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CD](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NameCD] [nvarchar](50) NULL,
	[idCategoryCD] [int] NULL,
	[Status] [tinyint] NULL,
 CONSTRAINT [PK_CD] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[CMND] [nvarchar](50) NULL,
	[Sdt] [nvarchar](50) NULL,
	[QueQuan] [nvarchar](150) NULL,
	[Trangthai] [tinyint] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([username], [password], [displayname], [type]) VALUES (N'ngoc1', N'0', N'ngocccctu', 0)
INSERT [dbo].[Account] ([username], [password], [displayname], [type]) VALUES (N'nphuc', N'0', N'Phúc cute', 1)
INSERT [dbo].[Account] ([username], [password], [displayname], [type]) VALUES (N'phuc', N'0', N'Phúc', 1)
INSERT [dbo].[Account] ([username], [password], [displayname], [type]) VALUES (N'tu', N'1', N'Tú', 0)
INSERT [dbo].[Account] ([username], [password], [displayname], [type]) VALUES (N'tuu', N'0', N'1111', 0)
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([id], [idKH], [TotalPrice], [NgayThue], [NgayTra], [DaThanhToan]) VALUES (1008, 1, 150000, CAST(N'2021-12-28' AS Date), CAST(N'2021-12-28' AS Date), 1)
INSERT [dbo].[Bill] ([id], [idKH], [TotalPrice], [NgayThue], [NgayTra], [DaThanhToan]) VALUES (1009, 4, 84000, CAST(N'2021-12-28' AS Date), CAST(N'2021-12-28' AS Date), 1)
INSERT [dbo].[Bill] ([id], [idKH], [TotalPrice], [NgayThue], [NgayTra], [DaThanhToan]) VALUES (1010, 1, 10000, CAST(N'2021-12-28' AS Date), CAST(N'2021-12-28' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[BillInfo] ON 

INSERT [dbo].[BillInfo] ([id], [idBill], [idCD], [count]) VALUES (1015, 1008, 5, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idCD], [count]) VALUES (1016, 1008, 3, 4)
INSERT [dbo].[BillInfo] ([id], [idBill], [idCD], [count]) VALUES (1017, 1008, 3002, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idCD], [count]) VALUES (1018, 1009, 3, 3)
INSERT [dbo].[BillInfo] ([id], [idBill], [idCD], [count]) VALUES (1019, 1009, 3003, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idCD], [count]) VALUES (1020, 1010, 2, 1)
SET IDENTITY_INSERT [dbo].[BillInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([id], [NameCCD], [Price]) VALUES (2, N'Hành động CD', 10000)
INSERT [dbo].[Category] ([id], [NameCCD], [Price]) VALUES (3, N'Hoạt hình CD', 10000)
INSERT [dbo].[Category] ([id], [NameCCD], [Price]) VALUES (4, N'Kinh dị CD', 20000)
INSERT [dbo].[Category] ([id], [NameCCD], [Price]) VALUES (5, N'Ca nhạc', 8000)
INSERT [dbo].[Category] ([id], [NameCCD], [Price]) VALUES (7, N'Anime', 12000)
INSERT [dbo].[Category] ([id], [NameCCD], [Price]) VALUES (8, N'Viễn tưởng', 5000)
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[CD] ON 

INSERT [dbo].[CD] ([id], [NameCD], [idCategoryCD], [Status]) VALUES (1, N'Siêu nhân gao', 3, 1)
INSERT [dbo].[CD] ([id], [NameCD], [idCategoryCD], [Status]) VALUES (2, N'Ninja Rùa', 2, 1)
INSERT [dbo].[CD] ([id], [NameCD], [idCategoryCD], [Status]) VALUES (3, N'Lời nguyền của quỷ', 4, 1)
INSERT [dbo].[CD] ([id], [NameCD], [idCategoryCD], [Status]) VALUES (4, N'Nhạc trữ tình', 5, 1)
INSERT [dbo].[CD] ([id], [NameCD], [idCategoryCD], [Status]) VALUES (5, N'Fast and Furious', 2, 1)
INSERT [dbo].[CD] ([id], [NameCD], [idCategoryCD], [Status]) VALUES (2003, N'Cuộc chiến ngoài hành tinh khỉ', 8, 1)
INSERT [dbo].[CD] ([id], [NameCD], [idCategoryCD], [Status]) VALUES (3002, N'Ngã rẽ tử thần', 4, 0)
INSERT [dbo].[CD] ([id], [NameCD], [idCategoryCD], [Status]) VALUES (3003, N'Your Name', 7, 1)
INSERT [dbo].[CD] ([id], [NameCD], [idCategoryCD], [Status]) VALUES (3004, N'Nhạc trẻ remix', 5, 1)
SET IDENTITY_INSERT [dbo].[CD] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([id], [Name], [CMND], [Sdt], [QueQuan], [Trangthai]) VALUES (1, N'Trương Đặng Ngọc Phúc', N'192063', N'0836323309', N'Huế', 2)
INSERT [dbo].[KhachHang] ([id], [Name], [CMND], [Sdt], [QueQuan], [Trangthai]) VALUES (2, N'Phạm Thị Anh Tú', N'192064', N'01234567', N'Quảng Nam', 2)
INSERT [dbo].[KhachHang] ([id], [Name], [CMND], [Sdt], [QueQuan], [Trangthai]) VALUES (3, N'Hồ Quang Dũng', N'123456', N'1232211', N'Huế', 2)
INSERT [dbo].[KhachHang] ([id], [Name], [CMND], [Sdt], [QueQuan], [Trangthai]) VALUES (4, N'Trần Công Sơn', N'121111', N'322321', N'Quảng Trị', 2)
INSERT [dbo].[KhachHang] ([id], [Name], [CMND], [Sdt], [QueQuan], [Trangthai]) VALUES (7, N'Lực', N'123123', N'051566', N'Đà Nẵng', 2)
INSERT [dbo].[KhachHang] ([id], [Name], [CMND], [Sdt], [QueQuan], [Trangthai]) VALUES (8, N'Đặng Minh', N'19206124', N'0122211', N'Đặng Minh', 2)
INSERT [dbo].[KhachHang] ([id], [Name], [CMND], [Sdt], [QueQuan], [Trangthai]) VALUES (9, N'Trương Tấn Lực', N'123112', N'0123456', N'Huế', 2)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_KhachHang] FOREIGN KEY([idKH])
REFERENCES [dbo].[KhachHang] ([id])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_KhachHang]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillInfo_Bill] FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK_BillInfo_Bill]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK_BillInfo_CD] FOREIGN KEY([idCD])
REFERENCES [dbo].[CD] ([id])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK_BillInfo_CD]
GO
ALTER TABLE [dbo].[CD]  WITH CHECK ADD  CONSTRAINT [FK_CD_Category] FOREIGN KEY([idCategoryCD])
REFERENCES [dbo].[Category] ([id])
GO
ALTER TABLE [dbo].[CD] CHECK CONSTRAINT [FK_CD_Category]
GO
/****** Object:  StoredProcedure [dbo].[USP_DeleteCD]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_DeleteCD]
@id int
as
begin
	delete
	from CD
	where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetCDById]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetCDById]
@id int
as
begin
	select * from CD where id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetListBillByDate]
@ngaythue date, @ngaytra date
as
begin
	select k.Name as 'Tên Khách Hàng', b.NgayThue as 'Ngày thuê', b.NgayTra as 'Ngày trả', b.TotalPrice as 'Tổng giá tiền'
	from Bill as b, KhachHang as k
	where NgayThue >=@ngaythue and NgayTra <= @ngaytra and DaThanhToan = 1 and k.id = b.idKH
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListCustomer]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetListCustomer]
as
begin
	select ID , Name as 'Tên', CMND, Sdt as 'SĐT', QueQuan as ' Quê Quán',
	case 
		when Trangthai = 2 then N'Đã trả'
		else N'Đang thuê'
		end as 'Trạng thái' 
	from KhachHang
end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_InsertBill]
 @idKH int
 as
 begin
	insert dbo.Bill (
			NgayThue , 
			NgayTra ,
			idKH ,
			DaThanhToan
			)
values (
	GETDATE(),
	NULL,
	@idKH,
	0
) 
 end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[USP_InsertBillInfo]
 @idbill int , @idCD int, @count int
 as
 begin

	declare @isExitsBillInfo INT;
	declare @cdcount INT = 1;
	select @isExitsBillInfo = id, @cdcount = b.count FROM BillInfo as b where idBill = @idbill and idCD = @idCD

	if (@isExitsBillInfo > 0)
	begin
		declare @newCount int = @cdcount + @count
		if (@newCount > 0)
			update BillInfo set count = @cdcount + @count where idCD = @idCD
		else
			Delete dbo.BillInfo where idBill = @idbill and idCD = @idCD
	end
	else
	begin
		insert dbo.BillInfo (
			idBill , 
			idCD ,
			count
			)
		values (
			@idbill,
			@idCD,
			@count
	
		)
	end

	
 end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertCategory]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[USP_InsertCategory]
@nameccd nvarchar(50), @price int
as

begin
	insert into Category values(@nameccd, @price)
	if @@ROWCOUNT > 0 RETURN 1
	else return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ListCategory]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_ListCategory]
as
begin
	select * from Category
end
GO
/****** Object:  StoredProcedure [dbo].[USP_LoadList]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_LoadList]
as select * from CD
GO
/****** Object:  StoredProcedure [dbo].[USP_LoadListCD]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_LoadListCD]
as
begin
	select p.id, p.NameCD, ct.NameCCD, ct.Price,
	case 
		when p.Status = 1 then N'Còn đĩa'
		else N'Hết đĩa'
	end as [status]
	from CD as p inner join Category as ct on p.idCategoryCD = ct.id 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_LoadListKH]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_LoadListKH]
as select * from KhachHang
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Login]
@username nvarchar(50), @password nvarchar(50)
as
begin
	select * from Account where username = @username and password = @password
end
GO
/****** Object:  StoredProcedure [dbo].[USP_SearchCD]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_SearchCD]
@namecd nvarchar(50)
as
begin
	select p.id, p.NameCD, ct.NameCCD, ct.Price,
	case 
		when p.Status = 1 then N'Còn đĩa'
		else N'Hết đĩa'
	end as [status]
	from CD as p inner join Category as ct on p.idCategoryCD = ct.id
	where dbo.ufn_removeMark(NameCD) LIKE N'%' + dbo.ufn_removeMark(@namecd) + '%'
end
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 12/28/2021 9:47:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_UpdateAccount]
@username nvarchar(50), @displayname nvarchar(50) , @password nvarchar(50), @newpassword nvarchar(50) 
as
begin
	declare @isRightPass int = 0

	select @isRightPass = COUNT(*) from Account where username = @username and password = @password

	if(@isRightPass = 1)
	begin
		if(@newpassword = null or @newpassword ='')
		begin
			update Account set displayname = @displayname where username = @username
		end
		else
			update Account set displayname = @displayname , password = @newpassword where username = @username
	end
end
GO
USE [master]
GO
ALTER DATABASE [ManagerCD] SET  READ_WRITE 
GO
