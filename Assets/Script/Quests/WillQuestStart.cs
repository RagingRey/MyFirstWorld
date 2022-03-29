using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script.Quests
{
    public class WillQuestStart : MonoBehaviour
    {
        public int textBoxOnCheck = 0;

        public GameObject messageBox;
        public Text messageText;
        public Text questText;

        public string firstMessage = "Villager: Hello, some bandits have stolen my money. Could you help me recover it on the other side of the river?";

        public GameObject questItemToOpen;

        void OnMouseDown()
        {
            if (textBoxOnCheck == 0)
            {
                questItemToOpen.SetActive(true);
                textBoxOnCheck = 1;
                messageBox.SetActive(true);
                messageText.text = firstMessage;
                questText.text = "Objective: Recover The Loot!";
            }

            else
            {
                Invoke("ContinueMessage", 0);
            }
        }

        void Update()
        {
            if (Input.GetButtonDown("Submit"))
            {
                if (textBoxOnCheck == 1)
                {
                    Invoke("ContinueMessage", 0);
                }
            }

            if (Input.GetButtonDown("Cancel"))
            {
                if (textBoxOnCheck == 1)
                {
                    Invoke("ContinueMessage", 0);
                }
            }
        }

        void ContinueMessage()
        {
            textBoxOnCheck = 0;
            messageBox.SetActive(false);
        }
    }
}