namespace CSharp
{
    public class HTTPCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HTTPCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key] 
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}