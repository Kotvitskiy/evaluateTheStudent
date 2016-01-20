using Business.Entities;
using Business.ProviderDefinition;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBest.EntityProviders.Providers
{
    public class DataProviderBase<T> : IBaseProvider<T>
        where T : BaseEntity, new()
    {
        private T Execute<T>(Func<DbContext, T> expression)
        {
            using(var context = new DataContext())
            {
                return expression(context);
            }
        }

        private bool Execute(Func<DbContext, bool> expression)
        {
            using (var context = new DataContext())
            {
                return expression(context);
            }
        }

        public bool Create(T item)
        {
            return Execute(context =>
            {
                context.Set<T>().Add(item);
                context.SaveChanges();
                return true;
            });
        }      

        public bool Update(T item)
        {
            return Execute(context =>
                {
                    context.Set<T>().Attach(item);
                    context.Entry<T>(item).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;
                });
        }

        public bool Delete(string id)
        {
            return Execute(context =>
            {
                var item = context.Set<T>().SingleOrDefault(x => x.Id == id);
                context.Set<T>().Remove(item);
                context.SaveChanges();
                return true;
            });
        }

        public T Get(string id)
        {
            return Execute(context =>
                {
                    return context.Set<T>().SingleOrDefault(x => x.Id == id);
                });
        }

        public List<T> GetAll()
        {
            return Execute(context =>
            {
                return context.Set<T>().ToList<T>();
            });
        }
    }
}
