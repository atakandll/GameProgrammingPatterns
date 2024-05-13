namespace CommandPattern.Practise
{
    public class LightDownCommand : ICommand
    {
        private readonly Reciever _reciever;

        public LightDownCommand(Reciever reciever)
        {
            this._reciever = reciever;
        }
        public void Execute()
        {
            _reciever.LightDown();
        }

        public void Undo()
        {
            _reciever.LightUp();
        }
    }
}