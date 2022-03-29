using UnityEngine;

namespace Assets.Script
{
    public class FadeScreen : MonoBehaviour
    {
        public GameObject fadeScreen;

        void Start()
        {
            Invoke("EnableFadeScreen", 0);
        }

        void Update()
        {
            Invoke("DisableFadeScreen", 2);
        }

        void DisableFadeScreen()
        {
            fadeScreen.SetActive(false);
        }

        void EnableFadeScreen()
        {
            fadeScreen.SetActive(true);
        }
    }
}
