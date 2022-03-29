using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script
{
    public class axePickUp : MonoBehaviour
    {
        public GameObject inventoryAxe;
        public Text actionText;

        void OnMouseOver()
        {
            actionText.text = "Take Axe";
        }

        void OnMouseExit()
        { 
            actionText.text = "";
        }

        void OnMouseDown()
        {
            actionText.text = "";
            this.gameObject.SetActive(false); 
            inventoryAxe.SetActive(true);
        }
    }
}
