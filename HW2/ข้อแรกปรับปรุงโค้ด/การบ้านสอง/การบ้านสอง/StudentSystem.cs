using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    class StudentSystem
    {
        static public void ShowInputRegisterNewStudentScreen()
        {
            Console.Clear();
            PrintHeaderRegisterStudent();
            int totalStudent = TotalNewStudents();
            InputNewStudentFromKeyboard(totalStudent);
        }
        static public void InputNewStudentFromKeyboard(int totalStudent)
        {
            for (int i = 0; i < totalStudent; i++)
            {
                Console.Clear();
                PrintHeaderRegisterStudent();
                Student student = CreateNewStudent();

                Program.personList.AddNewPerson(student);
            }

            Console.Clear();
            Program.PrintMenuScreen();
        }
        static public Student CreateNewStudent()
        {
            return new Student(InputSystem.InputName(), InputSystem.InputAddress(), InputSystem.InputCitizenID(), InputSystem.InputStudentID());
        }
        static public int TotalNewStudents()
        {
            Console.Write("Input Total new Student: ");

            return int.Parse(Console.ReadLine());
        }

        static public void PrintHeaderRegisterStudent()
        {
            Console.WriteLine("Register new student.");
            Console.WriteLine("---------------------");
        }

        
    }
}
