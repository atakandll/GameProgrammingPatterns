
namespace AbstractFactoryPattern.Practise
{
    public class _Client
    {
        private Chocolate _chocolate;
        private Pencil _pencil;

        public _Client(Factory factory)
        {
            _chocolate = factory.CreateChocolate();
            _pencil = factory.CreatePencil();
        }

        public void Use()
        {
            _chocolate.Eat();
            _pencil.Write();
        }
        
    }
}