using PGN_Parser.Handlers;

namespace PGN_Parser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputFile = args[0];
            var outputDirectory = args[1];

            var _handler = new ParsingHandler();
            var successful = _handler.Handle(inputFile, outputDirectory);
            string message = successful ? "Files handled successfully..." : "File handling failed...";
            Console.WriteLine(message);
        }
    }
}