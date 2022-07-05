namespace Code.Counter
{
    public interface ISaver
    {
        public string Get(string key);
        public void Save(string key, string value);
    }
}