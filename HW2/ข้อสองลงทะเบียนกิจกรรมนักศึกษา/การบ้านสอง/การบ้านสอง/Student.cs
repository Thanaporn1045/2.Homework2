using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    class Student :Person //คลาสองค์ประกอบข้อมูลนักเรียน โดยมีพื้นฐานมากจากคลาส Person
    {
        private string studentID;

        public Student(string name, string citizenID, string studentID)
        : base(name,citizenID)
        {
            this.studentID = studentID;
        }
    }
}
