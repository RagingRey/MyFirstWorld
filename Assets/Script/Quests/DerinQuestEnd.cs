using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script.Quests
{
    public class DerinQuestEnd : MonoBehaviour
    {
        public bool textBoxOnCheck = false;

        public Text messageText;
        public Text objText;

        public GameObject inventoryGold;
        public GameObject messageBox;

        void OnMouseDown()
        {
            if (textBoxOnCheck == false)
            {
                textBoxOnCheck = true;
                messageBox.SetActive(true);
                messageText.text = "Derin: Thank you very much";
                objText.text = "Objective: none";
                inventoryGold.SetActive(false);
            }
            else
            {
                Invoke("DisableMessages", 0);
            }
        }

        void Update()
        {
            if (Input.GetButtonDown("Submit"))
            {
                if (textBoxOnCheck)
                {
                    Invoke("DisableMessages", 0);
                }
            }
            else if (Input.GetButtonDown("Cancel"))
            {
                if (textBoxOnCheck)
                {
                    Invoke("DisableMessages", 0);
                }
            }
        }

        void DisableMessages()
        {
            textBoxOnCheck = false;
            messageBox.SetActive(false);
            messageText.text = "";
        }
    }
}
