namespace PGN_Parser.DataModels.Interfaces
{
    public interface IGame
    {
        /// <summary> 
        /// Compiles the information of this
        /// int PGN format.
        /// </summary>
        /// <returns></returns>
        public string ToPGNFormat();
    }
}
