using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    enum ActivityMenu //สร้าง enum ของหน้าเมนูลงทะเบียนกิจกรรม
    {
        ListofActivities = 1,
        RegisteranActivity,
        Exit
    }
    class ActivityRegisterSystem //คลาสสำหรับการลงทะเบียนกิจกรรม
    {
        static public void ShowActivityRegistrationSystemPage() //เมธตอดโชว์หัวข้อระบบการลงทะเบียนกิจกรรม
        {
            Console.Clear();
            Console.WriteLine("Activity Registration System");
            Console.WriteLine("-----------------------------");
            ShowActivityRegistration();
        }
        static public void ShowActivityRegistration() //เมธตอดโชว์เมนูสำหรับหารลงทะเบียน
        {
            Console.WriteLine("1. List of all Activities");
            Console.WriteLine("2. Register an Activity");
            Console.WriteLine("3. Exit ");
            InputMenuFromKeyboard();
        }
        static void InputMenuFromKeyboard() //เมธตอดรับค่าเมนูจากผู้ใช้
        {
            Console.Write("Please Select Menu: ");
            ActivityMenu menu = (ActivityMenu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }
        static public ActivityList list; //สร้างตัวแปร List ที่เป็นชนิด ActivityList
        static void PrepareListWhenProgramIsLoad()  //เมธตอดเตรียมตัวแปร List
        {
            list = new ActivityList(); 
        }
        static void PresentMenu(ActivityMenu menu) //เมธตอดเลือกเมนูตามที่ผู้ใช้กรอกเข้ามา
        {
            PrepareListWhenProgramIsLoad();
            if (menu == ActivityMenu.ListofActivities)
            {
                Console.Clear();
                list.AddListActivity();
                list.showlistActivity();
                Back();
            }
            else if (menu == ActivityMenu.RegisteranActivity)
            {
                Console.Clear();
                RegisterActivity();

            }
            else if (menu == ActivityMenu.Exit)
            { }
            else
            {
                ShowMessageInputMenuIsInCorrect();
            }
        }
        static void ShowMessageInputMenuIsInCorrect() //เมธตอดโชว์ว่าเลือกเมนูผิด
        {
            Console.Clear();
            Console.WriteLine("Menu Incorrect Please try again.");
            InputMenuFromKeyboard();
        }
        static void Back() //เมธตอดให้เลือกว่าจะกลับไปหน้าก่อนหน้านี้หรือไม่
        {
            Console.Write("Back? (yes/no) : ");
            string YesOrNo = Console.ReadLine();
            if(YesOrNo == "yes") { ShowActivityRegistrationSystemPage(); }
            else { }
        }
        static void RegisterActivity() //เมธตอดโชว์หน้าลงทะเบียนกิจกรรม
        {
            Console.WriteLine("Register an Activity");
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            int total = TotalNewActivity();
            Console.WriteLine();
            InputNewActivityFromKeyboard(total);
        }

        static public int TotalNewActivity()//เมธตอดรับค่าจำนวนกิจกรรมที่ต้องการลงทั้งหมด
        {
            Console.Write("Input Total new Activity: ");

            return int.Parse(Console.ReadLine());
        }
        static void InputNewActivityFromKeyboard(int totalActivity) //เมธตอดรับค่ารหัสกิจกรรมที่ต้องการลงทะเบียนตามจำนวนกิจกรรมทั้งหมดที่กรอกเข้ามา
        {
            string activityID;
            for (int i = 1; i <= totalActivity; i++)
            {
                Console.WriteLine("Activity {0} ",i);
                Console.Write("Input Activity ID : ");
                activityID = Console.ReadLine();
                list.AddlistFromRegister(activityID);
                Console.WriteLine("");
            }
            ShowActivityFormInput();
        }
        static void ShowActivityFormInput() //เมธตอดโชว์กิจกรรมที่ลงทะเบียนไว้ทั้งหมด และรวมจำนวนชั่วโมงที่ได้
        {
            Console.Clear();
            int count = 0;
            int totalhour = 0;
            list.AddListActivity();
            Console.WriteLine("All Activities Registered");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            foreach(Activity readlist in list.activityList)
            { 
                foreach(string readlist2 in list.ListFromRegister)
                {
                    if(readlist2 == readlist.ActivityID) 
                    { 
                        count++;
                        Console.WriteLine("Activity {0}",count);
                        Console.WriteLine("Activity ID : {0}", readlist.ActivityID);
                        Console.WriteLine("Activity Name : {0}", readlist.ActivityName); ;
                        totalhour += readlist.ActivityHour;
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("Total Activities Hours : {0}",totalhour);
            Console.WriteLine();
            Back();
        }
        


    }
}
