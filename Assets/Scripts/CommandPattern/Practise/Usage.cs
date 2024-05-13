using UnityEngine;

namespace CommandPattern.Practise
{
    public class Usage : MonoBehaviour
    {
        private void Start()
        {
            Invoker invoker = new Invoker(new LightOnCommand(new Reciever()), new LightOffCommand(new Reciever()),
                new LightUpCommand(new Reciever()), new LightDownCommand(new Reciever()));
            
            invoker.ClickLightOn();
            invoker.ClickLightOff();
            invoker.ClickLightUp();
            invoker.ClickLightDown();
            
            
            
        }
    }
}