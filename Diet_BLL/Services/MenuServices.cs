using CalorieProject_DAL.Context;
using Diet_DAL.Repositories.Concrete;
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
    }
}
