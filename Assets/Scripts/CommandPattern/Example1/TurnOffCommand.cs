using System.Collections.Generic;

namespace CommandPattern.Example1
{
    public class TurnOffCommand : ICommand
    {
        private readonly List<IElectronicDevice> _electronicDevice;

        public TurnOffCommand(List<IElectronicDevice> electronicDevice)
        {
            _electronicDevice = electronicDevice;
        }
        public void Execute()
        {
            foreach (var device in _electronicDevice)
            {
                device.Off();
            }
        }

        public void Undo()
        {
            foreach (var device in _electronicDevice)
            {
                device.On();
            }
                
        }
    }
}