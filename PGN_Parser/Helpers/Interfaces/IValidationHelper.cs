namespace PGN_Parser.Helpers.Interfaces
{
    public interface IValidationHelper
    {
        /// <summary>
        /// Validates the input file.
        /// </summary>
        /// <returns></returns>
        public bool IsValidInputFile(string file);

        /// <summary>
        /// Validates the output directory.
        /// </summary>
        /// <returns></returns>
        public bool IsValidOutputDirectory(string directory);
    }
}
