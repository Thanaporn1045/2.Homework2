using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    class StudentSystem
    {
        static public void ShowInputRegisterNewStudentScreen() //เมธตอดสำหรับโชว์หน้ารับค่าลงทะเบียนนักเรียนใหม่
        {
            Console.Clear(); 
            PrintHeaderRegisterStudent();   
            int totalStudent = TotalNewStudents();   
            InputNewStudentFromKeyboard(totalStudent);   
        }
        static public void InputNewStudentFromKeyboard(int totalStudent) //เมธตอดรับค่าข้อมูลนักเรียนตามจำนวนนักเรียนทั้งหมดที่รับค่าเข้ามา
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
        static public Student CreateNewStudent() // เมธตอดคืนค่า instance ของข้อมูลนักเรียน
        {
            return new Student(InputSystem.InputName(), InputSystem.InputCitizenID(), InputSystem.InputStudentID());
        }
        static public int TotalNewStudents() //เมธตอดรับค่าจำนวนนักเรียกทั้งหมด
        {
            Console.Write("Input Total new Student: ");

            return int.Parse(Console.ReadLine());
        }

        static public void PrintHeaderRegisterStudent() //เมดตอดโชว์หัวข้อของหน้า RegisterStudent
        {
            Console.WriteLine("Register new student.");
            Console.WriteLine("---------------------");
        }

        
    }
}
