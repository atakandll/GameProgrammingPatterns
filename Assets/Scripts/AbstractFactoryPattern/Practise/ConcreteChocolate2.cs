using UnityEngine;

namespace AbstractFactoryPattern.Practise
{
    public class ConcreteChocolate2 : Chocolate
    {
        public override void Eat()
        {
            Debug.Log("chocolate2 eating");
        }
    }
}