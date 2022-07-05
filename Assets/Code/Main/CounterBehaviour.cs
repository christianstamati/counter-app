using UnityEngine;
using UnityEngine.Events;

namespace CounterApp.Main
{
    public class CounterBehaviour : MonoBehaviour
    {
        public int count;
        public UnityEvent<string> onCountUpdated = new ();

        private void Start()
        {
            onCountUpdated?.Invoke(count.ToString());
        }

        public void OnAdd()
        {
            count++;
            onCountUpdated?.Invoke(count.ToString());
        }
    }
}
