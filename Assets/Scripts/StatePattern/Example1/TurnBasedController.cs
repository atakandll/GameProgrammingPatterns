using UnityEngine;
using Utils.Attributes;

namespace StatePattern.Example1
{
    public class TurnBasedController : MonoBehaviour
    {
        readonly TurnBasedStateMachine turnBasedStateMachine = new TurnBasedStateMachine();

        private void Awake()
        {
            turnBasedStateMachine.Initialize();
        }
        
        [Button]
        public void AITurn() => turnBasedStateMachine.AITurn();
        
        
        [Button]
        public void PlayerTurn() => turnBasedStateMachine.PlayerTurn();
        
        [Button]
        public void EndGame() => turnBasedStateMachine.EndGame();
        

        [Button]
        public void StartGame() => turnBasedStateMachine.StartGame();
    }
}