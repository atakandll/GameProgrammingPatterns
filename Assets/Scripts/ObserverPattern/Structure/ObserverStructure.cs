using System;
using UnityEngine;

namespace ObserverPattern.Structure
{
    public class ObserverStructure : MonoBehaviour
    {
        private void Start()
        {
            ConcreteSubject concreteSubject = new ConcreteSubject();
            
            concreteSubject.Add(new ConcreteObserver("Atakan", concreteSubject));
            concreteSubject.Add(new ConcreteObserver("Cinar", concreteSubject));
            
            concreteSubject.SubjectState = "İsim değişti";
            concreteSubject.Notify();

            concreteSubject.SubjectState = "İsim ikinci kez değişti";
            concreteSubject.Notify();
        }
    }

    class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        private ConcreteSubject _subject;
        
        public ConcreteObserver(string name, ConcreteSubject subject)
        {
            _name = name;
            _subject = subject;
        }

        public override void Update()
        {
            _observerState = _subject.SubjectState;
            Debug.Log($"Name: {_name} :  ObserverState: {_observerState}");
        }
    }

    class ConcreteSubject : Subject
    {
        private string _subjectState;

        public string SubjectState
        {
            get => _subjectState;
            set => _subjectState = value;
        }
    }
}
