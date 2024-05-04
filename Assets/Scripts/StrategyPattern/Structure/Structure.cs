using UnityEngine;

namespace StrategyPattern.Structure
{
    public class Example
    {
        private IStrategy _strategyA = new StrategyA();
        private IStrategy _strategyB = new StrategyB();
        
        private IStrategy CurrentStrategy { get; set; }

        public void ExecuteStrategy()
        {
            CurrentStrategy.Execute();
        }

        public Example()
        {
            CurrentStrategy = _strategyA;
            
        }

        public void SwapStrategy()
        {
            CurrentStrategy = CurrentStrategy == _strategyA ? _strategyB : _strategyA;
            
        }
    }
    public class Client
    {
        private IStrategy strategy { get; }
        
        public Client(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        
        public void ExecuteStrategy()
        {
            strategy.Execute();
        }
        
    }

    public interface IStrategy
    {
        void Execute();
    }

    public class StrategyA : IStrategy
    {
        public void Execute()
        {
            Debug.Log("Strategy A");
        }
    }
    public class StrategyB : IStrategy
    {
        public void Execute()
        {
            Debug.Log("Strategy B");
        }
    }
}