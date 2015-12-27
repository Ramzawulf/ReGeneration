#region

using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class Terrain : MonoBehaviour
    {
        public static Terrain Ctrl;
        private Cell[,] _cells;
        public int Height;
        public bool NeedUpdate;
        public int Width;

        public void Awake()
        {
            if (Ctrl == null)
                Ctrl = this;
            else if (Ctrl != this)
                Destroy(this);
        }

        public void Start()
        {
            Init();
        }

        private void Init()
        {
            _cells = new Cell[Height, Width];
            for (var h = 0; h < Height; h++)
            {
                for (var w = 0; w < Width; w++)
                {
                    var pos = new Vector3
                    {
                        x = Height/2 - h,
                        y = 0,
                        z = Width/2 - w
                    };
                    var gameObj = Instantiate(PrefabRepository.Ctrl.CellPrefab, pos, Quaternion.identity)
                        as GameObject;
                    if (gameObj != null)
                    {
                        gameObj.transform.SetParent(transform);
                        gameObj.name = h + "," + w;
                        _cells[h, w] = gameObj.GetComponent<Cell>();
                        _cells[h, w].SetParams(Random.value);
                    }
                }
            }
        }

        private void Refresh()
        {
        }

        // Update is called once per frame
        public void Update()
        {
            if (NeedUpdate)
            {
                Refresh();
            }
        }
    }
}