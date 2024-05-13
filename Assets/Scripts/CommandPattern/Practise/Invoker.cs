using UnityEngine;

namespace CommandPattern.Practise
{
    public class Invoker
    {
        private readonly ICommand _lightOnCommand;
        private readonly ICommand _lightOffCommand;
        private readonly ICommand _lightUpCommand;
        private readonly ICommand _lightDownCommand;

        public Invoker(ICommand lightOnCommand, ICommand lightOffCommand, ICommand lightUpCommand,
            ICommand lightDownCommand)
        {
            _lightOnCommand = lightOnCommand;
            _lightOffCommand = lightOffCommand;
            _lightUpCommand = lightUpCommand;
            _lightDownCommand = lightDownCommand;
            
        }
        public void ClickLightOn()
        {
            _lightOnCommand.Execute();
        }

        public void ClickLightOff()
        {
            _lightOffCommand.Execute();
        }

        public void ClickLightUp()
        {
            _lightUpCommand.Execute();
        }

        public void ClickLightDown()
        {
            _lightDownCommand.Execute();
        }

       
    }
    

    
}