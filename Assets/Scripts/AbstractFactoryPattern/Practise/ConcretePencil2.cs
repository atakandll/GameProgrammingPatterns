using AbstractFactoryPattern.Structure;
using UnityEngine;

namespace AbstractFactoryPattern.Practise
{
    public class ConcretePencil2 : Pencil
    {
        public override void Write()
        {
            Debug.Log("Pencil2 writing");
        }
    }
}