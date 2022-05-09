using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_Lab4
{
    public partial class frmL4 : Form
    {
        public frmL4()
        {
            InitializeComponent();
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            frmB1 frm = new frmB1();
            if (Application.OpenForms.OfType<frmB1>().Any())

                MessageBox.Show("Already Opened.");
            else
                frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmB2 frm = new frmB2();
            if (Application.OpenForms.OfType<frmB2>().Any())

                MessageBox.Show("Already Opened.");
            else
                frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmB3 frm = new frmB3();
            if (Application.OpenForms.OfType<frmB3>().Any())

                MessageBox.Show("Already Opened.");
            else
                frm.Show();
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            frmB4 frm = new frmB4();
            if (Application.OpenForms.OfType<frmB4>().Any())

                MessageBox.Show("Already Opened.");
            else
                frm.Show();
        }
    }
}
