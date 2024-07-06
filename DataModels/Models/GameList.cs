using PGN_Parser.DataModels.Interfaces;

namespace PGN_Parser.DataModels.Models
{
    public class GameList : IGameList
    {
        #region Private Variables
        private List<IGame> _games;
        #endregion Private Variables

        public GameList()
        {
            _games = new List<IGame>();
        }

        public void AddGame(IGame game)
        {
            _games.Add(game);
        }

        public List<IGame> GetGames()
        {
            return _games;
        }
    }
}
