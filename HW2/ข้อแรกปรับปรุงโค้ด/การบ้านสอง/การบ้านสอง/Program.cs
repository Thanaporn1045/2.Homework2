using System;

namespace การบ้านสอง
{
    class Program
    {
        enum Menu
        {
        RegisterNewStudent = 1,
        RegisterNewTeacher,
        GetListPersons
        }
        static void Main(string[] args)
        {
            PreparePersonListWhenProgramIsLoad();
            PrintMenuScreen();
        }
        static void PreparePersonListWhenProgramIsLoad()
        {
            Program.personList = new PersonList();
        }
        static public PersonList personList;
        static public void PrintMenuScreen()
            {
                Console.Clear();
                PrintHeader();
                PrintListMenu();
                InputMenuFromKeyboard();
            }

            static void PrintHeader()
            {
                Console.WriteLine("Welcome to registration new user school application.");
                Console.WriteLine("----------------------------------------------------");
            }

            static void PrintListMenu()
            {
                Console.WriteLine("1. Register new student.");
                Console.WriteLine("2. Register new Teacher.");
                Console.WriteLine("3. Get List Persons.");
            }

        static void InputMenuFromKeyboard()
        {
            Console.Write("Please Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }

        static void PresentMenu(Menu menu)
        {
            if (menu == Menu.RegisterNewStudent)
            {
                StudentSystem.ShowInputRegisterNewStudentScreen();
            }
            else if (menu == Menu.RegisterNewTeacher)
            {
                TeacherSystem.ShowInputRegisterNewTeacherScreen();
            }
            else if (menu == Menu.GetListPersons)
            {
                ShowGetListPersonScreen();
            }
            else
            {
                ShowMessageInputMenuIsInCorrect();
            }
        }
        static void ShowMessageInputMenuIsInCorrect()
        {
            Console.Clear();
            Console.WriteLine("Menu Incorrect Please try again.");
            InputMenuFromKeyboard();
        }

        static void ShowGetListPersonScreen()
        {
            Console.Clear();
            Program.personList.FetchPersonsList();
            InputExitFromKeyboard();
        }

        static void InputExitFromKeyboard()
        {
            string text =
            ""
            ;

            while (text != "exit")
            {
                Console.WriteLine("Input: ");
                text = Console.ReadLine();
            }

            Console.Clear();
            PrintMenuScreen();
        }



    }

}
