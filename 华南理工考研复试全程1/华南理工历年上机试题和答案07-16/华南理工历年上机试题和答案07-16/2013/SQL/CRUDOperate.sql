INSERT INTO [test2013].[dbo].[TEACHERS]
           ([TNo]
           ,[TNmae]
           ,[TSex])
     VALUES(@TNo,@TNmae,@TSex)
GO

DELETE FROM [test2013].[dbo].[TEACHERS]
       WHERE [TNo] =@TNo
GO

SELECT [TNo]
      ,[TNmae]
      ,[TSex]
  FROM [test2013].[dbo].[TEACHERS]
   WHERE [TNo] =@TNo or [TNmae] =@TNmae or [TSex] = @TSex
GO

UPDATE [test2013].[dbo].[TEACHERS]
   SET [TNmae] =@TNmae
      ,[TSex] = @TSex
 WHERE [TNo] =@TNo
GO

select a.TNo,c.TNmae,b.CName,b.CTime,a.Term,a.WYear
from WORKS a,COURSES b,TEACHERS c
where a.CNo=b.CNo and c.TNo=a.TNo and a.TNo='T01'


select distinct WYear
from WORKS

select a.TNo,c.TNmae,b.CName,b.CTime,a.Term,a.WYear
from WORKS a,COURSES b,TEACHERS c
where a.CNo=b.CNo and c.TNo=a.TNo and a.WYear=@WYear



select c.TNmae 教师名,b.CName 课程名
from WORKS a,COURSES b,TEACHERS c
where a.CNo=b.CNo and c.TNo=a.TNo and a.TNo in(select TNo
												from WORKS
												group by TNo
												having COUNT(*)>1)