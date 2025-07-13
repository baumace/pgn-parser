using System.Xml.Schema;
using PgnParser.DataModels.Interfaces;

namespace PgnParser.DataModels.Models
{
    public class Game : IGame
    {
        #region Private Variables
        private string _tagPairs {  get; set; }
        private string _movetext { get; set; }
        #endregion Private Variables

        public Game(string tagPairs, string movetext)
        {
            _tagPairs = tagPairs;
            _movetext = movetext;
        }

        public string ToPGNFormat()
        {
            return $"{_tagPairs}{Environment.NewLine}{Environment.NewLine}{_movetext}{Environment.NewLine}{Environment.NewLine}";
        }
    }
}
