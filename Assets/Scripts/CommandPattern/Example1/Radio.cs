using UnityEngine;

namespace CommandPattern.Example1
{
    public class Radio : IElectronicDevice
    {
        protected int volume;
        public void On()
        {
            Debug.Log("Radio On");
        }

        public void Off()
        {
            Debug.Log("Radio Off");
        }

        public void VolumeUp()
        {
            ++volume;
            Debug.Log("Radio VolumeUp" + volume);
        }

        public void VolumeDown()
        {
            if (volume > 0)
            {
                --volume;
                
            }
            Debug.Log("Radio VolumeDown" + volume);
        }
    }
}