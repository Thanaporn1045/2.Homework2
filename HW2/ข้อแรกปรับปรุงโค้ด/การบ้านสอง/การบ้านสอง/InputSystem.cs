using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    class InputSystem
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
        static public string InputAddress()
        {
            Console.Write("Address: ");

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
