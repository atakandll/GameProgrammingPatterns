namespace FactoryPattern.Structure
{
    #region Abstraction

    public interface IProduct
    {
        
    }
    public interface IFactory
    {
        IProduct Create();
    }

    #endregion

    #region Concrete
    public class ProductA : IProduct
    {
        
    }

    public class ProductB : IProduct
    {
        
    }
    
    public class FactoryA : IFactory
    {
        public IProduct Create() => new ProductA();
    }
    public class FactoryB : IFactory
    {
        public IProduct Create() => new ProductB();

    }

    #endregion
   

   
}