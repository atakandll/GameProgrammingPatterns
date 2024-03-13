using ObjectPooling.Structure;

namespace ObjectPooling.Example1
{
    public class APoolerObject: GenericPooler<APooledObject>
    {
        public APoolerObject(int startSize) : base(startSize)
        {
        }
    }
}