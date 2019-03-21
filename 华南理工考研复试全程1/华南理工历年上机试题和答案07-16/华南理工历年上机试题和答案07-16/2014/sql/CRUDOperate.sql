INSERT INTO [test2014].[dbo].[TEACHERS]
           ([TNo]
           ,[TName]
           ,[Dept]
           ,[ReNo])
     VALUES(@TNo,@TName,@Dept,@ReNo)
GO

UPDATE [test2014].[dbo].[TEACHERS]
   SET [TName] = @TName
      ,[Dept] = @Dept
      ,[ReNo] = @ReNo
 WHERE [TNo] = @TNo
GO

DELETE FROM [test2014].[dbo].[TEACHERS]
      WHERE [TNo] = @TNo
GO
SELECT [TNo]
      ,[TName]
      ,[Dept]
      ,[ReNo]
  FROM [test2014].[dbo].[TEACHERS]
GO

select a.TName 教师名, b.CName 课程名,b.CTime 课时
from TEACHERS a,COURSES b
where a.TNo=b.TNo and a.TNo=@TNo

select a.TName 教师名,b.CNo 课程号, b.CName 课程名,b.CTime 课时
from TEACHERS a,COURSES b
where a.TNo=b.TNo and a.TNo in (select TNo
								from COURSES
								group by TNo
								having COUNT(*)=1)


select a.TName,SUM(b.CTime*c.Salary) 薪水
from TEACHERS a,COURSES b,REMUNERATIONS c
where a.TNo=b.TNo and a.ReNo=c.ReNo
group by a.TName,a.TNo
order by 薪水 desc
 
