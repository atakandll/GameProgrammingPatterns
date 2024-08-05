using System.Collections.Generic;

namespace CommandPattern.Practise2
{
    public class CleanToiletCommand : ICommand
    {
        private List<IFamily> _familyList;
        
        public CleanToiletCommand(List<IFamily> familyList)
        {
            _familyList = familyList;
        }
        public void Execute()
        {
            foreach (var family in _familyList)
            {
                family.UseDetergent();
                
            }
        }

        public void Undo()
        {
            foreach (var family in _familyList)
            {
                family.UseSoup();
            }
        }
    }
}