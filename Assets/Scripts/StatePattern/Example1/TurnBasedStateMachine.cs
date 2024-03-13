using StatePattern.Structure;

namespace StatePattern.Example1
{
    public class TurnBasedStateMachine : BaseStateMachine
    {
        private readonly AITurnState aiTurn = new AITurnState();
        private readonly PlayerTurnState playerTurn = new PlayerTurnState();
        private readonly EndGameState endGame = new EndGameState();
        private readonly StartGameState startGame = new StartGameState();
        
        // Register the states before the initialization
        protected override void OnBeforeInitialize()
        {
            RegisterState(aiTurn);
            RegisterState(playerTurn);
            RegisterState(endGame);
            RegisterState(startGame);
        }

        public void PlayerTurn() => PushState(playerTurn);
        public void AITurn() => PushState(aiTurn);
        public void EndGame() => PushState(endGame);
        public void StartGame() => PushState(startGame);
    }
}