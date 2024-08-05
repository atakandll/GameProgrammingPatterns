using UnityEngine;

namespace CommandPattern.Practise2
{
    public class Dad : IFamily
    {
        public void UseSoup()
        {
            Debug.Log("Dad is using soup");
        }

        public void UseDetergent()
        {
            Debug.Log("Dad is using detergent");
        }
    }
}