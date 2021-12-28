select * from Category

Create proc USP_InsertCategory
@nameccd nvarchar(50), @price int
as

begin
	insert into Category values(@nameccd, @price)
	if @@ROWCOUNT > 0 RETURN 1
	else return 0;
end
go

create proc USP_ListCategory
as
begin
	select * from Category
end

exec  USP_ListCategory

insert Category values(?, ?)

insert Category(NameCCD, Price) values('Phim đen', 6000)

update dbo.Category set price = {1} , NameCCD = N'{0}'  where NameCCD = N'{0}'

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

select * from Category where dbo.ufn_removeMark(NameCCD) LIKE N'%' + dbo.ufn_removeMark(N'{0}') + '%' 

select * from Cd

INSERT dbo.CD (NameCD, idCategoryCD, Status) values (N'Siêu nhân gao' , 3, 1)

alter proc USP_LoadListCD
as
begin
	select p.id, p.NameCD, ct.NameCCD, ct.Price,
	case 
		when p.Status = 1 then N'Còn đĩa'
		else N'Hết đĩa'
	end as [status]
	from CD as p inner join Category as ct on p.idCategoryCD = ct.id 
end
go


alter proc USP_SearchCD
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
go


exec USP_SearchCD N'Lời nguyề'

alter proc USP_GetCDById
@id int
as
begin
	select * from CD where id = @id
end
go

create proc USP_DeleteCD
@id int
as
begin
	delete
	from CD, Category
	where id = @id
end
go

insert into Account values('phuc','123',N'Phúc', 1)
insert into Account values('tu','1',N'Tú', 0)
create proc USP_Login
@username nvarchar(50), @password nvarchar(50)
as
begin
	select * from Account where username = @username and password = @password
end
go

create proc USP_UpdateAccount
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
go

create proc USP_LoadList
as select * from CD

exec USP_Login 'phuc' , '123'

exec USP_DeleteCD 1002
exec USP_LoadListCD
select * from CD where idCategoryCD = 2

Select * from dbo.Account where username = 'tu'

Select * from dbo.Account where username = 'phuc'

select * from Bill

select* from BillInfo

insert dbo.Bill (
			NgayThue , 
			NgayTra ,
			idCD ,
			DaThanhToan
			)
values (
	GETDATE(),
	NULL,
	1,
	0
)
insert dbo.Bill (
			NgayThue , 
			NgayTra ,
			idCD ,
			DaThanhToan
			)
values (
	GETDATE(),
	NULL,
	1,
	0
)

insert dbo.BillInfo (
			idBill , 
			idCD ,
			count
			)
values (
	1,
	1,
	2
	
)
insert dbo.BillInfo (
			idBill , 
			idCD ,
			count
			)
values (
	2,
	3,
	4
	
)

select * from KhachHang
delete  from KhachHang

update KhachHang set Trangthai = 1 where id = 4

insert KhachHang values(N'Trương Đặng Ngọc Phúc', '192063', '0836323309', N'Huế', 1)
insert KhachHang values(N'Phạm Thị Anh Tú', '192064', '01234567', N'Quảng Nam', 1)
insert KhachHang values(N'Hồ Quang Dũng', '123456', '1232211', N'Huế', 1)
insert KhachHang values(N'Trần Công Sơn', '121111', '322321', N'Quảng Trị', 0)
DBCC CHECKIDENT (KhachHang, RESEED, 0); -- Reset id
GO
create proc USP_LoadListKH
as select * from KhachHang

exec USP_LoadListKH

select * from Bill where idKH = 1 and DaThanhToan = 0

 select * from BillInfo where idbill = 2

 select c.NameCD, bi.count, ct.Price, ct.Price*bi.count as TotalPrice from BillInfo as bi, Bill as b, CD as c inner join Category as ct on c.idCategoryCD = ct.id
 where bi.idBill = b.id and bi.idCD = c.id and b.DaThanhToan=0 and b.idKH = 2

 select * from CD where idCategoryCD = 2
 select * from Category 

 CREATE PROC USP_InsertBill
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
 go

 alter proc USP_InsertBillInfo
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
 go

 select max(id) from Bill

 update	bill set DaThanhToan = 1 where id = 1

alter TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT

	select @idBill = idBill from Inserted

	declare @idKH int

	select @idKH = idKH from dbo.Bill where id = @idBill and DaThanhToan = 0

	declare @count int
	select @count =count(*) from dbo.BillInfo where idBill = @idBill

	if (@count > 0)
	begin
		
		update dbo.KhachHang set Trangthai = 1 where id = @idKH
	end
	else 
	begin
		
		update KhachHang set Trangthai = 2 where id = @idKH
	end 
END
GO
select * from Bill
select * from khachhang
alter trigger UTG_UpdateBill
on dbo.Bill for UPDATE 
as
begin
	declare @idBill int
	select @idBill = id from Inserted

	declare @idKH int

	select @idKH = idKH from dbo.Bill WHERE id = @idBill
	
	declare @count int

	select @count = COUNT(*) from dbo.Bill where idKH = @idKH and DaThanhToan = 0
	  
	if(@count = 0)
		update dbo.KhachHang set Trangthai = 2 where id = @idKH

end
go

select * from khachhang

delete billinfo
delete bill

select * from bill

alter proc USP_GetListBillByDate
@ngaythue date, @ngaytra date
as
begin
	select k.Name as 'Tên Khách Hàng', b.NgayThue as 'Ngày thuê', b.NgayTra as 'Ngày trả', b.TotalPrice as 'Tổng giá tiền'
	from Bill as b, KhachHang as k
	where NgayThue >=@ngaythue and NgayTra <= @ngaytra and DaThanhToan = 1 and k.id = b.idKH
end
go

create proc USP_GetListCustomer
as
begin
	select ID , Name as 'Tên', CMND, Sdt as 'SĐT', QueQuan as ' Quê Quán',
	case 
		when Trangthai = 2 then N'Đã trả'
		else N'Đang thuê'
		end as 'Trạng thái' 
	from KhachHang
end
go



exec USP_GetListCustomer

select * from KhachHang where dbo.ufn_removeMark(Name) LIKE N'%' + dbo.ufn_removeMark(N'{0}') + '%' or dbo.ufn_removeMark(CMND) LIKE '%' + dbo.ufn_removeMark('{0}') + '%'

insert into KhachHang ([Name], CMND, Sdt, QueQuan, Trangthai) values(N'Lực', '123123', '051566', N'Đà Nẵng', 2)

update KhachHang set [Name] = N'Phúc' , CMND  = '12122' , Sdt = '0832323' , QueQuan = N'Huế' , Trangthai = 1 where id = 6

select username, displayname, type from Account

select * from Account

INSERT Account(username, password, displayname, Type) values (N'{0}','0' , N'{1}', {2})