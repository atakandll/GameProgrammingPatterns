using UnityEngine;

namespace DecoratorPattern.Example1
{
    public class DecoratorUsage : MonoBehaviour
    {
        private void Start()
        {
            IPizza plainPizza = new PlainPizza();
            PizzaDecorator pizzaCheeseDecorator = new Cheese(plainPizza);
            PizzaDecorator pizzaOliveDecorator = new Olives(pizzaCheeseDecorator);
            PizzaDecorator pizzaOliveDecorator2 = new Olives(plainPizza);

            Debug.Log(pizzaOliveDecorator.GetDescription());
            Debug.Log(pizzaOliveDecorator.GetCost());
            Debug.Log(pizzaOliveDecorator2.GetCost());

        }

        public interface IPizza
        {
            string GetDescription();
            double GetCost();
        }

        public class PlainPizza : IPizza
        {
            public string GetDescription()
            {
                return "Plain Pizza";
            }

            public double GetCost()
            {
                return 10.00;
            }
        }

        public abstract class PizzaDecorator : IPizza
        {
            protected IPizza _pizza;

            protected PizzaDecorator(IPizza pizza)
            {
                _pizza = pizza;
            }

            public virtual string GetDescription()
            {
                return _pizza.GetDescription();
            }

            public virtual double GetCost()
            {
                return _pizza.GetCost();
            }
        }

        public class Cheese : PizzaDecorator
        {
            public Cheese(IPizza pizza) : base(pizza)
            {
                Debug.Log("Adding Cheese");
            }

            public override string GetDescription()
            {
                return $"{_pizza.GetDescription()}, Cheese";
            }

            public override double GetCost()
            {
                return _pizza.GetCost() + 2.00;
            }

        }

        public class Olives : PizzaDecorator
        {
            public Olives(IPizza pizza) : base(pizza)
            {
                Debug.Log("Adding Olives");
            }

            public override string GetDescription()
            {
                return $"{_pizza.GetDescription()}, Olives";
            }

            public override double GetCost()
            {
                return _pizza.GetCost() + 3.00;
            }

        }
    }
}