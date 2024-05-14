using System.Collections.Generic;

namespace CommandPattern.Example1
{
    public class TurnOnCommand : ICommand
    {
        private readonly List<IElectronicDevice> _electronicDevice;

        public TurnOnCommand(List<IElectronicDevice> electronicDevice)
        {
            _electronicDevice = electronicDevice;
        }
        public void Execute()
        {
            foreach (var device in _electronicDevice)
            {
                device.On();
            }
        }

        public void Undo()
        {
            foreach (var device in _electronicDevice)
            {
                device.Off();
            }
        }
    }
}