using CodeBase.Services.Input;

namespace CodeBase.Infrastructure
{
    public class Game
    {
        public static IInputService InputService;
        public GameStateMachine StateMachine { get; }

        public Game()
        {
            StateMachine = new GameStateMachine();
        }
    }
}