using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script.Quests
{
    public class WillQuestEnd : MonoBehaviour
    {
        public int textBoxOnCheck = 0;

        public GameObject messageBox;
        public GameObject derinIdle;
        public GameObject derinQuestStart;

        public Text messageText;
        public Text questText;

        void OnMouseDown()
        {
            if (textBoxOnCheck == 0)
            {
                textBoxOnCheck = 1;
                messageBox.SetActive(true);
                messageText.text = "Villager: Thank you, Speak to Derin behind the house for more.";
                questText.text = "Objective: Go to Derin";
                derinIdle.SetActive(false);
                derinQuestStart.SetActive(true);
            }

            else
            {
                textBoxOnCheck = 0;
                messageBox.SetActive(false);
            }
        }
    }
}
