using System.Security.Cryptography.X509Certificates;
using Jayway.Cars.Domain;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jayway.Cars.Infrastructure.Ef.Dummy;

namespace Jayway.Cars.Infrastructure.Ef
{
    public class CarContext : DbContext
    {
        private ILogger _logger;

        public CarContext(ILogger logger)
        {
            _logger = logger;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().Property(x => x.Name).IsRequired();
            base.OnModelCreating(modelBuilder);
        }

        
        public IDbSet<Domain.Car> Cars { get; set; }
    }
}
