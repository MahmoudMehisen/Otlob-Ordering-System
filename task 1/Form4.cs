using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace task_1
{
    public partial class Form4 : Form
    {
        public string picloc = "";
        
        public Form4()
        {
            InitializeComponent();
            City cs = new City();
            cs.Choose(ref City_add);
            cs.Choose(ref City_update);
            cs.Choose(ref City_delete);



        }
        // .......Add.....
        //.................................................
        private void City_add_SelectedIndexChanged(object sender, EventArgs e)
        {
            District ds = new District();
            ds.Choose(ref District_add, ref City_add  );
        }

        private void District_add_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resturant rs = new Resturant();
            rs.Choose(ref  District_add, ref Rest_add);
        }
        private void Rest_add_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void Choose_add_Click(object sender, EventArgs e)
        {
            Read ps = new Read();
            ps.PIC(ref  Image_add, ref  picloc);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Meal add_meal = new Meal();
            add_meal.Add(ref  picloc, ref  District_add, ref  Rest_add, ref  Name_add, ref  Details_add, ref  Price_add);

        }

        //.......................................


        //....UpDate........
        //............................................
        private void City_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            District sh = new District();
            sh.Choose(ref District_update, ref    City_update);
        }

        private void District_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resturant rs = new Resturant();
            rs.Choose(ref  District_update, ref Rest_update);
        }

        private void Rest_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            Meal sn = new Meal();
            sn.Choose(ref  District_update, ref  Rest_update, ref  Name_update);
        }

        private void Update_Click(object sender, EventArgs e)
        {

            Meal up = new Meal();
            up.Update(ref  Price_update, ref  District_update, ref  Rest_update, ref  Name_update);
        }
        //........................................

        //......Delete..............
        //.........................................

        private void City_delete_SelectedIndexChanged(object sender, EventArgs e)
        {
            District shd = new District();
            shd.Choose(ref District_delete, ref   City_delete);

        }

        private void District_delete_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resturant shr = new Resturant();
            shr.Choose(ref  District_delete, ref Rest_delete);
        }

        private void Rest_delete_SelectedIndexChanged(object sender, EventArgs e)
        {
            Meal shn = new Meal();
            shn.Choose(ref  District_delete, ref  Rest_delete, ref  Name_delete);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Meal del = new Meal();
            del.Delete(ref  District_delete, ref  Rest_delete, ref  Name_delete);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
