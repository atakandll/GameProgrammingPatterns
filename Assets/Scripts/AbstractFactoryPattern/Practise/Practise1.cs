using AbstractFactoryPattern.Structure;
using UnityEngine;

namespace AbstractFactoryPattern.Practise
{
    public class Practise1 : MonoBehaviour
    {
        private void Start()
        {
            // 1. factory için
            Factory factory1 = new Factory1();
            
            _Client client1 = new _Client(factory1);
            client1.Use();
            
            // 2. factory ，
            Factory factory2 = new Factory2();
            _Client client2 = new _Client(factory2);
            client2.Use();
        }
    }
    

    

  
}
    