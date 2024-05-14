using UnityEngine;

namespace CommandPattern.Practise
{
    public class Invoker
    {
        private readonly ICommand cmd;
      

        public Invoker(ICommand cmd)
        {
            this.cmd = cmd;
        }
        public void On()
        {
            cmd.Execute();
        }

        public void Off()
        {
            cmd.Undo();
        }
       

       
    }
    

    
}