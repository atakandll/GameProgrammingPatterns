using System;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.Example1
{
    
    // Invoker class which holds the all commands
    public class UsageCommandPattern : MonoBehaviour
    {
        private void Start()
        {
            
            List<IElectronicDevice> electronicDevices = new List<IElectronicDevice>();
            Television television = new Television();
            Radio radio = new Radio();
            electronicDevices.Add(television);
            electronicDevices.Add(radio);
            //----------------------------------------------------------------------
            TurnOnCommand onCommand = new TurnOnCommand(electronicDevices);
            
            DeviceButton deviceButton = new DeviceButton(onCommand);
            deviceButton.Press();
            deviceButton.Undo();
            //----------------------------------------------------------------------
            TurnOffCommand offCommand = new TurnOffCommand(electronicDevices);
            
            DeviceButton deviceButton2 = new DeviceButton(offCommand);
            deviceButton2.Press();
            deviceButton2.Undo();
        }
    }
}
