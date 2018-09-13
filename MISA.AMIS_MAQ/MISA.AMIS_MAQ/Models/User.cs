using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISA.AMIS_MAQ.Models
{
    public class User
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCode { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Numberphone { get; set; }
        public string Gender { get; set; }
    }
}