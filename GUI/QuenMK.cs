using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txb1.Text.Trim() == "admin") ;
            {
                QuenMK2cs q2 = new QuenMK2cs();
                q2.ShowDialog();
            }
        }

        private void txb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
