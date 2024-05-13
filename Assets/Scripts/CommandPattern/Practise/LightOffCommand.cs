namespace CommandPattern.Practise
{
    public class LightOffCommand : ICommand
    {
        private readonly Reciever _reciever;

        public LightOffCommand(Reciever reciever)
        {
            this._reciever = reciever;
        }
        public void Execute()
        {
            _reciever.LightOff();
        }

        public void Undo()
        {
            _reciever.LightOn();
        }
    }
}