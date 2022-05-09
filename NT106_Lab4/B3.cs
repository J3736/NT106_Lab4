using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
namespace NT106_Lab4
{
    public partial class frmB3 : Form
    {
        public frmB3()
        {
            InitializeComponent();
        }

        private void btnDl_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            Stream response = wc.OpenRead(tbUrl.Text);
            wc.DownloadFile(tbUrl.Text, tbFileUrl.Text);

            StreamReader sr = new StreamReader(tbFileUrl.Text);
            rtbHtml.Text = sr.ReadToEnd();
        }

        private void tbFileUrl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
