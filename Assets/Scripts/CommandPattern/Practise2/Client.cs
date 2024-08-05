using System;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.Practise2
{
    public class Client : MonoBehaviour
    {
        private void Start()
        {
            List<IFamily> familyList = new List<IFamily>();

            Mom mom = new Mom();
            Dad dad = new Dad();
            Son son = new Son();

            familyList.Add(mom);
            familyList.Add(dad);
            familyList.Add(son);
            
            CleanKitchenCommand cleanKitchenCommand = new CleanKitchenCommand(familyList);
            cleanKitchenCommand.Execute();
            cleanKitchenCommand.Undo();
            
            CleanToiletCommand cleanToiletCommand = new CleanToiletCommand(familyList);
            cleanToiletCommand.Execute();
            cleanToiletCommand.Undo();
            
        }
    }
}