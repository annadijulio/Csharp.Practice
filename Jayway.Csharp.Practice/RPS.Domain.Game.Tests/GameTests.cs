using System;
using System.Data;
using NUnit.Framework;

namespace RPS.Domain.Game.Tests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void CreateGameSetsName()
        {
            //Arrange
            var state = new GameState();

            var aggregate = new GameAggregate(state);

            //Act
            aggregate.CreateGame("Brand new game");

            //Assert
            Assert.AreEqual("Brand new game", state.Name);

        }

        [Test, ExpectedException(typeof(ConstraintException))]
        public void CreateGameSetsNameShouldThrow()
        {
            //Arrange
            var state = new GameState() { Name = "testGame"};

            var aggregate = new GameAggregate(state);

            //Act
            aggregate.CreateGame("Brand new game");

            //Assert
            Assert.AreEqual("Brand new game", state.Name);

        }
    }
}