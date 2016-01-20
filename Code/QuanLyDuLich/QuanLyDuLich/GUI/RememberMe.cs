using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuLich.GUI
{
    class RememberMe
    {
        private string userName = "";

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string password = "";

        public string Password
        {
            get { return password; }
            set { password = value; }
        }        

        public RememberMe()
        {            
            string[] save = System.IO.File.ReadAllLines("rememberme.txt");
            if (save.Count() != 0)
            {
                this.userName = save[0];
                this.password = save[1];
            }
        }

        public void remember(string user, string pass)
        {
            string[] save = { user, pass };
            System.IO.File.WriteAllLines("rememberme.txt", save);
        }        
    }
}
