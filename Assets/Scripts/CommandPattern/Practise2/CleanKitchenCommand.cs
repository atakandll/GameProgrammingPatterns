using System.Collections.Generic;

namespace CommandPattern.Practise2
{
    public class CleanKitchenCommand : ICommand
    {
        private List<IFamily> _familyList;
        public CleanKitchenCommand(List<IFamily> familyList)
        {
            _familyList = familyList;
        }

        public void Execute()
        {
            foreach (var family in _familyList)
            {
                family.UseSoup();
                
            }
        }

        public void Undo()
        {
            foreach (var family in _familyList)
            {
                family.UseDetergent();
            }
        }
    }
}