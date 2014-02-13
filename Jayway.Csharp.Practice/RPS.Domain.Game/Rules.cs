using System;
using System.Collections.Generic;
using System.Linq;

namespace RPS.Domain.Game
{
    public static class Rules
    {
        public static Result Play(Move playerOneMove, Move playerTwoMove)
        {
            if (playerOneMove == playerTwoMove)
                return Result.Tie;

            return (IsPlayerOneWinner(playerOneMove, playerTwoMove)) ? Result.PlayerOneWins : Result.PlayerTwoWins;
        }

        private static bool IsPlayerOneWinner(Move playerOneMove, Move playerTwoMove)
        {
            var round = Tuple.Create(playerOneMove, playerTwoMove);

            var playerOneWins = new List<Tuple<Move, Move>>
            {
                Tuple.Create(Move.Paper, Move.Rock),
                Tuple.Create(Move.Rock, Move.Scissors),
                Tuple.Create(Move.Scissors, Move.Paper)
            };

            return (playerOneWins.Any(x => x.Equals(round)));

        }
    }
}