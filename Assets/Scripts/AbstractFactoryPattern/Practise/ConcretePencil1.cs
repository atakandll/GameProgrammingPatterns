using UnityEngine;

namespace AbstractFactoryPattern.Practise
{
    public class ConcretePencil1 : Pencil
    {
        public override void Write()
        {
            Debug.Log("Pencil1 writing");
        }
    }
}