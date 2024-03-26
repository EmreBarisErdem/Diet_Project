using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieProject_Models.Enums
{
    public enum ActivityStatus
    {
        NotActive = 1, // <30 min az egzersiz     
        LightlyActive, // yarım saat yürüyüs veya 15-20 dakka kosu 
        Active,     // en az 45 dk yürüyüs veya 50dk kosu
        VeryActive      // en az 4 saat üzeri yürüyüs , iki saat kosu


            
    }
}
