using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script.Quests.MainMission
{
    public class ExitWoods : MonoBehaviour
    {
        public GameObject messageBox;

        public Text messageText;
        public Text obj;

        public AudioSource line3;

        void OnTriggerEnter(Collider obj)
        {
            Invoke("Message", 0);
            Invoke("Pause", 2);
            Invoke("SecondMessage", 3);
            Invoke("Pause", 6);
            Invoke("Objective", 6);
        }

        void Message()
        {
            messageBox.SetActive(true);
            line3.Play();
            messageText.text = "You: Looks like there is a village over there.";
        }

        void Pause()
        {
            messageBox.SetActive(false);
            messageText.text = "";
        }

        void SecondMessage()
        {
            messageBox.SetActive(true);
            messageText.text = "You: I better head to the village.";
        }

        void Objective()
        {
            obj.text = "Objective: Reach the village.";
            Destroy(gameObject);
        }
    }
}
