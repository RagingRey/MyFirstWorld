using UnityEngine;

namespace Assets.Script.TitleScreenScripts
{
    public class TitleRotate : MonoBehaviour
    {
        void Update()
        {
            transform.Rotate(0, 0.2f, 0, Space.World);
        }
    }
}
