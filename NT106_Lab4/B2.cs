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
    public partial class frmB2 : Form
    {
        public frmB2()
        {
            InitializeComponent();
        }

        private void B2_Load(object sender, EventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string address = tbAddress.Text;
            WebRequest request = WebRequest.Create(address);
            request.Method = "POST";

            string stringpost = tbPost.Text;
            byte[] bytepost = Encoding.UTF8.GetBytes(stringpost);

            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = bytepost.Length;

            Stream datastream = request.GetRequestStream();
            datastream.Write(bytepost, 0, bytepost.Length);

            datastream.Close();

            WebResponse response = request.GetResponse();
            rtbResponse.Text = ((HttpWebResponse)response).StatusDescription;

            rtbResponse.AppendText("\n");
            using (datastream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(datastream);

                string stringresponse = reader.ReadToEnd();

                rtbResponse.AppendText(stringresponse);
            }
            response.Close();
        }
    }
}
