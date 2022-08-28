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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Class user = new Class();
            user.userName = txtUserName.Text;
            user.passWord = txtPassWord.Text;
            MessageBox.Show($"Sayın {user.userName} hoşgeldiniz. {user.passWord} şifresi ile giriş yaptınız.");
        }
    }
}
