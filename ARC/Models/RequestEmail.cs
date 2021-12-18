using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ARC.Models
{
    public class RequestEmail
    {
        [Required(ErrorMessage = "Body is required.")]
        public string Body { get; set; }
        public string Subject { get; set; }
    }
}
