using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class UserMenu : UserControl
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void Sign_Out_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Form1 parent = this.ParentForm as Form1;
            parent.Close();
            
        }

        private void OldOrders_Click(object sender, EventArgs e)
        {
            

        }
    }
}
