using PGN_Parser.DataModels.Interfaces;
using PGN_Parser.DataModels.Models;
using System.Text;

namespace PGN_Parser.Services
{
    public class FileConsumerService
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public FileConsumerService()
        {

        }

        /// <summary>
        /// Consumes the PGN input from the input file path.
        /// </summary>
        /// <param name="inputFilePath"></param>
        /// <returns></returns>
        public IGameList Consume(string inputFilePath)
        {
            Console.WriteLine($"Taking input from file: {inputFilePath}");

            IGameList gameList = new GameList();

            using (var reader = new StreamReader(inputFilePath))
            {
                PopulateGameList(gameList, reader);
            }

            return gameList;
        }

        /// <summary>
        /// Populates an IGameList with the games found in the input.
        /// </summary>
        /// <param name="gameList"></param>
        /// <param name="input"></param>
        private void PopulateGameList(IGameList gameList, StreamReader input)
        {
            while (!input.EndOfStream)
            {
                gameList.AddGame(PopulateGame(input));
            }
        }

        /// <summary>
        /// Populates a single game found in the input.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private IGame PopulateGame(StreamReader input)
        {
            string line;

            // tags
            var tags = new StringBuilder();
            do
            {
                line = input.ReadLine();
                tags.Append($"{line}{Environment.NewLine}");
            } while (!line.Equals(""));

            // movetext
            var movetext = new StringBuilder();
            do
            {
                line = input.ReadLine();
                movetext.Append($"{line}{Environment.NewLine}");
            } while (!line.Equals("") && !input.EndOfStream);

            // clean
            while (!input.EndOfStream && input.Peek() != ('['))
            {
                input.Read();
            }

            return new Game(tags.ToString().Trim(), movetext.ToString().Trim());
        }
    }
}
