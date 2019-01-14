using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
            Order o = new Order();
            ImageList image = new ImageList();
            image.ImageSize = new Size(256, 256);
            o.Show_MyOrder(ref OredrList ,ref image);
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            OredrList.View = View.Details;
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
