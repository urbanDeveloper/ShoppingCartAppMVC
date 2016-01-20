using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "sunny.chaya.patel@gmail.com";
        public string MailFromAddress = "sunny.chaya.patel@gmail.com";
        public bool UseSsl = true;
        public string Username = "sunny.chaya.patel@gmail.com";
        public string Password = "";
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;

    }
}
