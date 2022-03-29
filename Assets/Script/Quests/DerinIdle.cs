using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script.Quests
{
    public class DerinIdle : MonoBehaviour
    {
        public int textBoxOnCheck = 0;

        public GameObject messageBox;

        public Text messageText;

        void OnMouseDown()
        {
            if (textBoxOnCheck == 0)
            {
                textBoxOnCheck = 1;
                messageBox.SetActive(true);
                messageText.text = "Derin: Leave me alone!";
            }

            else
            {
                textBoxOnCheck = 0;
                messageBox.SetActive(false);
            }
        }
    }
}
