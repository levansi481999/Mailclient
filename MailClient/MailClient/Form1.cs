using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;
using System.Threading;


namespace MailClient
{
    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("levansi215487359@gmail.com", "levansi481999");
                MailMessage msg = new MailMessage();
                msg.To.Add(toText.Text);
                msg.From = new MailAddress("levansi215487359@gmail.com");
                msg.Subject = subjectText.Text;
                msg.Body = chatText.Text;
                Attachment data = new Attachment(txtattachment.Text);
                msg.Attachments.Add(data);
                client.Send(msg);
                MessageBox.Show("Đã gửi thư");

            }
            catch(Exception ex)
            {
                MessageBox.Show(" không thể gửi mail:(((",ex.Message);
            }
        }

        private void btfilebrowes_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtattachment.Text = dlg.FileName.ToString();
            }
            
        }

       

        private void txtattachment_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void toText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
