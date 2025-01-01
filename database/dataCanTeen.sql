CREATE DATABASE CanTeenManager
GO

USE CanTeenManager
GO


create TABLE TableFood
(
      id int IDENTITY PRIMARY KEY,
	  name NVARCHAR (100) not null default N'ban chua dat ten',
	  status NVARCHAR (100) not null default N'trống',
)
GO

create table TypeCommodity
(
    id int identity primary key ,
	name nvarchar(100) not null default N'thực phẩm tươi'
)
go

create TABLE Commodity
(
      id int IDENTITY PRIMARY KEY,
	  name NVARCHAR (100) not null default N'hang hoa',
	  idType int not null,
	  SoLuong INT DEFAULT 1,
	  dateImport date not null default GetDate(),
	  foreign key(idType) references dbo.TypeCommodity(id)
)
GO



CREATE TABLE Account
(
     displayName NVARCHAR(100)not null,
	 userName NVARCHAR(100) PRIMARY KEY,
	 passWord NVARCHAR(100) NOT NULL default 0,
	 type int not null default 0

)
go

create table FoodCategory
(
    id int identity primary key ,
	name nvarchar(100) not null default N'A'
)
go
create table Food
(
     id int identity primary key ,
	 name nvarchar (100) not null default N'chua dat ten',
	 idCategory int not null,
	 price float not null,
	 foreign key(idCategory) references dbo.FoodCategory(id)
)
go

create table bill
(
      id int identity primary key ,
	  idTable int not null,
	  dateCheckin date not null default GetDate(),
	  dateCheckout date ,
	  Status int not null,
	  discount int default 0,
	  totalPrice decimal(18, 2),
	  foreign key (idTable) references dbo.TableFood(id)
)
go

create table billinfo
(
   id int identity primary key,
   idBill int not null,
   idFood  int not null,
   count int not null default 0,
   foreign key (idBill) references  dbo.Bill(id),
   foreign key (idFood) references dbo.Food(id)
)
go


insert into dbo.TypeCommodity(name)
values (N'thực phẩm tươi'),
       (N'hàng khô'),
	   (N'nước giải khát')

insert into dbo.Food (name,idCategory,price)
values (N'bún bò',N'1',30),
       (N'bún riêu',N'1',30),
	   (N'bún mắm',N'1',35),
	   (N'cơm gà',N'2',40),
	   (N'sơm sườn',N'2',40)

insert into dbo.Account (userName,displayName,passWord,type)
values (N'k9',N'admin',N'1',1),
		( N'k8',N'nhan vien',N'1',0)

insert into dbo.TableFood (name,status)
values (N'bàn 1',N'trống'),
       (N'bàn 2',N'trống'),
	   (N'bàn 3',N'trống'),
	   (N'bàn 4',N'trống'),
	   (N'bàn 5',N'trống'),
	   (N'bàn 6',N'trống')

insert into dbo.TableFood (name,status)
values (N'bàn 7',N'trống'),
       (N'bàn 8',N'trống'),
	   (N'bàn 9',N'trống'),
	   (N'bàn 10',N'trống'),
	   (N'bàn 11',N'trống'),
	   (N'bàn 12',N'trống')

insert into dbo.TableFood (name,status)
values (N'bàn 13',N'trống'),
       (N'bàn 14',N'trống'),
	   (N'bàn 15',N'trống'),
	   (N'bàn 16',N'trống'),
	   (N'bàn 17',N'trống'),
	   (N'bàn 18',N'trống')


insert into dbo.FoodCategory(name)
values (N'cơm'),
       (N'nước giải khát'),
	   (N'bún'),
	   (N'thức ăn nhanh'),
	   (N'bánh ngọt')
      


create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as
begin
     select * from dbo.Account where userName=@userName and passWord=@passWord
end
go



create PROC USP_GetAccountByUserName
@userName nvarchar(100)
as
begin
   select * from dbo.Account where userName=@userName
end
GO

create proc USP_GetTableList
as Select * from dbo.TableFood
go


insert into dbo.bill( idTable, dateCheckin ,dateCheckout ,Status)
values (9,getdate(),getdate(),0),
(10,getdate(),getdate(),0),
       (2,getdate(),null,0),
	   (6,getdate(),null,0),
	   (10,getdate(),null,0),
	   (5,getdate(),getdate(),1)



      
--thêm món 

create proc USP_InsertBill
@idTable int
as
begin
   insert dbo.bill(dateCheckin,dateCheckout,idTable,status,discount)
   values(getdate(),null,@idTable,0,0)
end
go

create proc USP_InsertBillInfo
@idBill int ,@idFood int ,@count int
as
begin
    declare @isExitsBillInfo int
	declare @FoodCount int =1
	select @isExitsBillInfo =id , @FoodCount =b.count 
	from dbo.billinfo as b 
	where idBill=@idBill and idFood =@idFood
	if(@isExitsBillInfo > 0)
	begin
	   declare @newCount int = @FoodCount + @count
	   if(@newCount > 0)
	   UPDATE dbo.billinfo SET count= @FoodCount + @count where idFood = @idFood and idBill=@idBill
	   else
	     delete dbo.billinfo where idBill=@idBill and idFood=@idFood
	end
	else
	begin
	    insert dbo.billinfo(idBill,idFood,count)
	    values (@idBill,@idFood,@count)
	end  
end
go

create proc USP_SubBillInfo
@idBill int ,@idFood int ,@count int
as
begin
    declare @isExitsBillInfo int
	declare @FoodCount int ;

	select @isExitsBillInfo = id , @FoodCount =b.count 
	from dbo.billinfo as b 
	where idBill=@idBill and idFood =@idFood
	if(@isExitsBillInfo > 0)
	begin
	   declare @newCount int = @FoodCount - @count
	   if(@newCount <=0)
	   delete dbo.billinfo where idBill=@idBill and idFood=@idFood
	   else
	   UPDATE dbo.billinfo SET count= @newCount where idFood = @idFood and idBill=@idBill
	   return 1;
	end 
	return 0;
end





--update trạng thái status của table sau khi thah toán hặc thêm món 
create trigger UTG_UpdateBillInfo
on dbo.billinfo for insert, update
as
begin
	declare @idBill int 
	select @idBill=idBill from Inserted 
	declare @idTable int 

	select @idTable =idTable from dbo.bill where id=@idBill and status =0
	declare @count int
	select @count=count(*) from dbo.billinfo where idBill= @idBill
	
	if(@count>0)
	update dbo.TableFood set status =N'trống' where id=@idTable
	else
	update dbo.TableFood set status =N'có người' where id=@idTable
end
go

create trigger UTG_UpdateTable
on dbo.TableFood for update
as
begin
    declare @idTable int
	declare @status nvarchar(100)

	select @idTable =id ,@status =Inserted.status from Inserted

	declare @idBill int
	select @idBill =id from dbo.bill where idTable =@idTable and status =0
	
	declare @countBillInfo int
	select @countBillInfo =count(*) from dbo.billinfo where idBill=@idBill
	if(@countBillInfo > 0 )--and @status <> N'có người')
	  update dbo.TableFood set status =N'có người' where id=@idTable
	else --if(@countBillInfo < 0 )--and @status <> N'trống')
		update dbo.TableFood set status =N'trống' where id=@idTable
end
go

create trigger UTG_UpdateBill
on dbo.bill for update
as
begin
	declare @idBill int 
	select @idBill =id from Inserted 
	 
	declare @idTable int
	select @idTable =idTable from dbo.bill where id=@idBill 
	declare @count int =0

	select @count =count(*) from dbo.bill where idTable =@idTable and status =0
	
	if(@count = 0 )
	  update dbo.TableFood set status =N'trống' where id=@idTable --
	
end

go

--test


create proc USP_SwitchTable
@idTable1 int, @idTable2 int
as 
begin
	declare @idFirstBill int
	declare @idSeconrdBill int

	declare @isFirstTablEmty int =1
	declare @isSecondTablEmty int =1

	select @idSeconrdBill=id from dbo.bill where idTable = @idTable2 and Status = 0
	select @idFirstBill=id from dbo.bill where idTable = @idTable1 and Status = 0

	if(@idFirstBill is null )
		begin
	
			insert dbo.bill(dateCheckin,dateCheckout,idTable,status, discount)
			values(getdate(),null,@idTable1 ,0,0)
			select @idFirstBill=MAX(id) from dbo.bill where idTable =@idTable1 and status =0
	 
		end

	select @isFirstTablEmty =count(*) from dbo.billinfo where idBill=@idFirstBill

	if(@idSeconrdBill is null)
	begin
	
		insert dbo.bill(dateCheckin,dateCheckout,idTable,status, discount)
		values(getdate(),null,@idTable2 ,0,0)
		select @idSeconrdBill=MAX(id) from dbo.bill where idTable =@idTable2 and status =0
	
	end

	select @isSecondTablEmty =count(*) from dbo.billinfo where idBill=@idSeconrdBill

	select id into IDBillInfoTable from dbo.billinfo where idBill =@idSeconrdBill
	update dbo.billinfo set idBill= @idSeconrdBill where idBill=@idFirstBill
	update dbo.billinfo set idBill=@idFirstBill where id in (select * from IDBillInfoTable)
	drop table IDBillInfoTable
	if(@isFirstTablEmty=0)
	begin
	update dbo.TableFood set status=N'trống' where id=@idTable2
	delete from bill where id=@idSeconrdBill
	end
	if(@isSecondTablEmty=0)
	begin
	update dbo.TableFood set status=N'trống' where id=@idTable1
	delete from bill where id=@idFirstBill
	end

end
go

create proc USP_MegerTable
@idTable1 int, @idTable2 int
as 
begin
	declare @idFirstBill int
	declare @idSeconrdBill int

	declare @isFirstTablEmty int =1
	declare @isSecondTablEmty int =1

	select @idSeconrdBill=id from dbo.bill where idTable = @idTable2 and Status = 0
	select @idFirstBill=id from dbo.bill where idTable = @idTable1 and Status = 0
	--tham khỏa 
	
   
	--tham khảo 
	if(@idFirstBill is null )
		begin
	
			insert dbo.bill(dateCheckin,dateCheckout,idTable,status, discount)
			values(getdate(),null,@idTable1 ,0,0)
			select @idFirstBill=MAX(id) from dbo.bill where idTable =@idTable1 and status =0
	 
		end
	--lấy dnah sách billibfo của bill 1 
	select @isFirstTablEmty =count(*) from dbo.billinfo where idBill=@idFirstBill

	if(@idSeconrdBill is null)
	begin
	
		insert dbo.bill(dateCheckin,dateCheckout,idTable,status, discount)
		values(getdate(),null,@idTable2 ,0,0)
		select @idSeconrdBill=MAX(id) from dbo.bill where idTable =@idTable2 and status =0
	
	end
	--lấy danh sách billinfo của bill 2 
	select @isSecondTablEmty =count(*) from dbo.billinfo where idBill=@idSeconrdBill
	if(@isFirstTablEmty=0 and @isSecondTablEmty=0)
	begin
		delete from bill where id=@idSeconrdBill
		delete from bill where id=@idFirstBill
		update dbo.TableFood set status=N'trống' where id=@idTable1
		update dbo.TableFood set status=N'trống' where id=@idTable2
	end
	if(@isFirstTablEmty=0 and @isSecondTablEmty > 0)
	begin
		delete from bill where id=@idFirstBill
		update dbo.TableFood set status=N'trống' where id=@idTable1
	end
	if(@isFirstTablEmty > 0 and @isSecondTablEmty=0)
	begin
		update dbo.billinfo set idBill= @idSeconrdBill where idBill=@idFirstBill
		update dbo.TableFood set status=N'trống' where id=@idTable1
		delete from bill where id=@idFirstBill
	end
	if(@isFirstTablEmty > 0 and @isSecondTablEmty > 0)
	begin
		 -- Lấy danh sách billinfo của bàn 1
		declare @billinfo1 cursor
		set @billinfo1 = cursor for
		select idFood, count from billinfo where idBill = @idFirstBill

		declare @idFood int
		declare @count int

		open @billinfo1
		fetch next from @billinfo1 into @idFood, @count

		while @@FETCH_STATUS = 0
		begin
			-- Kiểm tra xem món này đã tồn tại trong bill của bàn 2 chưa
			declare @existingCount int = 0
			select @existingCount = count 
			from billinfo 
			where idBill = @idSeconrdBill and idFood = @idFood

			if @existingCount > 0
			begin
				 -- Nếu món đã tồn tại, cộng thêm số lượng
				update billinfo 
				set count = count + @count
				where idBill = @idSeconrdBill and idFood = @idFood
			end
			else
			begin
				 -- Nếu món chưa tồn tại, chuyển món từ bàn 1 sang bàn 2
				insert into billinfo(idBill, idFood, count)
				values(@idSeconrdBill, @idFood, @count)
			end

        fetch next from @billinfo1 into @idFood, @count
		end

		close @billinfo1
		deallocate @billinfo1

		-- Xóa bill cũ và cập nhật trạng thái bàn
		update dbo.TableFood set status = N'trống' where id = @idTable1
		delete from billinfo where idBill = @idFirstBill
		delete from bill where id = @idFirstBill
	end
end
go



--hiển thị danh sách hóa đơn theo khoảng thời gian 

create proc USP_GetListBillByDate
@checkIn date, @checkout date
as
begin

select t.name,b.dateCheckin,b.dateCheckout,b.discount ,b.totalPrice
from dbo.bill as b,dbo.TableFood as t
where dateCheckin >= @checkIn 
and dateCheckout <=@checkout 
and b.status =1
and t.id=b.idTable 

end
GO

create proc USP_GetListBillByDateAndPage
@checkIn date, @checkout date, @pageNum int
as
begin
	declare @pageRows int = 10
	declare @selectRows int = @pageRows 
	declare @exceptRows int = (@pageNum -1)* @pageRows


	;with BillShow as( select b.id ,t.name,b.dateCheckin,b.dateCheckout,b.discount ,b.totalPrice
	from dbo.bill as b,dbo.TableFood as t
	where dateCheckin >= @checkIn 
	and dateCheckout <=@checkout 
	and b.status =1
	and t.id=b.idTable )
	SELECT TOP (@selectRows) * FROM BillShow where id not in
	(SELECT top (@exceptRows) id  FROM BillShow)

end
GO
create proc USP_GetNumBillByDate
@checkIn date, @checkout date
as
begin

select count(*)
from dbo.bill as b,dbo.TableFood as t
where dateCheckin >= @checkIn 
and dateCheckout <=@checkout 
and b.status =1
and t.id=b.idTable 

end

create proc USP_UpdateAccount
@username nvarchar(100),@displayname nvarchar(100),@password nvarchar(100),@newPassword nvarchar(100)
as
begin
	declare @isRigtPass int =0
	select @isRigtPass =count(*) from dbo.Account where userName=@username and passWord=@password
	if(@isRigtPass =1)
	begin
		if(@newPassword = null or @newPassword='')
		begin
			update dbo.Account set displayName=@displayname WHERE userName=@username
		end
		else
			update dbo.Account set displayName=@displayname , passWord=@newPassword where userName=@username
	end



end
go


insert into dbo.Food (name,idCategory,price)
values (N'bông lan trứng muối',N'5',40000),
		(N'tiramisu',N'5',35000),
		(N'su kem chiên',N'5',10000),
		(N'bánh crep',N'5',15000),
		(N'',N'5',40000),
  
go



create trigger UTG_DeleteBillInfo
on dbo.BillInfo for delete
as
begin
	declare @idBillInfo int
	declare @idBill int
	select @idBillInfo =id ,@idBill =deleted.idBill from deleted
	declare @idTable int 
	select @idtable = idTable from dbo.bill where id=@idBill
	declare @count int =0
	select @count =count(*) from dbo.billinfo as bi , dbo.bill as b where b.id =bi.idBill  and b.id = @idBill and status = 0
	if(@count =0)
	begin
		update dbo.TableFood set status=N'trống' where id=@idTable
	end

end
go

create PROC USP_GetFoodDetails
AS
BEGIN
    SELECT 
        f.id,
        f.name AS name,
        c.name AS nameCategory,
        f.price
    FROM
        Food AS f , FoodCategory AS c where  f.idCategory = c.id;
END
go

create function [dbo].[fuConvertToUnsignl] (@strInput nvarchar(4000)) returns nvarchar(4000) as begin if @strInput is null return @strInput if @strInput = '' return @strInput declare @RT nvarchar(4000) DECLARE @SIGN_CHARS nchar(136) declare @UNSIGN_CHARS nchar (136) set @SIGN_CHARS = N'ăâđêôơưàảạáằắẵẳặấầẩẫậẻẽéèẹểễếềệ íìỉĩịỏõòóọổỗộốồởỡờớợúùủũụửữừứựỷýỳỹỵ  ĂÂĐÊÔƠƯÁÀẢÃẠẲẴẮẰẶẨẪẤẦẬẺÈÉẼẸỂẾỀỄỆỈÍÌĨỊ ÒÓỎÕỌỔỐỒỖỘỞỜỚỢỠÚÙỦŨỤỬỮỪỨỰÝỲỶỸỴ'   +nchar(272) +nchar(208) set @UNSIGN_CHARS =N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy  AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYY'   DECLARE @counter int declare @COUNTER1 int set @counter =1 while (  @counter <= len(@strinput)) begin set @COUNTER1 =1 while (@COUNTER1 <= len(@SIGN_CHARS)+1) begin if unicode (SUBSTRING(@SIGN_CHARS, @COUNTER1,1))= unicode(substring(@strInput, @counter ,1)) begin if @counter=1 set @strInput =substring(@UNSIGN_CHARS, @COUNTER1,1) + substring(@strinput, @counter + 1,len(@strInput) - @counter) break end set @counter1 =@counter1 +1 end set @counter =@counter + 1 end set @strInput=replace(@strInput,' ','-') return @strInput end

select * from billinfo