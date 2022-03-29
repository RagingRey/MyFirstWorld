using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script.Quests
{
    public class WillQuestActive : MonoBehaviour
    {
        public int textBoxOnCheck = 0;

        public GameObject messageBox;
        public GameObject questItemToClose;
        public GameObject questItemToShow;

        public Text messageText;
        public Text questText;

        void OnMouseDown()
        {
            if (textBoxOnCheck == 0)
            {
                textBoxOnCheck = 1;
                messageBox.SetActive(true);
                messageText.text = "You found the loot.";
                questText.text = "Objective: Return the bag to Will.";
                Invoke("Continue", 3);
            }
        
        }

        void Continue()
        {
            gameObject.SetActive(false);
            messageBox.SetActive(false);
            questItemToClose.SetActive(false);
            questItemToShow.SetActive(true);
        }
    }
}
