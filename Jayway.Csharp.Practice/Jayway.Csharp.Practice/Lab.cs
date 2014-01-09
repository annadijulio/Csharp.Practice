using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jayway.Csharp.Practice
{
    class Lab
    {
        public void test() {

            var ORMlist = new List<Car> { new Car() { Id = 1}, new Car() { Id = 2} };
           

        }
    }


    public class InMemoryCarRepository : IRepository<T> {

        IEnumerable<Car> IRepository<Car>.GetAll()
        {
            throw new NotImplementedException();
        }
    }

    public interface IRepository<T> 
        where T : int
    {
         IEnumerable<T> GetAll();
    }
}
