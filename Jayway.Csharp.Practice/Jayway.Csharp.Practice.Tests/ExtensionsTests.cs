using System.Collections;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Jayway.Csharp.Practice.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jayway.Csharp.Practice.Tests
{
    [TestFixture]
    public class ExtensionsTests
    {

        [Test]
        public void Times()
        {
            var result = 3.Times(3);

            Assert.AreEqual(9, result);
        }

        public void IsNull()
        {
            //Arrange
            object item = null;
            
            //Act
            //var result = item.IsNull()

            //Assert.IsTrue(result);
        }

        [Test]
        public void ForEach()
        {
            //Arrange
            var ints = new List<int> {1, 2, 3};
            var i = 0;
            //Act
            ints.ForEach(x => i = i + x);

            //Assert
            Assert.AreEqual(6, i);
        }

        [Test]
        public void TestAny2Exists()
        {
            //Arrange
            var list = new List<int> { 1, 2, 3 } as IEnumerable<int>;

            //Assert
            Assert.IsTrue(list.Any2(nbr=>nbr==3));
        }

        [Test]
        public void TestAny2NotExist()
        {
            //Arrange
            var list = new List<int> { 1, 2, 3 } as IEnumerable<int>;

            //Assert
            Assert.IsFalse(list.Any2(nbr => nbr == 5));
        }
    }
}
