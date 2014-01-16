using Jayway.Cars.Domain;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().Property(x => x.Name).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
        
        public IDbSet<Domain.Car> Cars { get; set; }
    }
}
