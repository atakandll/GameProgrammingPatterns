using System.Collections.Generic;

namespace CommandPattern.Example1
{
    public class TurnVolumeDownCommand : ICommand
    {
        private readonly List<IElectronicDevice> _electronicDevice;

        public TurnVolumeDownCommand(List<IElectronicDevice> electronicDevice)
        {
            _electronicDevice = electronicDevice;
        }
        public void Execute()
        {
            foreach (var device in _electronicDevice)
            {
                device.VolumeDown();
            }
        }

        public void Undo()
        {
            foreach (var device in _electronicDevice)
            {
                device.VolumeUp();
            }
        }
    }
}