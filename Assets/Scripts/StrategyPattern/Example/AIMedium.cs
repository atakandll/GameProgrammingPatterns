using UnityEngine;

namespace StrategyPattern.Example
{
    public class AIMedium : IAIBehaviour
    {
        public void DestroyPiece(IGameState gameState)
        {
            Debug.Log("AI Medium Destroy Piece");
        }

        public void MovePiece(IGameState gameState)
        {
            Debug.Log("AI Medium Move Piece");
        }
    }
}