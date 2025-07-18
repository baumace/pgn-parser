namespace PgnParser.DataModels.Interfaces
{
    public interface IGame
    {
        /// <summary> 
        /// Compiles the information of this
        /// into PGN format.
        /// </summary>
        /// <returns></returns>
        public string ToPgnFormat();
    }
}
