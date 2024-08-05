using UnityEngine;

namespace CommandPattern.Practise2
{
    public class Son : IFamily
    {
        public void UseSoup()
        {
            Debug.Log("Son use Soup");
            
        }

        public void UseDetergent()
        {
            Debug.Log("Son use Detergent");
        }
    }
}