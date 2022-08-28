using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop.E2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Class user = new Class();
            user.userName = txtUserName.Text;
            user.passWord = txtPassWord.Text;
            string dateTime = DateTime.Now.ToString();
            user.Login(dateTime);
    }
}
