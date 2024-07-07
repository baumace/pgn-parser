using PGN_Parser.Helpers;
using PGN_Parser.Helpers.Interfaces;
using PGN_Parser.Services;

namespace PGN_Parser.Handlers
{
    public class ParsingHandler
    {
        #region Private Variables
        private IValidationHelper _validationHelper;
        private FileConsumerService _consumer;
        private FileGeneratorService _generator;
        #endregion Private Variables

        /// <summary>
        /// Constructor.
        /// </summary>
        public ParsingHandler()
        {
            _validationHelper = new ValidationHelper();
            _consumer = new FileConsumerService();
            _generator = new FileGeneratorService();
        }

        /// <summary>
        /// Handles parsing process from PGN input file to generated
        /// PGN output files.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputDirectory"></param>
        /// <returns></returns>
        public bool Handle(string inputFile, string outputDirectory)
        {
            _validationHelper.IsValidInputFile(inputFile);
            _validationHelper.IsValidOutputDirectory(outputDirectory);

            var gameList = _consumer.Consume(inputFile);
            Console.WriteLine($"{gameList.GetGames().Count} games discovered...");

            _generator.Generate(gameList, outputDirectory);

            return true;
        }
    }
}
