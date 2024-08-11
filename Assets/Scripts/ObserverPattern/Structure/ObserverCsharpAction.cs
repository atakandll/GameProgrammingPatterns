using System;
using UnityEngine;

namespace ObserverPattern.Structure
{
    public abstract class ObserverCsharpAction
    {
        public static Action OnStartGame = delegate { };
        public static Action<int, float, bool> OnEndGame = delegate{};
        public static Action OnPassTurn = delegate { };
        public static Action OnEndTurn = delegate { };
       
    }
}