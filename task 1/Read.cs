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
    class Read
    {
        public void PIC(ref PictureBox Pic, ref string picloc)
        {
            picloc = "";
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picloc = dlg.FileName.ToString();
                Pic.ImageLocation = picloc;
                Pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
    }
}
