using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jayway.Csharp.Practice.Extensions;

namespace Jayway.Csharp.Practice
{
    public class Lab
    {
        public void Collections()
        {
            
            var list = new List<int> {1, 2, 3} as IEnumerable<int>;
          //Action<int>  Func
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
            list.ForEach(Console.WriteLine);
        }

    }
}
