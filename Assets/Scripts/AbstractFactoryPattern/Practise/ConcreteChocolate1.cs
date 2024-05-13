using UnityEngine;

namespace AbstractFactoryPattern.Practise
{
    public class ConcreteChocolate1 : Chocolate
    {
        public override void Eat()
        {
            Debug.Log("chocolate eating");
        }
    }
}