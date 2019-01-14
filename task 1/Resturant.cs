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
    class Resturant:SQL
    {
        public void Add(ref ComboBox District_resturant, ref TextBox Resturant_name_add, ref string picloc)
        {

            try
            {
                byte[] img = null;

                FileStream fs = new FileStream(picloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                cmd = new SqlCommand("insert into Restaurants (District,Restaurant,Rate,Logo) values ('" + District_resturant.SelectedItem + "','" + Resturant_name_add.Text + "','" + 3 + "',@img) ", cn);
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                cmd.Parameters.Add(new SqlParameter("@img", img));
                int x = cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(x.ToString() + "Recorder save");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                cn.Close();
            }
        }
        public void Delete(ref ComboBox Resturant_name_delete)
        {
            try
            {
                cmd = new SqlCommand("Delete from Restaurants where Restaurant='" + Resturant_name_delete.SelectedItem + "'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Done.");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                cn.Close();
            }
        }
        public void Choose(ref ComboBox District_add, ref ComboBox Rest_add)
        {
            cmd = new SqlCommand("Select Restaurant from Restaurants where District='" + District_add.SelectedItem + "'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            Rest_add.Items.Clear();
            while (dr.Read())
            {
                Rest_add.Items.Add(dr["Restaurant"]);

            }
            dr.Close();
            cn.Close();
        }

    }
}
