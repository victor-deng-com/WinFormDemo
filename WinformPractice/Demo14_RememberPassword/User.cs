using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo14_RememberPassword
{
    //要先将User类先设为可以序列化(即在类的前面加[Serializable])
    [Serializable]
    public class User
    {

        //public User(string username, string password)
        //{
        //    this.userName = username;
        //    this.passWord = password;
        //}

        private string Username;
        public string username
        {
            get { return Username; }
            set { Username = value; }
        }

        private string Password;
        public string password
        {
            get { return Password; }
            set { Password = value; }
        }
    }
}
