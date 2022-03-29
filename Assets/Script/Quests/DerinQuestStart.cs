using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script.Quests
{
    public class DerinQuestStart : MonoBehaviour
    {
        public bool textBoxOnCheck = false;
        public static bool withKey = false;

        public GameObject messageBox;
        public GameObject Key;
        public GameObject willQuests;

        public Text messageText;
        public Text questText;

        void OnMouseDown()
        {
            if (textBoxOnCheck == false)
            {
                willQuests.SetActive(false);
                textBoxOnCheck = true;
                messageBox.SetActive(true);
                messageText.text = "Derin : Hey, i want you to retrieve a Gold bullion from the cave down the path, Here is the key.";
                questText.text = "Objective: Retrieve the bullion";
                Key.SetActive(true);
                withKey = true;
            }
            else
            {
                textBoxOnCheck = false;
                messageBox.SetActive(false);
            }
        }

        void Update()
        {
            if (Input.GetButtonDown("Submit"))
            {
                if (textBoxOnCheck)
                {
                    Invoke("ContinueMessage", 0);
                }
            }

            if (Input.GetButtonDown("Cancel"))
            {
                if (textBoxOnCheck)
                {
                    Invoke("ContinueMessage", 0);
                }
            }
        }

        void ContinueMessage()
        {
            textBoxOnCheck = false;
            messageBox.SetActive(false);
        }
    }
}
