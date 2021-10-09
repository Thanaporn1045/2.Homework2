using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    class Teacher:Person // คลาสององค์ประกอบข้อมูลครูโดยมีพื้นฐานมาจากคลาส Person
    {
        private string employeeID;

        public Teacher(string name, string citizenID, string employeeID)
        : base(name, citizenID)
        {
            this.employeeID = employeeID;
        }
    }
}
