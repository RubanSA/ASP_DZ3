using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_DZ3.Models
{
    public interface IRepository<T>
    {
        IList<T> List { get; }

        void Add(T item);
    }

    public class DefaultRepository<T> : IRepository<T>
    {
        public IList<T> List { get ; protected set; }

        public void Add(T item)
        {
            List.Add(item);
        }

        public DefaultRepository()
        {
            List = new List<T>();
        }
    }
    //public class AccountRepository
    //{
    //    IEnumerable<T> list;

    //}
}