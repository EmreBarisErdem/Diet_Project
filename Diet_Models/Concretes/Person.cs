using CalorieProject_Models.Abstracts;
using CalorieProject_Models.Enums;
using Diet_Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieProject_Models.Concretes
{
    public class Person : BaseEntity
    {

        public int PersonID { get; set; }
        public string UserName { get; set; }

        public UserType UserType { get; set; }

        public UserStatus UserStatus { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public string Password { get; set; }

        public double Weight { get; set; }
        public double Height { get; set; }

        public ActivityStatus ActivityStatus { get; set; }

        public double CaloriesPerDay { get; private set; }



        public  ICollection<Menu>? Menus { get; set; }


        public void CalculateCaloriesPerDay()
        {
            if (Gender == Gender.Male)
            {
                CaloriesPerDay = 66.5 + (13.75 * Weight) + (5 * Height) - (6.77 * (DateTime.Now.Year - BirthDate.Year));

                if(ActivityStatus == ActivityStatus.NotActive)
                {
                    CaloriesPerDay *= 1.2;
                }
                else if(ActivityStatus == ActivityStatus.LightlyActive) 
                {
                    CaloriesPerDay *= 1.3;
                }
                else if (ActivityStatus == ActivityStatus.Active)
                {
                    CaloriesPerDay *= 1.4;
                }
                else 
                {
                    CaloriesPerDay *= 1.5;
                }
            }
            else
            {
                CaloriesPerDay = 655.1 + (9.56 * Weight) + (1.85 * Height) - (4.67 * (DateTime.Now.Year - BirthDate.Year));

                if (ActivityStatus == ActivityStatus.NotActive)
                {
                    CaloriesPerDay *= 1.2;
                }
                else if (ActivityStatus == ActivityStatus.LightlyActive)
                {
                    CaloriesPerDay *= 1.3;
                }
                else if (ActivityStatus == ActivityStatus.Active)
                {
                    CaloriesPerDay *= 1.4;
                }
                else
                {
                    CaloriesPerDay *= 1.5;
                }
            }
        }
    }
}
