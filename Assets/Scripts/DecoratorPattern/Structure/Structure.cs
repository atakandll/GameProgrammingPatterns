using System;
using UnityEngine;

namespace DecaratorPattern.Structure
{
    public class Structure : MonoBehaviour
    {
        private void Start()
        {
            IComponent component = new ConcreteComponent();
            Decorator decoratorA = new ConcreteDecoratorA(component);
            Decorator decoratorB = new ConcreteDecoratorB(decoratorA);
            
            Debug.Log(decoratorB.Operation());
            
        }
    }

    public interface IComponent
    {
        string Operation();
    }
    public class ConcreteComponent : IComponent
    {
        public string Operation()
        {
            return "ConcreteComponent";
        }
    }

    public abstract class Decorator : IComponent
    {
        protected IComponent _component;

        protected Decorator(IComponent component)
        {
            _component = component;
        }
        public virtual string Operation()
        {
            return _component.Operation();
        }
    }

    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component)
        {
        }

        public override string Operation()
        {
            base.Operation();
            return $" Operation A {base._component.Operation()}";
        }
    }
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component)
        {
        }

        public override string Operation()
        {
            base.Operation();
            return $" Operation B {base._component.Operation()}";
        }

        private void AddedBehaviour()
        {
            Debug.Log("AddedBehaviour");
        }
    }
}