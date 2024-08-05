namespace CommandPattern.Practise2
{
    public interface ICommand
    {
        void Execute();
        void Undo();
        
    }
}