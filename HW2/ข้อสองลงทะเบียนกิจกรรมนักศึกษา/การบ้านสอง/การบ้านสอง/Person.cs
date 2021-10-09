using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    class Person //คลาสองค์ประกอบข้อมูลของบุคคลทั่วไป
    {
        public string name;
        public string citizenID;

        public Person(string name, string citizenID)
        {
            this.name = name;
  
            this.citizenID = citizenID;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
