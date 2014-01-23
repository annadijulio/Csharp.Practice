using Jayway.Cars.Infrastructure.Ef;
using Jayway.Cars.Infrastructure.Ef.Dummy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jayway.Cars.IT
{
    [TestFixture]
    public class DatabaseTests
    {
   
        [Test]
        public void CreateDatabase() {

            var ctx = new CarContext(new Tests.TestLogger());
            ctx.Database.Delete();
            ctx.Database.Create();

            Assert.IsTrue(ctx.Database.Exists());
        }
    }
}
