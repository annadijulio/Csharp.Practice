using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS.Domain.Game
{
    public enum Move{
        Rock=100,
        Paper=200,
        Scissors=300
    }

    public enum Result
    {
        PlayerOneWins,
        PlayerTwoWins,
        Tie
    }
}
