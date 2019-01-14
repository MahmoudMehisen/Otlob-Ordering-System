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
    class Load : SQL
    {
        public void Resturant(ref PictureBox Pic, ref Label Name)
        {
            try
            {
                cmd = new SqlCommand("select Logo from Restaurants where Restaurant='" + Name.Text + "' ", cn);
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    byte[] img = (byte[])(dr[0]);
                    if (img == null)
                        Pic.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        Pic.Image = Image.FromStream(ms);
                        Pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Meal(ref PictureBox Pic, ref Label Name)
        {
            try
            {
                cmd = new SqlCommand("select Image from Meals where Name='" +Name.Text + "' ", cn);
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    byte[] img = (byte[])(dr[0]);
                    if (img == null)
                        Pic.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        Pic.Image = Image.FromStream(ms);
                        Pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Load_img_myorder(ref ImageList PIC, string Name)
        {
            try
            {
                cmd = new SqlCommand("select Logo from Restaurants where Restaurant='" + Name + "' ", cn);
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    byte[] img = (byte[])(dr[0]);

                    MemoryStream ms = new MemoryStream(img);
                    PIC.Images.Add(Image.FromStream(ms));


                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }

}
