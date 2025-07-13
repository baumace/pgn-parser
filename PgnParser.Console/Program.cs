using PgnParser.Services.Handlers;

namespace PgnParser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputFile = args[0];
            var outputDirectory = args[1];

            var handler = new ParsingHandler();
            var successful = handler.Handle(inputFile, outputDirectory);
            string message = successful ? "Files handled successfully..." : "File handling failed...";
            Console.WriteLine(message);
        }
    }
}