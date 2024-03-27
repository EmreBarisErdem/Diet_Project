using CalorieProject_DAL.Context;
using CalorieProject_DAL.Repositories.Abstract;
using CalorieProject_Models.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieProject_DAL.Repositories.Concrete
{
    public class BaseManager<T> : ICRUD<T> where T : BaseEntity
    {

        public BaseManager(DietDBContext contextDB)
        {
            _contextDB = contextDB;
            _table = _contextDB.Set<T>();

        }
        DietDBContext _contextDB;
        DbSet<T> _table;

        public bool AddOrUpdate(T entity)
        {
            _table.Update(entity);
            return _contextDB.SaveChanges() > 0;
        }

        public bool Add(T entity)
        { 
            _table.Add(entity);
            return _contextDB.SaveChanges() > 0;
        }

        public bool Update(int id)
        {
            T entity = Get(id);
            _table.Update(entity);
            return _contextDB.SaveChanges() > 0;
        }

     

        public bool Delete(T entity)
        {
            _table.Remove(entity);
            return _contextDB.SaveChanges() > 0;
        }

        public T Get(int id)
        {
            return _table.Find(id);
        }

        public List<T> GetAll()
        {
            return _table.ToList();
        }



    }
}
