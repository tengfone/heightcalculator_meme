using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace height_meme
{
    public partial class height_cal : Form
    {
        public height_cal()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String output = inputHeightBox.Text;
            MessageBox.Show($"Your height is {output}cm!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
