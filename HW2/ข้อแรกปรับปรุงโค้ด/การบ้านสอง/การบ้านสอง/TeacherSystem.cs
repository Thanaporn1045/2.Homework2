using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    class TeacherSystem
    {
        static public void ShowInputRegisterNewTeacherScreen()
        {
            Console.Clear();
            PrintHeaderRegisterTeacher();
            int totalTeacher = TotalNewTeacher();
            InputNewTeacherFromKeyboard(totalTeacher);
        }
        static void InputNewTeacherFromKeyboard(int totalTeacher)
        {
            for (int i = 0; i < totalTeacher; i++)
            {
                Console.Clear();
                PrintHeaderRegisterTeacher();
                Teacher teacher = CreateNewTeacher();
                Program.personList.AddNewPerson(teacher);
            }
            Console.Clear();
            Program.PrintMenuScreen();
        }
        static Teacher CreateNewTeacher()
        {
            return new Teacher(InputSystem.InputName(),
            InputSystem.InputAddress(),
            InputSystem.InputCitizenID(),
            InputSystem.InputEmployeeID());
        }
        static string InputEmployeeID()
        {
            Console.Write("Employee ID: ");
            return Console.ReadLine();
        }

        static public void PrintHeaderRegisterTeacher()
        {
            Console.WriteLine("Register new teacher.");
            Console.WriteLine("---------------------");
        }
        static int TotalNewTeacher()
        {
            Console.Write("Input Total new Teacher: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
