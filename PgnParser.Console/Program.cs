using Microsoft.Extensions.Logging;
using PgnParser.Helpers;
using PgnParser.Services;

namespace PgnParser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddConsole()
                    .SetMinimumLevel(LogLevel.Debug);
            });
            var logger = loggerFactory.CreateLogger<Program>();
            
            var inputFile = args[0];
            logger.LogDebug($"Input file: {inputFile}");
            
            var outputDirectory = args[1];
            logger.LogDebug($"Output directory: {outputDirectory}");
            
            var fileHelper = new FileHelper(logger);
            var input = fileHelper.ReadFile(inputFile);
            var games = new Parser(logger).Parse(input);
            fileHelper.WriteFile(outputDirectory, games);
        }
    }
}