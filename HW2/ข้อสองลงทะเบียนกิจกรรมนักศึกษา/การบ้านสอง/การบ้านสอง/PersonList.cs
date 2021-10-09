using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    class PersonList //คลาสเก็บข้อมูล Person เป็น List
    {
        private List<Person> personList;
        public List<Person> ListForCheck; //สร้างตัวแปรเพื่อเก็บข้อมูลที่เป็น List

        public PersonList() //สร้าง instance
        {
            this.personList = new List<Person>();
            this.ListForCheck = new List<Person>();
        }

        public void AddNewPerson(Person person)  //เพิ่มข้อมูล Person เข้าไปใน List
        {
            this.personList.Add(person);
            this.ListForCheck.Add(person);
        }
    }
}
