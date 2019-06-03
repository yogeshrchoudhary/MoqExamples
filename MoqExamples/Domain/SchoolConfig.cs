namespace MoqExamples.Domain
{
    public interface ISchoolConfig
    {
        string GetValue(string key);
    }

    internal class ActualImplementationSchoolConfig : ISchoolConfig
    {
        public string GetValue(string key)
        {
            var result = string.Empty;

            switch (key)
            {
                case "One": result = "Un"; break;
                case "Two": result = "Deux"; break;
                case "Three": result = "Trois"; break;
                case "Four": result = "Quatre"; break;
            }

            return result;
        }
    }
}
