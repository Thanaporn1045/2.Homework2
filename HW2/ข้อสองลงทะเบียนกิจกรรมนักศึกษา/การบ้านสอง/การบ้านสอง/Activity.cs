using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้านสอง
{
    class Activity //คลาสองค์ประกอบข้อมูลของกิจกรรม
    {
        public string ActivityID;
        public string ActivityName;
        public int ActivityHour;

        public Activity(string ID,string name,int hour)
        {
            this.ActivityID = ID;
            this.ActivityName = name;
            this.ActivityHour = hour;
        }
    }
}
