using StatePattern.Structure;
using UnityEngine;

namespace StatePattern.Example1
{
    public class StartGameState : IState
    {
        public bool IsInitialized { get; }

        public void OnInitialize() => Debug.Log("On Initialize ----> " + GetType());

        public void OnEnterState() => Debug.Log("On Enter ----> " + GetType());

        public void OnExitState() => Debug.Log("On Exit ----> " + GetType());

        public void OnUpdate() => Debug.Log("On Update ----> " + GetType());

        public void OnClear() => Debug.Log("On Clear ----> " + GetType());
    }
}