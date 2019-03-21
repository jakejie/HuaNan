INSERT INTO [emp].[dbo].[Employee]
           ([EmpID]
           ,[EmpName]
           ,[EPlace])
     VALUES(@EmpID,@EmpName,@EPlace)
GO

DELETE FROM [emp].[dbo].[Employee]
       WHERE [EmpID] = @EmpID
GO

UPDATE [emp].[dbo].[Employee]
   SET [EmpName] = @EmpName
      ,[EPlace] = @EPlace
 WHERE [EmpID] = @EmpID
GO

SELECT [EmpID]
      ,[EmpName]
      ,[EPlace]
  FROM [emp].[dbo].[Employee]
GO

select a.EmpID 员工号,b.EmpName 员工姓名,c.CName 公司名称,c.CPlace 公司所在地,
from Works a,Employee b,Company c
where a.CID=c.CID and a.EmpID=b.EmpID and b.EmpName=@EmpName

select EmpID,Salary 总工资
from Works
where CID=(select CID from Company where CName=@CName)

select EmpID,SUM(Salary) 工资
from Works
group by EmpID
having COUNT(*)>1