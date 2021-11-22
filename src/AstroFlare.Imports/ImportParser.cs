namespace AstroFlare.Imports
{
    public class ImportParser 
    {
        private readonly string? inputValue;
        private string? outputValue;

#warning Not yet implemented!
        public ImportParser(string input, ref string outputValue)
        {

        }

        public static string ImportParse(string input) 
        {
            string outputValue = input;
            if (outputValue.Contains('/'))
            {
                int index = input.LastIndexOf("/");
                if (index >= 0)
                    outputValue = input.Substring(0, index-1); // or index + 1 to keep slash
            }
            return outputValue;
        }

        public override string? ToString()
        {
            return outputValue;
        }
    }
}