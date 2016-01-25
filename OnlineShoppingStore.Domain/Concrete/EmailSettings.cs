using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EmailSettings
    {
        // need to add email address details here
        public string MailToAddress = " ";
        public string MailFromAddress = " ";
        public bool UseSsl = true;
        public string Username = " ";
        public string Password = " ";
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;

    }
}
