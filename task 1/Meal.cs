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
    class Meal:SQL
    {
        public void Add(ref string picloc, ref ComboBox District, ref ComboBox Rest, ref TextBox Name, ref TextBox Details, ref TextBox Price)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(picloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                cmd = new SqlCommand("insert into Meals (District,Restaurant,Name,Details,Price,Rate,Image) values ('" + District.SelectedItem + "','" + Rest.SelectedItem + "','" + Name.Text + "','" + Details.Text + "','" + Price.Text + "','" + 3 + "',@img ) ", cn);

                if (cn.State != ConnectionState.Open)
                    cn.Open();
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(x.ToString() + "Recorder save");


            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {
                cn.Close();
            }
        }
        public void Update(ref TextBox Price, ref ComboBox District, ref ComboBox Rest, ref ComboBox Name)
        {
            try
            {
                cmd = new SqlCommand("update Meals set Price='" + Price.Text + "'  where District='" + District.SelectedItem + "' and Restaurant='" + Rest.SelectedItem + "' and Name='" + Name.SelectedItem + "'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done.");

            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {
                cn.Close();
            }
        }
        public void Delete(ref ComboBox District, ref ComboBox Rest, ref ComboBox Name)
        {
            try
            {
                cmd = new SqlCommand("Delete from Meals  where District='" + District.SelectedItem + "' and Restaurant='" + Rest.SelectedItem + "' and Name='" + Name.SelectedItem + "'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Done.");


            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {
                cn.Close();
            }
        }
        public void Choose(ref ComboBox District, ref ComboBox Rest, ref ComboBox Name)
        {
            cmd = new SqlCommand("Select Name from Meals where District='" + District.SelectedItem + "' and Restaurant='" + Rest.SelectedItem + "'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Name.Items.Add(dr["Name"]);

            }
            dr.Close();
            cn.Close();
        }
    }
}
