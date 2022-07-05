using UnityEngine;

namespace Code.Counter
{
    public class PlayerPrefsSaver : ISaver
    {
        public string Get(string key)
        {
            return PlayerPrefs.GetString(key);
        }

        public void Save(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
            PlayerPrefs.Save();
        }
    }
}