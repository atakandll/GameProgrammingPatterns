using UnityEngine;

namespace StrategyPattern.Example
{
    public class AIHard : IAIBehaviour
    {
        public void DestroyPiece(IGameState gameState)
        {
            Debug.Log("AI Hard Destroy Piece");
        }

        public void MovePiece(IGameState gameState)
        {
            Debug.Log("AI Hard Move Piece");
        }
    }
}