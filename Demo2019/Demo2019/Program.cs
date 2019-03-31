using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Xml;

namespace Demo2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //从grades.txt文件里读数据写入到grades.xml里面，要求输出到grades.xml文件里面是按成绩降序排列的
            DataTable dt = TxtToDatatable("D:\\grades.txt");
            DatatableToXml(dt, "D:\\test\\grades.xml");

            //从grades.xml文件里读数据写入到grades.txt里面，要求输出到grades.txt文件里面是按成绩降序排列的
            dt = XmlToDatatable("D:\\grades.xml");
            DatatableToTxt(dt, "D:\\test\\grades.txt");
        }

        /// <summary>
        /// 功能：从txt文件读取数据输出到xml文件，要求成绩按降序排列
        /// </summary>
        /// <param name="txtPath"></param>
        /// <param name="xmlPath"></param>
        public static DataTable TxtToDatatable(string txtPath)
        {
            StreamReader sr = new StreamReader(txtPath, Encoding.GetEncoding("GB2312"));
            string txt = sr.ReadToEnd().Replace("\r\n", "-");
            string[] nodes = txt.Split('-');
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("course", typeof(string));
            dt.Columns.Add("score", typeof(string));

            foreach (string node in nodes)
            {
                string[] strs = node.Split(' ');
                DataRow dr = dt.NewRow();
                dr["id"] = strs[0];
                dr["name"] = strs[1];
                dr["course"] = strs[2];
                dr["score"] = strs[3];
                dt.Rows.Add(dr);
            }

            return dt;
        }

        /// <summary>
        /// 功能：将Datatable写入xml文件
        /// </summary>
        /// <param name="dt"></param>
        public static void DatatableToXml(DataTable dt,string xmlPath)
        {
            MemoryStream stream = null;
            XmlTextWriter writer = null;

            dt.TableName = "grade";
            dt.DefaultView.Sort = "score DESC";//按score降序
            dt = dt.DefaultView.ToTable();//返回一个新的DataTable

            stream = new MemoryStream();
            writer = new XmlTextWriter(stream, Encoding.UTF8);
            dt.WriteXml(xmlPath);
        }

        /// <summary>
        /// 功能：从xml读取数据转换成DataTable
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        public static DataTable XmlToDatatable(string xmlPath)
        {
            DataSet ds = new DataSet(); //DataSet:是一个数据集，里面是DataTable的数据集合
            ds.ReadXml(xmlPath);

            return ds.Tables[0];
        }

        /// <summary>
        /// 功能：将Datatable数据存到txt文件中
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="txtPath"></param>
        public static void DatatableToTxt(DataTable dt , string txtPath)
        {
            DataRow[] dr = dt.Select("", "score desc");
            //DataRow 行数据集
            FileStream fs = new FileStream(txtPath, System.IO.FileMode.Append); //创建一个文件，文件模式(FileMode.Append)为附加（如文件中原本有数据，则在数据后附加，不删除原数据）
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fs);
            for (int i = 0; i < dr.Length; i++)
            {
                //将一行中的每一列输出
                sw.Write(dr[i][0].ToString() + "\t " + dr[i][1].ToString() + "\t " + dr[i][2].ToString() + "\t " + dr[i][3].ToString() + "\t \r\n");
            }
            sw.AutoFlush = true;
        }
    }
}
