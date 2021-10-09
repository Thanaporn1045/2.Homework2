using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    class ActivityList //คลาสสำหรับรวมข้อมูลกิจกรรมไว้เป็น List
    {
        public List<Activity> activityList; //ตัวแปรสำหรับรวมกิจกรรมรายทั้งหมด
        public List<string> ListFromRegister; //ตัวแปรสำหรับรวมรหัสกิจกรรมที่ผู้ใช้กรอกเข้ามา
        public ActivityList()  //สร้าง instance
        {
            activityList = new List<Activity>();
            ListFromRegister = new List<string>();
        }

        //สร้างกิจกรรมที่มี
        public Activity activity1 = new Activity("A01", "Teacher's Day Activities", 2);
        public Activity activity2 = new Activity("A02", "Family Day Activities", 2);
        public Activity activity3 = new Activity("A03", "Mangrove Planting Activities", 5);
        public Activity activity4 = new Activity("A04", "Teaching Activities For Upcountry Children", 8);
        public Activity activity5 = new Activity("A05", "Homeless Animals Helping Activity", 3);
        public Activity activity6 = new Activity("A06", "Reading Activities For The Blind", 3);

       public void AddListActivity() //เพิ่มกิจกรรมเข้าไปไว้ใน List กิจกรรมทั้งหมด
        {
            this.activityList.Add(activity1);
            this.activityList.Add(activity2);
            this.activityList.Add(activity3);
            this.activityList.Add(activity4);
            this.activityList.Add(activity5);
            this.activityList.Add(activity6);
        }
        
        public void showlistActivity()  //เมธตอดแสดงหน้ากิจกรรมทั้งหมด
        {
            Console.WriteLine("Open Enrollment Activities");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            foreach (Activity readlist in this.activityList)
            {
                Console.WriteLine("Activity ID : {0}",readlist.ActivityID);
                Console.WriteLine("Activity Name : {0}",readlist.ActivityName);
                Console.WriteLine("Activity Hour: {0}", readlist.ActivityHour);
                Console.WriteLine();
            }
        }
        public void AddlistFromRegister(string registeractivity) // เมธตอดเพิ่มรหัสกิจกรรมจากที่ผู้ใช้กรอกเข้าไปใน List รวมรหัสกิจกรรม
        {
            this.ListFromRegister.Add(registeractivity);
        }


    }
}
