namespace CommandPattern.Example1
{
    public class TVRemove
    {
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}