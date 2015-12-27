#region

using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class Cell : MonoBehaviour
    {
        public float Humidity;

        public void SetParams(float humidityChange)
        {
            Humidity += humidityChange;
            Refresh();
        }

        private void Refresh()
        {
            RefreshVisuals();
        }

        private void RefreshVisuals()
        {
            var mat = gameObject.GetComponent<MeshRenderer>().material;
            if (Humidity >= 0.75f)
            {
                mat.color = Color.blue;
                return;
            }
            if (Humidity >= 0.55f)
            {
                mat.color = Color.green;
                return;
            }
            mat.color = Color.black;
        }
    }
}