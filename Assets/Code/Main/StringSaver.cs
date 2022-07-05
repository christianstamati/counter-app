namespace Code.Counter
{
    public class StringSaver
    {
        private readonly string _key;
        private readonly ISaver _saver;

        public StringSaver(string key, ISaver saver)
        {
            _key = key;
            _saver = saver;
        }

        public string GetString()
        {
            return _saver.Get(_key);
        }

        public void SetString(string value)
        {
            _saver.Save(_key, value);
        }
    }
}
