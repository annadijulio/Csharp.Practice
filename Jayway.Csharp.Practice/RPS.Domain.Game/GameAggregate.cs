using System;
using System.Data;

namespace RPS.Domain.Game
{
    /// <summary>
    /// GameAggregate is the only class that can change State
    /// </summary>
    public class GameAggregate
    {
        private readonly GameState _state;

        public GameAggregate(GameState state)
        {
            _state = state;
        }

        public void CreateGame(string name)
        {
            if(!string.IsNullOrWhiteSpace(_state.Name))
            throw new ConstraintException("This game already exists.");    
                
            _state.Name = name;
        }
    }
}