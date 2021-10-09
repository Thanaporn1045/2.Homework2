using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    class InputSystem //คลาสรวมเมธตอดสำหรับการรับค่าและคืนค่า ชื่อ รหัสประจำตัวประชาชน รหัสพนักงาน รหัสนักศึกษา
    {
        static public string InputName()
        {
            Console.Write("Name: ");

            return Console.ReadLine();
        }
        static public string InputStudentID()
        {
            Console.Write("Student ID: ");

            return Console.ReadLine();
        }
        static public string InputCitizenID()
        {
            Console.Write("Citizen ID: ");

            return Console.ReadLine();
        }
        static public string InputEmployeeID()
        {
            Console.Write("Employee ID: ");

            return Console.ReadLine();
        }
    }
}
