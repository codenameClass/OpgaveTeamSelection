using System;

namespace Ontwerp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            throw new PlayerinfoException(new NoIntFormatException("test"));
        }
    }
    class PlayerinfoException : Exception
    {
        public IPlayerinfoException Exception { get; set; }

        public PlayerinfoException(IPlayerinfoException exception) => Exception = exception;
    }
    interface IPlayerinfoException
    {

    }
    class NoIntFormatException : Exception, IPlayerinfoException
    {
        //FormatException
        public NoIntFormatException(string message) : base(message)
        {
            
        }
    }
    class NumberValueException : Exception, IPlayerinfoException
    {

    }
}
