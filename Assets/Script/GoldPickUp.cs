using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script
{
    public class GoldPickUp : MonoBehaviour
    {
        public GameObject inventoryGold;
        public GameObject derinQuestStart;
        public GameObject derinQuestEnd;
        public Text actionText;
        public Text objText;

        void OnMouseOver()
        {
            actionText.text = "Take Gold";
        }

        void OnMouseExit()
        {
            actionText.text = "";
        }

        void OnMouseDown()
        {
            this.gameObject.SetActive(false);
            inventoryGold.SetActive(true);
            actionText.text = "";
            objText.text = "Objective: Return the gold to Derin";
            derinQuestStart.SetActive(false);
            derinQuestEnd.SetActive(true);
        }
    }
}
