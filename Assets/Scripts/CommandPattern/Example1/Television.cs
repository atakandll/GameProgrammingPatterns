using UnityEngine;

namespace CommandPattern.Example1
{
    public class Television : IElectronicDevice
    {
        protected int volume;
        public void On()
        {
           Debug.Log("Television On");
        }

        public void Off()
        {
            Debug.Log("Television Off");
        }

        public void VolumeUp()
        {
            volume += 10;
            Debug.Log("Television VolumeUp" + volume);
        }

        public void VolumeDown()
        {
            if (volume > 10)
                --volume;
            
            Debug.Log("Television VolumeDown" + volume);
        }
    }
}