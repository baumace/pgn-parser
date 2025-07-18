using System.Xml.Schema;
using PgnParser.DataModels.Interfaces;

namespace PgnParser.DataModels.Models
{
    public class Game : IGame
    {
        private string _tags {  get; }
        private string _moves { get; }

        public Game(string tags, string moves)
        {
            _tags = tags;
            _moves = moves;
        }

        public string ToPgnFormat()
        {
            return $"{_tags}{Environment.NewLine}{Environment.NewLine}{_moves}{Environment.NewLine}{Environment.NewLine}";
        }
    }
}
