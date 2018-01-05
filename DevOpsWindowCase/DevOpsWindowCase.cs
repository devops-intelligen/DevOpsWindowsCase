using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevOpsWindowCase
{
    public partial class DevOpsWindowCase : Form
    {
        public DevOpsWindowCase()
        {
            InitializeComponent();
        }

        private void DevOpsWindowCase_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\Administrator\Pictures\logo\logo.jpg");
        }


        private void logo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\Administrator\Pictures\logo\logo1.jpg");
        }

        private void logo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\Administrator\Pictures\logo\logo3.jpg");
        }

        private void logo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\Administrator\Pictures\logo\logo6.jpg");
        }

        
    }
}
