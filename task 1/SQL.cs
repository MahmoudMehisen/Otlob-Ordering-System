using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
namespace task_1
{
    class SQL
    {
        public SqlConnection cn = new SqlConnection(@"Server=DESKTOP-JM49VCJ\OTLOBSYSTEM; DataBase=Sign_UP; Integrated Security=false;User ID=sa;Password=01022037833;");
        public SqlCommand cmd,cmmd;
        public SqlDataReader dr,drr;

        public SqlCommandBuilder cmdb;
        public SqlDataAdapter Da;
        public DataSet ds = new DataSet();
        public DataTable Dt = new DataTable();
        public CurrencyManager cm;
        public int convert(string name)
        {
            int x = Int32.Parse(name);
            return x;
        }
        public int sizeOfTable()
        {
            cmd = new SqlCommand("select * from ComingOrder ", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            int size = 0;
            while (dr.Read())
            {
                size++;

            }
            dr.Close();
            cn.Close();
            return size;
        }
    }
}
