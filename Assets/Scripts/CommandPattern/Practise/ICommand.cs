namespace CommandPattern.Practise
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}