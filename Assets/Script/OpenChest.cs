using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script
{
    public class OpenChest : MonoBehaviour
    {
        public GameObject rotationFlex;
        public Text action;
        public Text chestValue;
        bool isOpened = false;

        void OnMouseOver()
        {
            action.text = isOpened == false ? "Open Chest" : "";
        }

        void OnMouseDown()
        {
            if (isOpened == false)
            {
                isOpened = true;
                int value = Random.Range(5, 10);
                rotationFlex.GetComponent<Animation>().Play("OpenChest");
                chestValue.text = "You received " + value + " coins.";
                chestValue.GetComponent<Animation>().Play("RecieveTextAnim");
                CoinCount.count += value;
                Invoke("Clear", 0);
            }
        }

        void OnMouseExit()
        {
            Invoke("Clear", 0);
        }

        void Clear()
        {
            action.text = "";
        }
    }
}
