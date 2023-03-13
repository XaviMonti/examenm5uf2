using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examengithub
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenjar formmenjar = new FormMenjar();
            formmenjar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormViatge formviatge = new FormViatge();
            formviatge.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAnimal frmanimal = new FormAnimal();
            frmanimal.Show();
        }
    }
}
