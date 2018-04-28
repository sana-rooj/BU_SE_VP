using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img;
            OpenFileDialog obj = new OpenFileDialog();
            if(obj.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(obj.FileName);
                img = Image.FromFile(obj.FileName);
                pictureBox1.Image = img;
            }
            //saveToolStripMenuItem_Click(this, new EventArgs());
            //OpenFileDialog obj = new OpenFileDialog();
            //if(obj.ShowDialog() == DialogResult.OK)
            //{
            //    Form f = new Form();
            //    f.MdiParent = this;
            //    f.Show();
            //}

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog obj = new SaveFileDialog();
            if(obj.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Saved", "Saving file", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }
    }
}
