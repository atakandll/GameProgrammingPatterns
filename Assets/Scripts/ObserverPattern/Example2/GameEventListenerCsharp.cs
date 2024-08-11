using ObserverPattern.Structure;
using UnityEngine;

namespace ObserverPattern.Example2
{
    public class GameEventListenerCsharp : MonoBehaviour
    {
        private void OnEnable()
        {
            ObserverCsharpAction.OnStartGame += OnStartGame;
            ObserverCsharpAction.OnEndGame += OnEndGame;
            ObserverCsharpAction.OnPassTurn += OnPassTurn;
            ObserverCsharpAction.OnEndTurn += OnEndTurn;
        }

        private void Start()
        {
            ObserverCsharpAction.OnEndGame?.Invoke(1,2,true);
            ObserverCsharpAction.OnPassTurn?.Invoke();
            ObserverCsharpAction.OnEndTurn?.Invoke();
            ObserverCsharpAction.OnStartGame?.Invoke();
        }

        private void OnEndTurn()
        {
            Debug.Log("OnEndTurn");
        }

        private void OnPassTurn()
        {
            Debug.Log("OnPassTurn");
        }

        private void OnEndGame(int arg1, float arg2, bool arg3)
        {
            Debug.Log("OnEndGame" + arg1  + arg2 + arg3);
        }

        private void OnStartGame()
        {
            Debug.Log("OnStartGame");
        }

        private void OnDisable()
        {
            ObserverCsharpAction.OnStartGame -= OnStartGame;
            ObserverCsharpAction.OnEndGame -= OnEndGame;
            ObserverCsharpAction.OnPassTurn -= OnPassTurn;
            ObserverCsharpAction.OnEndTurn -= OnEndTurn;
        }
    }
}