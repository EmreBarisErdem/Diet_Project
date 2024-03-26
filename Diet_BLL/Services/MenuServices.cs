using CalorieProject_DAL.Context;
using CalorieProject_DAL.Repositories.Concrete;
using Diet_DAL.Repositories.Concrete;
using Diet_Models.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_BLL.Services
{
    public class MenuServices
    {
        public MenuServices()
        {
            menuManager = new MenuManager(new DietDBContext());
        }
        MenuManager menuManager;

        public bool AddOrUpdate(Menu menu)
        {
            return menuManager.AddOrUpdate(menu);
        }

    }
}
