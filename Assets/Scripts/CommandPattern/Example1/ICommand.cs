namespace CommandPattern.Example1
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}