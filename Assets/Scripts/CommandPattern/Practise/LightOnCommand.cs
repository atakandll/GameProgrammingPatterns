namespace CommandPattern.Practise
{
    public class LightOnCommand : ICommand
    {
        private readonly Reciever _reciever;

        public LightOnCommand(Reciever reciever)
        {
            this._reciever = reciever;
        }
        public void Execute()
        {
            _reciever.LightOn();
        }

        public void Undo()
        {
            _reciever.LightOff();
        }
    }
}