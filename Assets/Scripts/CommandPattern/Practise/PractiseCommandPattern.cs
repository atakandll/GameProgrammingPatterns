using UnityEngine;

namespace CommandPattern.Practise
{
    public class PractiseCommandPattern : MonoBehaviour
    {
        private void Start()
        {
            Reciever reciever = new Reciever();
            
            LightOnCommand lightOnCommand = new LightOnCommand(reciever);

            Invoker invoker = new Invoker(lightOnCommand);
            invoker.On();
            invoker.Off();
            
            // --------------------------------------------------------------------
            LightOffCommand lightOffCommand = new LightOffCommand(reciever);
            invoker = new Invoker(lightOffCommand);
            invoker.Off();
            invoker.On();
            
            // --------------------------------------------------------------------
            LightUpCommand lightUpCommand = new LightUpCommand(reciever);
            invoker = new Invoker(lightUpCommand);
            invoker.Off();
            invoker.On();   

            // --------------------------------------------------------------------
            LightDownCommand lightDownCommand = new LightDownCommand(reciever);
            invoker = new Invoker(lightDownCommand);
            invoker.Off();
            invoker.On();
            
                
            
            
            
        }
    }
}