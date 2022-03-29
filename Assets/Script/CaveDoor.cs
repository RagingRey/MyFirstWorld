using Assets.Script.Quests;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script
{
    public class CaveDoor : MonoBehaviour
    {
        public GameObject door;
        public GameObject theKey;
        public AudioSource creakySound;
        public AudioSource unlockSound;
        public Text actionText;

        void OnMouseDown()
        {
            if (DerinQuestStart.withKey == false)
            {
                Invoke("DoorStatusOn", 0);
                Invoke("DoorStatusOff", 2);
            }
            else
            {
                theKey.SetActive(false);
                unlockSound.Play();
                Invoke("PlayCreakySound", 1);
                Invoke("DoorAnimation", 0.5f);
                Invoke("DoorAnimationStop", 2.3f);
            }
        }

        void DoorStatusOn()
        {
            actionText.text = "You do not have the key to this door!";
        }

        void DoorStatusOff()
        {
            actionText.text = "";
        }

        void DoorAnimation()
        {
            door.GetComponent<Animator>().enabled = true;
        }
        
        void DoorAnimationStop()
        {
            door.GetComponent<Animator>().enabled = false;
        }

        void PlayCreakySound()
        {
            creakySound.Play();
        }
    }
}
