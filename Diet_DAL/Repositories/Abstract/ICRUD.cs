using CalorieProject_Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieProject_DAL.Repositories.Abstract
{
    public interface ICRUD<T> where T : BaseEntity
    {

        public bool AddOrUpdate(T entity);
       

        public bool Delete(T entity);


        public T Get(int id);


        public List<T> GetAll();

    }
}
