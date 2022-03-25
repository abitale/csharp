using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi1.Models
{
    public class EmployeeItem
    {
        private Models.EmployeeItem context;

        public int id { get; set; }
        public string nama { get; set; }
        public string jenkel { get; set; }
        public string alamat { get; set; }
    }
}
