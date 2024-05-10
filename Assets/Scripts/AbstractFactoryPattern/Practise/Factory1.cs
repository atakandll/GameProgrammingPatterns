using AbstractFactoryPattern.Structure;

namespace AbstractFactoryPattern.Practise
{
    class Factory1 : Factory
    {
        public override Chocolate CreateChocolate()
        {
            return new ConcreteChocolate1();
        }

        public override Pencil CreatePencil()
        {
            return new ConcretePencil1();
        }
    }
}