namespace CommandPattern.Practise2
{
    public class CleanerUI
    {
        private ICommand _command;
        
        public CleanerUI(ICommand command)
        {
            _command = command;
        }
        
        public void Execute()
        {
            _command.Execute();
        }

        public void Undo()
        {
            _command.Undo();
        }
    }
}