using UnityEngine;

namespace AbstractFactoryPattern.Example1
{
    public class AbstractFactoryPatternExample1 : MonoBehaviour
    {

        private void Start()
        {
            ContinentFactory factory1 = new AfricaFactory();
            ContinentFactory factory2 = new AmericaFactory();
            
            Client client1 = new Client(factory1);
            Client client2 = new Client(factory2);
            
            client1.Run();
            client2.Run();
        }
        
    }
    #region Products

    
    // Products 1
    public abstract class Herbivore
    {
        
    }
    
    // Products 2
    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore herbivore);
    }

    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Debug.Log("Wolf eats " + herbivore.GetType().Name);
        }
    }

    public class Wildebeest : Herbivore
    {
        
    }
    
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Debug.Log("Lion eats " + herbivore.GetType().Name);
        }
    }

    public class Bison : Herbivore
    {
        
    }
    
    #endregion

    #region Factory

    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    internal class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }

    internal class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

    }
    #endregion

    #region Client

    internal class Client
    {
        private readonly Herbivore _herbivore;
        private readonly Carnivore _carnivore;
        public Client(ContinentFactory continentFactory)
        {
            _herbivore = continentFactory.CreateHerbivore();
            _carnivore = continentFactory.CreateCarnivore();
        }

        public void Run()
        {
           _carnivore.Eat(_herbivore);
        }
    }

    #endregion


}