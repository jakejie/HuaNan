using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Demo2011
{
    public partial class FormMain : Form
    {

        public FormMain()
        {

            InitializeComponent();
        }

        #region Buses表操作
        private void btnBAdd_Click(object sender, EventArgs e)
        {
            string sql = "insert into Buses values(@BusID,@Supplier)";
            SqlParameter[] para = { new SqlParameter("@BusID", txtBusID.Text), 
                                      new SqlParameter("@Supplier", txtSupplier.Text) };
            DBHelperSQL.TableChange(sql,para);
            BusesShow();
        }

        private void btnBDelete_Click(object sender, EventArgs e)
        {
            string sql = "delete Buses where BusID=@BusID";
            SqlParameter[] para = { new SqlParameter("@BusID", txtBusID.Text)};
            DBHelperSQL.TableChange(sql, para);
            BusesShow();
        }

        private void btnBUpdate_Click(object sender, EventArgs e)
        {
            string sql = "update Buses set Supplier=@Supplier where BusID=@BusID";
            SqlParameter[] para = { new SqlParameter("@BusID", txtBusID.Text), 
                                      new SqlParameter("@Supplier", txtSupplier.Text) };
            DBHelperSQL.TableChange(sql, para);
            BusesShow();
        }

        private void btnBSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Buses where BusID=@BusID or Supplier=@Supplier";
            SqlParameter[] para = { new SqlParameter("@BusID", txtBusID.Text), 
                                      new SqlParameter("@Supplier", txtSupplier.Text) };
            dvB.DataSource = DBHelperSQL.TableSelect(sql, para);

        }
        public void BusesShow()
        {
            string sql = "select * from Buses";
            dvB.DataSource = DBHelperSQL.TableSelect(sql);
        }
        #endregion

        #region Driver表操作
        private void btnDAdd_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [test2011].[dbo].[Driver]
                               ([EmpID]
                               ,[DName]
                               ,[Sex]
                               ,[Age]
                               ,[Tel]
                               ,[Pwd])
                         VALUES(@EmpID,@DName,@Sex,@Age,@Tel,@Pwd)";
            SqlParameter[] para = { new SqlParameter("@EmpID", txtEmpID.Text), 
                                      new SqlParameter("@DName", txtDName.Text),
                                      new SqlParameter("@Sex", txtSex.Text),
                                      new SqlParameter("@Age", txtAge.Text),
                                      new SqlParameter("@Tel", txtTel.Text),
                                      new SqlParameter("@Pwd", txtPwd.Text)};
            DBHelperSQL.TableChange(sql, para);
            DriverShow();
        }

        private void btnDDelete_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM [test2011].[dbo].[Driver]
                             WHERE [EmpID] =@EmpID";
            SqlParameter[] para = { new SqlParameter("@EmpID", txtEmpID.Text)};
            DBHelperSQL.TableChange(sql, para);
            DriverShow();
        }

        private void btnDUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE [test2011].[dbo].[Driver]
                           SET [DName] = @DName,
                              [Sex] =@Sex,
                              [Age] = @Age,
                              [Tel] = @Tel, 
                              [Pwd] = @Pwd
                         WHERE [EmpID] =@EmpID";
            SqlParameter[] para = { new SqlParameter("@EmpID", txtEmpID.Text), 
                                      new SqlParameter("@DName", txtDName.Text),
                                      new SqlParameter("@Sex", txtSex.Text),
                                      new SqlParameter("@Age", txtAge.Text),
                                      new SqlParameter("@Tel", txtTel.Text),
                                      new SqlParameter("@Pwd", txtPwd.Text)};
            DBHelperSQL.TableChange(sql, para);
            DriverShow();
        }

        private void btnDSearch_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT [EmpID]
                              ,[DName]
                              ,[Sex]
                              ,[Age]
                              ,[Tel]
                              ,[Pwd]
                          FROM [test2011].[dbo].[Driver]
                            where [EmpID] =@EmpID";
            SqlParameter[] para = { new SqlParameter("@EmpID", txtEmpID.Text)};
            dvD.DataSource=DBHelperSQL.TableSelect(sql, para);
            
        }
        public void DriverShow()
        {
            string sql = "select * from Driver";
            dvD.DataSource = DBHelperSQL.TableSelect(sql);
        }
        #endregion

        #region Lines表操作
        private void btnLAdd_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [test2011].[dbo].[Lines]
                               ([LineID]
                               ,[StartP]
                               ,[EndP]
                               ,[Distance])
                         VALUES(@LineID,@StartP,@EndP,@Distance)";
            SqlParameter[] para = { new SqlParameter("@LineID", txtLineID.Text), 
                                      new SqlParameter("@StartP", txtStart.Text),
                                      new SqlParameter("@EndP", txtEnd.Text),
                                      new SqlParameter("@Distance", txtDistance.Text)};
            DBHelperSQL.TableChange(sql, para);
            LinesShow();
        }

        private void btnLDelete_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM [test2011].[dbo].[Lines]
                           WHERE [LineID] = @LineID";
            SqlParameter[] para = { new SqlParameter("@LineID", txtLineID.Text) };
            DBHelperSQL.TableChange(sql, para);
            LinesShow();
        }

        private void btnLUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE [test2011].[dbo].[Lines]
                           SET [StartP] = @StartP
                              ,[EndP] = @EndP
                              ,[Distance] = @Distance
                         WHERE [LineID] = @LineID";
            SqlParameter[] para = { new SqlParameter("@LineID", txtLineID.Text), 
                                      new SqlParameter("@StartP", txtStart.Text),
                                      new SqlParameter("@EndP", txtEnd.Text),
                                      new SqlParameter("@Distance", txtDistance.Text)};
            DBHelperSQL.TableChange(sql, para);
            LinesShow();
        }

        private void btnLSearch_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT [LineID]
                              ,[StartP]
                              ,[EndP]
                              ,[Distance]
                          FROM [test2011].[dbo].[Lines]
                           WHERE [LineID] = @LineID";
            SqlParameter[] para = { new SqlParameter("@LineID", txtLineID.Text) };
            dvL.DataSource = DBHelperSQL.TableSelect(sql, para);
        }
        public void LinesShow()
        {
            string sql = "select * from Lines";
            dvL.DataSource = DBHelperSQL.TableSelect(sql);
        }
        #endregion



        #region Timetable表操作
         private void btnTAdd_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [test2011].[dbo].[Timetable]
                               ([LineID]
                               ,[EmpID]
                               ,[BusID]
                               ,[StartTime])
                         VALUES(@LineID,@EmpID,@BusID,@StartTime)";
            SqlParameter[] para = { new SqlParameter("@LineID", txtLineIDT.Text), 
                                      new SqlParameter("@EmpID", txtEmpIDT.Text),
                                      new SqlParameter("@BusID", txtBusIDT.Text),
                                      new SqlParameter("@StartTime", txtStartTime.Text)};
            DBHelperSQL.TableChange(sql, para);
            TimetableShow();
        }

        private void btnTDelete_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM [test2011].[dbo].[Timetable]
                            WHERE [LineID] = @LineID And [BusID] = @BusID and [EmpID] =@EmpID";
            SqlParameter[] para = { new SqlParameter("@LineID", txtLineIDT.Text), 
                                      new SqlParameter("@EmpID", txtEmpIDT.Text),
                                      new SqlParameter("@BusID", txtBusIDT.Text)};
            DBHelperSQL.TableChange(sql, para);
            TimetableShow();
        }

        private void btnTUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE [test2011].[dbo].[Timetable]
                           SET [EmpID] =@EmpID
                              ,[BusID] = @BusID
                              ,[StartTime] =@StartTime
                         WHERE [LineID] = @LineID";
            SqlParameter[] para = { new SqlParameter("@LineID", txtLineIDT.Text), 
                                      new SqlParameter("@EmpID", txtEmpIDT.Text),
                                      new SqlParameter("@BusID", txtBusIDT.Text),
                                      new SqlParameter("@StartTime", txtStartTime.Text)};
            DBHelperSQL.TableChange(sql, para);
            TimetableShow();
        }

        private void btnTSearch_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT [LineID]
                          ,[EmpID]
                          ,[BusID]
                          ,[StartTime]
                      FROM [test2011].[dbo].[Timetable]
                      WHERE  [LineID] = @LineID And [BusID] = @BusID and [EmpID] =@EmpID";
            SqlParameter[] para = { new SqlParameter("@LineID", txtLineIDT.Text), 
                                      new SqlParameter("@EmpID", txtEmpIDT.Text),
                                      new SqlParameter("@BusID", txtBusIDT.Text)};
            dvL.DataSource = DBHelperSQL.TableSelect(sql, para);
        }
        public void TimetableShow()
        {
            string sql = "select * from Timetable";
            dvL.DataSource = DBHelperSQL.TableSelect(sql);
        }
        #endregion
        #region 查询
        private void btnS1_Click(object sender, EventArgs e)
        {
            string sql = @"select *
                           from Buses a,Driver b,Lines c,Timetable d
                           where a.BusID=d.BusID and b.EmpID=d.EmpID and c.LineID=d.LineID and c.LineID=@LineID";
            SqlParameter[] para = { new SqlParameter("@LineID", txtLineIDT.Text) };
            dvStatistics.DataSource = DBHelperSQL.TableSelect(sql,para);
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            string sql = @"select *
                           from Buses a,Driver b,Lines c,Timetable d
                           where a.BusID=d.BusID and b.EmpID=d.EmpID and c.LineID=d.LineID and c.StartP=@StartP";
            SqlParameter[] para = { new SqlParameter("@StartP", txtStartS.Text) };
            dvStatistics.DataSource = DBHelperSQL.TableSelect(sql, para);
        }
        #endregion

        #region 统计
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            string sql = @"select EmpID,COUNT(*) 发车次数
                            from Timetable
                            group by EmpID";
            dvStatistics.DataSource = DBHelperSQL.TableSelect(sql);
        }
        #endregion




      
       


      


    }
}
