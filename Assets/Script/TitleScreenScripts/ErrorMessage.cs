using UnityEngine;

namespace Assets.Script.TitleScreenScripts
{
    public class ErrorMessage : MonoBehaviour
    {
        public GameObject loadErrorMessage;

        void Update()
        {
            Error();
        }

        void Error()
        {
            if (ButtonClick.loadError)
            {
                loadErrorMessage.SetActive(true);
            }
            else
            {
                loadErrorMessage.SetActive(false);
            }
        }
    }
}