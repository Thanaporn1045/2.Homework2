using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    class TeacherSystem
    {
        static public void ShowInputRegisterNewTeacherScreen() // เมดตอธรวมการการแสดงผลของหน้ารับค่าข้อมูลครู
        {
            Console.Clear();
            PrintHeaderRegisterTeacher();
            int totalTeacher = TotalNewTeacher();
            InputNewTeacherFromKeyboard(totalTeacher);
        }
        static void InputNewTeacherFromKeyboard(int totalTeacher) // เมธตอดรับค่าข้อมูลครูตามจำนวนครูทั้งหมดที่กรอกเข้ามา
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
        static Teacher CreateNewTeacher() //เมธตอดคืนค่า instance ข้อมูลครู
        {
            return new Teacher(InputSystem.InputName(),InputSystem.InputCitizenID(),InputSystem.InputEmployeeID());
        }

        static public void PrintHeaderRegisterTeacher()  //เมธตอดโชว์หัวข้อของหน้า RegisterTeacher
        {
            Console.WriteLine("Register new teacher.");
            Console.WriteLine("---------------------");
        }
        static int TotalNewTeacher()  //เมธตอดรับและคืนค่าจำนวนครูทั้งหมด
        {
            Console.Write("Input Total new Teacher: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
