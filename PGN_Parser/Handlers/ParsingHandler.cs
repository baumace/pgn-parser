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

        public ParsingHandler()
        {
            _validationHelper = new ValidationHelper();
            _consumer = new FileConsumerService();
            _generator = new FileGeneratorService();
        }

        public bool Handle(string inputFile, string outputDirectory)
        {
            _validationHelper.IsValidInputFile(inputFile);
            _validationHelper.IsValidOutputDirectory(outputDirectory);

            return false;
        }
    }
}
