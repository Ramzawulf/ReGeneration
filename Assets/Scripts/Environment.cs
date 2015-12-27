#region

using UnityEngine;

#endregion

namespace Assets.Scripts
{
    internal class Environment : MonoBehaviour
    {
        public static Environment Ctrl;

        public float Temperature;
        public float Humidity;

        public void Awake()
        {
            if (Ctrl == null)
                Ctrl = this;
            else if (Ctrl != this)
                Destroy(this);
        }

        
    }
}