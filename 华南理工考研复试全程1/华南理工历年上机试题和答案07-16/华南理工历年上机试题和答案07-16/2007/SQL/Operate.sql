INSERT INTO [test2007].[dbo].[Employee]
           ([EmpID]
           ,[EmpName]
           ,[Salary]
           ,[DeptID])
     VALUES(@EmpID,@EmpName,@Salary,@DeptID)
GO

UPDATE [test2007].[dbo].[Employee]
   SET [EmpName] = @EmpName
      ,[DeptID] = @DeptID
 WHERE EmpID=@EmpID
GO

INSERT INTO [test2007].[dbo].[Department]
           ([DeptID]
           ,[DeptName]
           ,[EmpID])
     VALUES
           (@DeptID,@DeptName,@EmpID)
GO

UPDATE [test2007].[dbo].[Department]
   SET [DeptName] = @DeptName,[EmpID] = @EmpID
 WHERE DeptID=@DeptID
GO

select * from Employee where EmpID=
(Select EmpID From Department where DeptID=
(select DeptID From Employee where EmpName='ÕÅÈý'))