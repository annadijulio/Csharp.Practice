using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jayway.Cars.Infrastructure.Ef
{
    public class CarContext : DbContext
    {
        public IDbSet<Domain.Car> Cars { get; set; }
    }
}
