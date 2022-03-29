using UnityEngine;

namespace Assets.Script
{
    public class coinSpin : MonoBehaviour
    {
        void Update()
        {
            transform.Rotate(0, 4, 0, Space.World);
        }
    }
}
