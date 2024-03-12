using System.Collections.Generic;

namespace ObserverPattern.Structure
{
    internal abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public void Add(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Remove(Observer observer)
        {
            _observers.Remove(observer);
            
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}