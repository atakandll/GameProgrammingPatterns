namespace CommandPattern.Practise
{
    public class LightUpCommand : ICommand
    {
        private readonly Reciever _reciever;

        public LightUpCommand(Reciever reciever)
        {
            this._reciever = reciever;
        }
        public void Execute()
        {
            _reciever.LightUp();
        }

        public void Undo()
        {
            _reciever.LightDown();
        }
    }
}