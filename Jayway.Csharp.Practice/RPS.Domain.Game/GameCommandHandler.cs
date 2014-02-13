namespace RPS.Domain.Game
{
    public class GameCommandHandler
    {

        public void Handle(CreateGameCommand command)
        {
            
            GameAggregate aggregate = null;

            aggregate.CreateGame(command.Name);
        }

    }
}