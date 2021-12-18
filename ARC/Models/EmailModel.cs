using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ARC.Models
{
    public class EmailModel
    {
        public string SMTP_NAME { get; set; }
        public int SMTP_PORT { get; set; }
        public bool SMTP_SSL { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string From_User { get; set; }
        public string To_User { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }
    }
}
