use test2009
select *
from Orders inner join OrderDetails on Orders.OrderID=OrderDetails.OrderID
where OrderID=@OrderID

select *
from Orders
where OrderID in(select OrderID 
					from OrderDetails 
					where ProductID in(select ProductID 
										from Product 

										where SupplierName=@Name))


select OrderID ,SUM(UnitPrice*Quantity) 销售总金额
from OrderDetails
group by OrderID

select a.ProductID ,SUM(a.UnitPrice*a.Quantity)/SUM(a.Quantity) 平均销售单价,SUM(a.Quantity)总销售数量,
MAX(UnitPrice) 最高单价,
MIN(UnitPrice ) 最低单价
from OrderDetails a
group by ProductID


INSERT INTO [test2009].[dbo].[Product]
           ([ProductID]
           ,[ProductName]
           ,[SupplierName])
     VALUES(@ProductID,@ProductName,@SupplierName)
GO

UPDATE [test2009].[dbo].[Product]
   SET [ProductName] = @ProductName,[SupplierName] =@SupplierName
 WHERE [ProductID] = @ProductID
GO

