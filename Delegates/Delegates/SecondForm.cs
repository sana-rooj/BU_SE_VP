using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void SecondForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Closing");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form[] ArrForm = null;
            for(int i=0; i<10;i++)
            {
                ArrForm[i] = new Form();
                ArrForm[i].Size = new Size(100, 100);
                ArrForm[i].Location = new Point(200 + (i * 10), 200 + (i * 10));
                ArrForm[i].Show();
            }
            


        }
    }
}
