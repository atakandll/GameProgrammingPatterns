using UnityEngine;

namespace StrategyPattern.Example
{
    public class AIEasy : IAIBehaviour
    {
        public void DestroyPiece(IGameState gameState)
        {
            Debug.Log("AI Easy Destroy Piece");
        }

        public void MovePiece(IGameState gameState)
        {
            Debug.Log("AI Easy Move Piece");
        }
    }
}