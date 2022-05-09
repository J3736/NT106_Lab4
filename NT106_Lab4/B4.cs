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
    public partial class frmB4 : Form
    {
        public frmB4()
        {
            InitializeComponent();
        }

        private string saveaddress()
        {
            return tbAddress.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Navigate();
        }

        private void Navigate()
        {
            bWed.AllowNavigation = true;
            string address = tbAddress.Text;
            if (string.IsNullOrEmpty(tbAddress.Text))
            {
                MessageBox.Show("Url can not empty.");
            }
            if (!address.StartsWith("https://") && !address.StartsWith("http://"))
            {
                address = "http://" + address;
            }

            try
            {
                bWed.Navigate(new Uri(address));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        
        
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            tbAddress.Text = bWed.Url.ToString();

        }

        private void wBox_Navigated(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        private void tbAddr_TextChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void frmB4_Load(object sender, EventArgs e)
        {
            bWed.ScriptErrorsSuppressed = true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            bWed.Navigate(new Uri((string)tbAddress.Text));
        }
    }
}
