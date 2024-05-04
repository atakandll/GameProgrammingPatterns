using UnityEngine;
using UnityEngine.Serialization;
using Utils.Attributes;

namespace StrategyPattern.Example
{
    public class AIClient : MonoBehaviour
    {
       
        private readonly IAIBehaviour _aiBehaviourEasy = new AIEasy();
        private readonly IAIBehaviour _aiBehaviourMedium = new AIMedium();
        private readonly IAIBehaviour _aiBehaviourHard = new AIHard();
        private readonly IGameState _gameState = new GameState();
        
        [SerializeField] private AiType _aiType = AiType.Medium;
        
        
        [Button]
        public void MovePiece()
        {
            switch (_aiType)
            {
                case  AiType.Easy:
                    _aiBehaviourEasy.MovePiece(_gameState);
                    break;
                case  AiType.Medium:
                    _aiBehaviourMedium.MovePiece(_gameState);
                    break;
                case  AiType.Hard:
                    _aiBehaviourHard.MovePiece(_gameState);
                    break;
            }
        }
        [Button]
        public void DestroyPiece()
        {
            switch (_aiType)
            {
                case  AiType.Easy:
                    _aiBehaviourEasy.DestroyPiece(_gameState);
                    break;
                case  AiType.Medium:
                    _aiBehaviourMedium.DestroyPiece(_gameState);
                    break;
                case  AiType.Hard:
                    _aiBehaviourHard.DestroyPiece(_gameState);
                    break;
            }
        }
        
        
    }
  
}