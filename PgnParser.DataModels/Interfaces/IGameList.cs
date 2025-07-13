namespace PgnParser.DataModels.Interfaces
{
    public interface IGameList
    {
        /// <summary>
        /// Adds a new game to the collection.
        /// </summary>
        /// <param name="game"></param>
        public void AddGame(IGame game);

        /// <summary>
        /// Gets all games from the collection.
        /// </summary>
        /// <param name="game"></param>
        public List<IGame> GetGames();
    }
}
