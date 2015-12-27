#region

using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class PrefabRepository : MonoBehaviour
    {
        public static PrefabRepository Ctrl;
        public GameObject CellPrefab;

        public void Awake()
        {
            if (Ctrl == null)
                Ctrl = this;
            else if (Ctrl != this)
                Destroy(this);
        }
    }
}