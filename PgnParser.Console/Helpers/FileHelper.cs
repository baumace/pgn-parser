using System.Globalization;
using Microsoft.Extensions.Logging;
using PgnParser.DataModels.Interfaces;

namespace PgnParser.Helpers;

public class FileHelper
{
    private readonly ILogger _logger;
    
    public FileHelper(ILogger logger)
    {
        _logger = logger;
    }
    
    /// <summary>
    /// Reads the PGN input from the input file path.
    /// </summary>
    /// <param name="inputFilePath"></param>
    /// <returns>List of non-empty lines from the input file</returns>
    public List<string> ReadFile(string inputFilePath)
    {
        var cleanedFilePath = CleanFilePath(inputFilePath);
        _logger.LogDebug($"Reading file {cleanedFilePath}...");

        var lines = new List<string>();
        using var reader = new StreamReader(cleanedFilePath);
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            if (!string.IsNullOrWhiteSpace(line))
            {
                lines.Add(line.Trim());
            }
        }

        return lines;
    }

    /// <summary>
    /// Writes the PGN output to the specified file path.
    /// </summary>
    /// <param name="outputFilePath"></param>
    /// <param name="games"></param>
    public void WriteFile(string outputFilePath, List<IGame> games)
    {
        var cleanedOutputPath = CleanFilePath(outputFilePath);
        
        var printedGameCount = 0;
        games.ForEach(game =>
        {
            var date = DateTime.Now;
            var fileName = $"pgn_parser_{date:yyMMddHHssffff}.pgn";

            try
            {
                using var writer = new StreamWriter(Path.Combine(outputFilePath, fileName));
                writer.WriteLine(game.ToPgnFormat());
                printedGameCount++;
            } 
            catch (Exception ex)
            {
                _logger.LogError($"Failed to write game to file {fileName}: {ex.Message}");
            }
        });

        _logger.LogDebug($"Wrote {printedGameCount} files to {cleanedOutputPath}...");
    }
    
    private string CleanFilePath(string filePath)
    {
        var cleanedPath = filePath.Trim();

        if (!cleanedPath.StartsWith("~")) return cleanedPath;
        
        var home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        return Path.Combine(home, cleanedPath.TrimStart('~', '/', '\\'));
    }
}