using UnityEngine;
using Utils.Attributes;

namespace FactoryPattern.Example1
{
    public class AIFactoryUsage : MonoBehaviour
    {
        readonly AIBaseFactory aIFactory = new AIFactory();
        readonly AIBase[] players = new AIBase[4];

        private void Awake()
        {
            Populate();
        }
        
        [Button]
        private void Populate()
        {
            for(var i = 0; i < players.Length; i++)
                players[i] = aIFactory.CreateRandom();
        }
        [Button]
        private void DoPlayersMove()
        {
            for (var i = 0; i < players.Length; i++)
            {
                Debug.Log("Player [" + i + "]");
                players[i].DoMove();
                
            }
        }
    }
}