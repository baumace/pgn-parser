using System.Text;
using Microsoft.Extensions.Logging;
using PgnParser.DataModels.Interfaces;
using PgnParser.DataModels.Models;

namespace PgnParser.Services
{
    public class Parser
    {
        private readonly ILogger _logger;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Parser(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Handles parsing process from PGN input file to generated
        /// PGN output files.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<IGame> Parse(List<string> input)
        {
            var games = new List<IGame>();

            var i = 0;

            while (i < input.Count)
            {
                // build tags
                var tags = new StringBuilder();
                while (i < input.Count && input[i].StartsWith("["))
                {
                    tags.Append($"{Environment.NewLine}{input[i]}");
                    i++;
                }
                
                // build moves
                var moves = new StringBuilder();
                while (i < input.Count && !input[i].StartsWith("["))
                {
                    moves.Append(input[i]);
                    i++;
                }
                
                games.Add(new Game(tags.ToString(), moves.ToString()));

                i++;
            }
            
            return games;
        }
    }
}
