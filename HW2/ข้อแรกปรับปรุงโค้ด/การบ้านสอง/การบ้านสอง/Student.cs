using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    class Student :Person
    {
        private string studentID;

        public Student(string name, string address, string citizenID, string studentID)
        : base(name, address, citizenID)
        {
            this.studentID = studentID;
        }
    }
}
