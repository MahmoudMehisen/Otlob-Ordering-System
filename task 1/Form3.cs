        
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
namespace task_1
{

    public partial class Form3 : Form
    {
        
        public string picloc = "";
        public Form3()
        {
            InitializeComponent();
            City open_form = new City();
            open_form.Choose(ref City_name_delete);
            open_form.Choose(ref City_distict);
            open_form.Choose(ref City_resturant);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }


        // city
        //.........................................
        private void City_name_add_TextChanged(object sender, EventArgs e)
        {

        }
        //add button
        private void button1_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.Add(ref City_name_add, ref City_name_delete, ref City_distict, ref City_resturant);
        }

        private void City_name_delete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delete_city_Click(object sender, EventArgs e)
        {
            City city = new City();
            city.Delete(ref City_name_delete, ref City_distict, ref City_resturant);
        }

        //.................................................



        //District
        //...............................................
        private void City_distict_SelectedIndexChanged(object sender, EventArgs e)
        {
            District dis = new District();
            dis.Choose(ref District_name_delete, ref City_distict);
        }
        private void District_name_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_district_Click(object sender, EventArgs e)
        {
            District Dis = new District();
            Dis.Add(ref District_name_add, ref City_distict);

        }

        private void District_name_delete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delete_district_Click(object sender, EventArgs e)
        {
            District Dis = new District();
            Dis.Delete(ref District_name_delete);
        }


        //.......................................


        //resturant
        //........................................
        private void City_resturant_SelectedIndexChanged(object sender, EventArgs e)
        {
            District Dis = new District();
            Dis.Choose(ref District_resturant, ref City_resturant);
        }

        private void District_resturant_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resturant res = new Resturant();
            res.Choose(ref District_resturant , ref Resturant_name_delete);
        }

        private void Resturant_name_add_TextChanged(object sender, EventArgs e)
        {

        }
        private void Choose_Pic_Click(object sender, EventArgs e)
        {
            Read img = new Read();
            img.PIC(ref Pic_Res, ref picloc);

        }
        private void Add_resturant_Click(object sender, EventArgs e)
        {
            Resturant Res = new Resturant();
            Res.Add(ref District_resturant, ref Resturant_name_add, ref picloc);
        }

        private void Resturant_name_delete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //delete
        private void button4_Click(object sender, EventArgs e)
        {
            Resturant Res = new Resturant();
           Res.Delete(ref Resturant_name_delete);
        }


        private void Pic_Res_Click(object sender, EventArgs e)
        {

        }
        //................................................................

        //Meals
        //.................................................................
        private void Edit_Meal_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            // f.MdiParent = this;
            f.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //......................................................................

    }
}
