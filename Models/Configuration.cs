namespace JobBoard.Models
{
    public class Configuration : BaseJobObject
    {
        public string Value { get; set; }

        public Configuration()
        {
        }

        public Configuration(string id, string val)
        {
            Id = id;
            Value = val;
        }
    }
}