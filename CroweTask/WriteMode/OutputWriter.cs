using System;

namespace WriteMode
{
    public abstract class OutputWriter
    {
        public static OutputWriter GetOutputWriter(string WriteMode)
        {
            switch (WriteMode)
            {
                case "Console":
                    return new ConsoleOutput();
                case "Database":
                    return new DatabaseOutput();
                default:
                    return new ConsoleOutput(); // default Console

            }
        }
        public abstract void Write(string message);
    }
    
    // Use common design patterns(inheritance, e.g.) to account for these future concerns.
    public class DatabaseOutput : OutputWriter
    {
        public override void Write(string message)
        {
            throw new NotImplementedException();
        }
    }   
    public class ConsoleOutput : OutputWriter
    {
        public override void Write(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
