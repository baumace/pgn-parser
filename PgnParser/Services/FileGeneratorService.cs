using PgnParser.DataModels.Interfaces;

namespace PgnParser.Services
{
    public class FileGeneratorService
    {
        public FileGeneratorService()
        {
        }

        /// <summary>
        /// Generates a new output file for each game in the list.
        /// </summary>
        /// <param name="gameList"></param>
        /// <param name="outputFilePath"></param>
        public void Generate(IGameList gameList, string outputFilePath)
        {
            int idx = 0;
            gameList.GetGames().ForEach(game =>
            {
                PrintGame(game, outputFilePath);
                ++idx;
            });
            Console.WriteLine($"{idx} games printed into {outputFilePath}...");
        }

        /// <summary>
        /// Prints a single game to the stream.
        /// </summary>
        /// <param name="game"></param>
        /// <param name="writer"></param>
        private void PrintGame(IGame game, string outputFilePath)
        {
            using (var writer = new StreamWriter($"{outputFilePath}\\{CreateFileName()}"))
            {
                writer.WriteLine(game.ToPGNFormat());
            }
        }

        private string CreateFileName()
        {
            var dt = DateTime.Now;
            return $"pgn_parser_{dt.Month}{dt.Day}{dt.Hour}{dt.Minute}{dt.Second}{dt.Millisecond}{dt.Microsecond}{dt.Millisecond}.pgn";
        }
    }
}
