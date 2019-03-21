UPDATE [test2011].[dbo].[Driver]
   SET [DName] = @DName,
      [Sex] =@Sex,
      [Age] = @Age,
      [Tel] = @Tel, 
      [Pwd] = @Pwd
 WHERE [EmpID] =@EmpID
GO

INSERT INTO [test2011].[dbo].[Driver]
           ([EmpID]
           ,[DName]
           ,[Sex]
           ,[Age]
           ,[Tel]
           ,[Pwd])
     VALUES(@EmpID,@DName,@Sex,@Age,@Tel,@Pwd)
GO

DELETE FROM [test2011].[dbo].[Driver]
      WHERE [EmpID] =@EmpID
GO

SELECT [EmpID]
      ,[DName]
      ,[Sex]
      ,[Age]
      ,[Tel]
      ,[Pwd]
  FROM [test2011].[dbo].[Driver]
GO

INSERT INTO [test2011].[dbo].[Lines]
           ([LineID]
           ,[StartP]
           ,[EndP]
           ,[Distance])
     VALUES(@LineID,@StartP,@EndP,@Distance)
GO

UPDATE [test2011].[dbo].[Lines]
   SET [StartP] = @StartP
      ,[EndP] = @EndP
      ,[Distance] = @Distance
 WHERE [LineID] = @LineID
      
GO

DELETE FROM [test2011].[dbo].[Lines]
      WHERE [LineID] = @LineID
GO
SELECT [LineID]
      ,[StartP]
      ,[EndP]
      ,[Distance]
  FROM [test2011].[dbo].[Lines]
   WHERE [LineID] = @LineID
GO


INSERT INTO [test2011].[dbo].[Timetable]
           ([LineID]
           ,[EmpID]
           ,[BusID]
           ,[StartTime])
     VALUES(@LineID,@EmpID,@BusID,@StartTime)
GO

UPDATE [test2011].[dbo].[Timetable]
   SET [EmpID] =@EmpID
      ,[BusID] = @BusID
      ,[StartTime] =@StartTime
 WHERE [LineID] = @LineID
GO

DELETE FROM [test2011].[dbo].[Timetable]
      WHERE [LineID] = @LineID
GO

SELECT [LineID]
      ,[EmpID]
      ,[BusID]
      ,[StartTime]
  FROM [test2011].[dbo].[Timetable]
  WHERE [LineID] = @LineID
GO

select EmpID,COUNT(*) 发车次数
from Timetable
group by EmpID

select *
from Buses a,Driver b,Lines c,Timetable d
where a.BusID=d.BusID and b.EmpID=d.EmpID and c.LineID=d.LineID and c.LineID=@LineID or c.StartP=@StartP





