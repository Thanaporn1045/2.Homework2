using System;

namespace การบ้านสอง
{
    class Program
    {
        enum Menu //สร้าง enum ของเมนูลงทะเบียนผู้ใช้ใหม่
        {
        RegisterNewStudent = 1,
        RegisterNewTeacher,
        ActivityRegistration 
        }
        static void Main(string[] args) //เมธตอดเริ่มหน้าเมนูและเตรียมตัวแปร
        {
            PreparePersonListWhenProgramIsLoad();
            PrintMenuScreen();
        }
        static void PreparePersonListWhenProgramIsLoad() //เมธตอดเตรียมตัวแปร personList
        {
            Program.personList = new PersonList();
        }
        static public PersonList personList; //สร้างตัวแปร personList ที่เป็น PersonList
        static public void PrintMenuScreen() //เมธตดรวมหน้าเมนูทั้งหมด
            {
                Console.Clear();
                PrintHeader();
                PrintListMenu();
                InputMenuFromKeyboard();
            }

            static public void  PrintHeader() //เมธตอดโชว์หัวข้อหน้าลงทะเบียนผู้ใช้ใหม่
            {
                Console.WriteLine("Welcome to registration new user school application.");
                Console.WriteLine("----------------------------------------------------");
            }

            static public void PrintListMenu() //เมธตอดโชว์เมนูที่สามารถเลือกได้
        {
                Console.WriteLine("1. Register new student.");
                Console.WriteLine("2. Register new Teacher.");
                Console.WriteLine("3. Activity Registration System");
            }

        static public void InputMenuFromKeyboard() //เมธตอดรับค่าเมนูจากผู้ใช้
        {
            Console.Write("Please Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }

        static void PresentMenu(Menu menu) //เมธตอดเลือกเมนูตามที่ผู้ใช้กรอกมา
        {
            if (menu == Menu.RegisterNewStudent)
            {
                StudentSystem.ShowInputRegisterNewStudentScreen();
            }
            else if (menu == Menu.RegisterNewTeacher)
            {
                TeacherSystem.ShowInputRegisterNewTeacherScreen();
            }
            else if (menu == Menu.ActivityRegistration)
            {
                ShowActivityRegistrationOnScreen();
            }
            else
            {
                ShowMessageInputMenuIsInCorrect();
            }
        }
        static void ShowMessageInputMenuIsInCorrect() //เมธตอดแสดงว่าเมนูที่ผู็ใช้กรอกเข้ามาผิด
        {
            Console.Clear();
            Console.WriteLine("Menu Incorrect Please try again.");
            InputMenuFromKeyboard();
        }

        static public void ShowActivityRegistrationOnScreen() //เมธตอดเมนูเริ่มการแสดงหน้า Login
        {
            Console.Clear();
            Console.WriteLine("Login");
            Console.WriteLine("-------");
            LoginSystem.LoginPage();

        }
    }

}
