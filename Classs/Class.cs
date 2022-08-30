using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.E2
{
    internal class User
    {
        public string userName1 { get; set; }
        public string passWord1 { get; set; }

        public void Login(string loginDate1)
        {
            System.Windows.Forms.MessageBox.Show($"{loginDate1} tarihinde {userName1} adlı kullanıcı {passWord1} şifresi ile giriş yapmıştır.");
        }
    }
}
