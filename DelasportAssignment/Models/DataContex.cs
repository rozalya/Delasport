using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelasportAssignment.Models
{
    public class DataContex
    {
        public DataContex()
        {
            this.RegisterUser = new RegisterUser();  
        }

        public RegisterUser RegisterUser { get; set; }
    }
}

