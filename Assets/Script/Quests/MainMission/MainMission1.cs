using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script.Quests.MainMission
{
    public class MainMission1 : MonoBehaviour
    {
        public GameObject messageBox;

        public Text messageText;
        public Text obj;

        public AudioSource line1;
        public AudioSource line2;

        void Start()
        {
            Invoke("FirstMessage", 3);
            Invoke("SecondMessage", 5);
            Invoke("DeactivateMessageBox", 8);
        }

        void FirstMessage()
        {
            line1.Play();
            messageBox.SetActive(true);
            messageText.text = "You: Where am i?";
        }

        void SecondMessage()
        {
            line2.Play();
            messageText.text = "You: I need to get out of this wood.";
        }

        void DeactivateMessageBox()
        {
            obj.text = "Objective: Get out of the woods!";
            messageText.text = "";
            messageBox.SetActive(false);
        }
    }
}
