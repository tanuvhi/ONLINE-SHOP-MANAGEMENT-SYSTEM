using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class AutoListing : Form
    {
        public AutoListing()
        {
            InitializeComponent();
        }
        
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlDocument doc = webBrowse.Document;
            HtmlElement username = doc.GetElementById("LoginForm_email");
            HtmlElement password = doc.GetElementById("LoginForm_password");
          //  HtmlElement submit = doc.GetElementById("Login");
            username.SetAttribute("value", "ultrashopbd@gmail.com");
            password.SetAttribute("value", "crazy_4    ");
            //submit.InvokeMember("Click");
            

        }
    } 
}
