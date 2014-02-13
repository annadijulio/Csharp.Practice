using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RPS.Domain.Game.Tests
{
    [TestFixture]
    public class RulesTests
    {

        [Test]
        [TestCase(Move.Paper, Move.Scissors, Result = Result.PlayerTwoWins)]
        [TestCase(Move.Paper, Move.Paper, Result = Result.Tie)]
        [TestCase(Move.Rock, Move.Rock, Result = Result.Tie)]
        [TestCase(Move.Scissors, Move.Scissors, Result = Result.Tie)]
        [TestCase(Move.Paper, Move.Rock, Result = Result.PlayerOneWins)]
        [TestCase(Move.Rock, Move.Scissors, Result = Result.PlayerOneWins)]
        [TestCase(Move.Scissors, Move.Rock, Result = Result.PlayerTwoWins)]
        [TestCase(Move.Rock, Move.Paper, Result = Result.PlayerTwoWins)]
        [TestCase(Move.Scissors, Move.Paper, Result = Result.PlayerOneWins)]
        public Result PlayRound(Move playerOneMove, Move playerTwoMove)
        {
            //Arrange

            //Act
            return Game.Rules.Play(playerOneMove, playerTwoMove);
            
            //Assert
        }

    }
}
