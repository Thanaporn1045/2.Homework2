using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    class LoginSystem
    {
        static public void LoginPage() //รับค่า ชื่อ และรหัสประชาชนเพื่อเข้าสู่ระบบ
        {
            Console.Write(" Name : ");
            string name = Console.ReadLine();
            Console.Write(" Citizen ID : ");
            string ID = Console.ReadLine();
            CheckIsRegisteredOrNot(name, ID);
        }
        static public void CheckIsRegisteredOrNot(string name,string ID) //เมธตอดเช็คว่าชื่อผู้ใช้และรหัสที่กรอกเข้ามา เคยลงทะเบียนไว้หรือไม่
        {
            int correct = 0;
            foreach (Person readlist in Program.personList.ListForCheck)
            {
                if(name == readlist.name && ID == readlist.citizenID) 
                {
                    correct++;
                }
                else { }
            }
            if (correct == 1)
            {
                ActivityRegisterSystem.ShowActivityRegistrationSystemPage();
            }
            else { ShowErrorLogin(); ShowBackMenu(); }
        }
        static public void ShowErrorLogin() //เมธตอดโชว์ว่าผู้ใช้นี้ไม่เคยลงทะเบียน
        {
            Console.Clear();
            Console.WriteLine("You are not registered");
        }
        static public void ShowBackMenu() //เมธตอดเลือกเมนูว่าจะกลับไปลงทะเบียน หรือ ล็อคอินอีกครั้ง หรือ ออก
        {
            Console.WriteLine("1. Back To Register ");
            Console.WriteLine("2. Input Name Again ");
            Console.WriteLine("3. Exit ");
            SelectBackMenu();
        }
        static public void SelectBackMenu() //เมธตอดรับค่าเลือกเมนูที่ต้องการเพื่อกลับไปหน้าดังกล่าว
        {
            Console.Write("Please Select Menu : ");
            int menu = int.Parse(Console.ReadLine());
            if(menu == 1) {
                Console.Clear();
                Program.PrintHeader();
                Program.PrintListMenu();
                Program.InputMenuFromKeyboard();
            }
            else if(menu == 2) { Console.Clear(); Program.ShowActivityRegistrationOnScreen(); }
            else if( menu == 3) { }
            else { Console.Clear(); ErrorSelectMenu(); }
        }
        static public void ErrorSelectMenu() //เมธตอดเมื่อใส่ค่าตัวเลขของเมนูผิด
        {
            Console.WriteLine("Menu Incorrect Please try again.");
            SelectBackMenu();
        }
    }
}
