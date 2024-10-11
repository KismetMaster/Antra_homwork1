using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class GenericRepository
    {
    }

    public class Entity
    {
        public int Id { get; set; }
    }

    public interface IRepository<T> where T : Entity
    {
        void Add(T item);
        void Remove(T item);
        void Save();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }


    
}
