using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Data_Acccess_Layer
{
    public class ImportExcelToSQL
    {
        public ImportExcelToSQL()
        {

        }
        public bool insertToSQL()
        {
            return true;
        }
        public void importToSQL(string path)
        {
            string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""",path);
            string query = String.Format("select * from [{0}$]", "T06");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connectionString);
            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);
            DataTable dataTable = new DataTable();
            dataTable = dataSet.Tables[0];
            //dataGridView1.DataSource = dataSet.Tables[0];

            if (dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    //userVO.TenDangNhap = dr[0].ToString();
                    //userVO.MatKhau = dr[1].ToString();
                    //userVO.Quyen = int.Parse(dr[2].ToString());
                    //insertToSQL(dr);

                }
            }
        }
        
    }
}
