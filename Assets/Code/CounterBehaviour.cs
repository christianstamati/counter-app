using UnityEngine;
using UnityEngine.Events;

namespace Code
{
    public class CounterBehaviour : MonoBehaviour
    {
        public int count;
        public UnityEvent<string> onCountUpdated;

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
