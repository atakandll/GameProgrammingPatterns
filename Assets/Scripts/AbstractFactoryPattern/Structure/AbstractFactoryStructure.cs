using UnityEngine;

namespace AbstractFactoryPattern.Structure
{

    #region Usage

    public class AbstractFactoryStructure : MonoBehaviour
    {

        private void Start()
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();
            
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();
        }

    }

    #endregion
    
    # region Abstraction

    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    abstract class AbstractProductA
    {

    }

    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    #endregion

    #region Concrete

    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }

    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
           return new ConcreteProductB2();
        }
        

    }

    class ConcreteProductA1 : AbstractProductA
    {
        
    }
    class ConcreteProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Debug.Log(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }

    class ConcreteProductA2 : AbstractProductA 
    {
        
    }

    class ConcreteProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Debug.Log(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }

    #endregion

    #region Client

    class Client
    {
        private AbstractProductA _productA;
        private AbstractProductB _productB;

        public Client(AbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }

        public void Run()
        {
            _productB.Interact(_productA);
        }
    }

    #endregion
    
    
}