using AbstractFactoryPattern.Structure;

namespace AbstractFactoryPattern.Practise
{
    public abstract class Factory
    {
        public abstract Chocolate CreateChocolate();
        public abstract Pencil CreatePencil();
    }
}