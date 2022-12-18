using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T: class //Bu T bir sınıf olmalı şartı koyuyoruz
    {
        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new Context();

            return c.Set<T>().ToList();
        }
        //şartlı listeleme
        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {

            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }

}
