using System.Collections.Generic;

namespace CommandPattern.Example1
{
    public class TurnVolumeUpCommand : ICommand
    {
        private readonly List<IElectronicDevice> _electronicDevice;

        public TurnVolumeUpCommand(List<IElectronicDevice> electronicDevice)
        {
            _electronicDevice = electronicDevice;
        }
        public void Execute()
        {
            foreach (var device in _electronicDevice)
            {
                device.VolumeUp();
            }
        }

        public void Undo()
        {
            foreach (var device in _electronicDevice)
            {
                device.VolumeDown();
            }
        }
    }
}