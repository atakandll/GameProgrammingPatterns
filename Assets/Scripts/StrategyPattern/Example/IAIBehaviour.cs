namespace StrategyPattern.Example
{
    public interface IAIBehaviour
    {
        void DestroyPiece(IGameState gameState);
        void MovePiece(IGameState gameState);
    }
}