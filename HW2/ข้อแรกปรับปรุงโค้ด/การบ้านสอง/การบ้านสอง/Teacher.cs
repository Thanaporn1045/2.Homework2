using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    class Teacher:Person
    {
        private string employeeID;

        public Teacher(string name, string address, string citizenID, string employeeID)
        : base(name, address, citizenID)
        {
            this.employeeID = employeeID;
        }
    }
}
