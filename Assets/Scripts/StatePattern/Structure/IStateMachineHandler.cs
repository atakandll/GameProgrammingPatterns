using UnityEngine;

namespace StatePattern.Structure
{
    public interface IStateMachineHandler
    {
        BaseStateMachine Fsm { get; }
        MonoBehaviour MonoBehaviour { get; }
    }
}