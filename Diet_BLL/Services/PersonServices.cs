using CalorieProject_DAL.Context;
using CalorieProject_DAL.Repositories.Concrete;
using CalorieProject_Models.Concretes;
using CalorieProject_Models.Enums;

namespace CalorieProject_BLL.Services
{
    public class PersonServices
    {
        public PersonServices()
        {
            personManager = new PersonManager(new DietDBContext());
        }

        PersonManager personManager;

        public Person GetPersonByID(int personID)
        {
            return personManager.Get(personID);
        }

        public bool AddOrUpdate(Person person)
        {
            return personManager.AddOrUpdate(person);
        }


        public bool UserStatusControl(int ID)
        {
            Person person = personManager.Get(ID);

            if (person != null && person.UserStatus == UserStatus.Active)
            {
                return true;
            }
            else 
            {
                return false;
            }
                
                
        }


        public bool AddMember(Person person)
        {
            if (UserNameControl(person.UserName) && StrongPasswordControl(person.Password) && AgeControl(person.BirthDate))
            {
                return personManager.AddOrUpdate(person);
            }

            return false;
        }

        private bool UserNameControl(string userName)
        {
            var result = personManager
                .GetAll()
                .Where(x => x.UserName == userName)
                .SingleOrDefault();

            if (result != null)
            {
                return false;
            }

            if (userName.EndsWith("@gmail.com") || userName.EndsWith("@hotmail.com") || userName.EndsWith("@outlook.com") || userName.EndsWith("@bilgeadam.com"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool StrongPasswordControl(string password)
        {
            bool numberControl = false;
            bool specialCharControl = false;

            foreach (char c in password)
            {
                if (char.IsNumber(c))
                {
                    numberControl = true;
                }

                if (char.IsSeparator(c) || char.IsPunctuation(c) || char.IsSymbol(c))
                {
                    specialCharControl = true;
                }

            }

            if (numberControl && specialCharControl)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Person GetPersonByUsername(string username)
        {
            return personManager.GetMemberByUsername(username);
        }

        private bool AgeControl(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;

            if(age < 18 || age > 40)
            {
                return false;
            }

            return true;
        }

        public List<Person> GetAll()
        {
            return personManager.GetAll();
        }

     

        // To - Do : Buradan Önce Person Manager doldurulacak
    }
}
