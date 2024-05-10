using AbstractFactoryPattern.Structure;

namespace AbstractFactoryPattern.Practise
{
    class Factory2 : Factory
    {
        public override Chocolate CreateChocolate()
        {
            return new ConcreteChocolate2();
        }

        public override Pencil CreatePencil()
        {
            return new ConcretePencil2();
        }
    }
}