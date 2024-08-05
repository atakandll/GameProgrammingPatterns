using UnityEngine;

namespace CommandPattern.Practise2
{
    public class Mom : IFamily
    {
        public void UseSoup()
        {
            Debug.Log("Mom is using soup");
        }

        public void UseDetergent()
        {
            Debug.Log("Mom is using detergent");
        }
    }
}