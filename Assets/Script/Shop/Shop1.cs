using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

namespace Assets.Script.Shop
{
    public class Shop1 : MonoBehaviour
    {
        public GameObject shopInventory;
        public GameObject thePlayer;

        public Text item1Text;
        public Text item2Text;
        public Text item3Text;
        public Text item4Text;
        public Text item1Price;
        public Text item2Price;
        public Text item3Price;
        public Text item4Price;

        public GameObject confirmItem;
        public Text confirmText;

        public int itemNumber;
        public GameObject notEnoughMoney;

        void Update()
        {
            GlobalShop.shopNumber = 1;
        }

        void OnMouseDown()
        {
            shopInventory.SetActive(true);
            thePlayer.GetComponent<RigidbodyFirstPersonController>().enabled = false;

            item1Text.text = "" + GlobalShop.item1;
            item1Price.text = "Price: " + GlobalShop.price1;
            item2Text.text = "" + GlobalShop.item2;
            item2Price.text = "Price: " + GlobalShop.price2;
            item3Text.text = "" + GlobalShop.item3;
            item3Price.text = "Price: " + GlobalShop.price3;
            item4Text.text = "" + GlobalShop.item4;
            item4Price.text = "Price: " + GlobalShop.price4;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        public void Item1()
        {
            confirmItem.SetActive(true);
            confirmText.text = "Are you sure you want to buy " + GlobalShop.item1 + "?";
            itemNumber = 1;
        }

        public void Item2()
        {
            confirmItem.SetActive(true);
            confirmText.text = "Are you sure you want to buy " + GlobalShop.item2 + "?";
            itemNumber = 2;
        }

        public void Item3()
        {
            confirmItem.SetActive(true);
            confirmText.text = "Are you sure you want to buy " + GlobalShop.item3 + "?";
            itemNumber = 3;
        }

        public void Item4()
        {
            confirmItem.SetActive(true);
            confirmText.text = "Are you sure you want to buy " + GlobalShop.item4 + "?";
            itemNumber = 4;
        }

        public void Cancel()
        {
            confirmItem.SetActive(false);
            itemNumber = 0;
        }

        public void Exit()
        {
            thePlayer.GetComponent<RigidbodyFirstPersonController>().enabled = true;
            shopInventory.SetActive(false);
            Cursor.visible = false;
            confirmItem.SetActive(false);
        }

        public void Purchase()
        {
            if (itemNumber == 1)
            {
                if (CoinCount.count >= GlobalShop.price1)
                {
                    CoinCount.count -= GlobalShop.price1;
                    confirmItem.SetActive(false);
                }
                else
                {
                    notEnoughMoney.SetActive(true);
                    Invoke("DisableNotEnoughMoney", 3f);
                }
            }

            if (itemNumber == 2)
            {
                if (CoinCount.count >= GlobalShop.price2)
                {
                    CoinCount.count -= GlobalShop.price2;
                    confirmItem.SetActive(false);
                }
                else
                {
                    notEnoughMoney.SetActive(true);
                    Invoke("DisableNotEnoughMoney", 3f);
                }
            }

            if (itemNumber == 3)
            {
                if (CoinCount.count >= GlobalShop.price3)
                {
                    CoinCount.count -= GlobalShop.price3;
                    confirmItem.SetActive(false);
                }
                else
                {
                    notEnoughMoney.SetActive(true);
                    Invoke("DisableNotEnoughMoney", 3f);
                }
            }

            if (itemNumber == 4)
            {
                if (CoinCount.count >= GlobalShop.price4)
                {
                    CoinCount.count -= GlobalShop.price4;
                    confirmItem.SetActive(false);
                }
                else
                {
                    notEnoughMoney.SetActive(true);
                    Invoke("DisableNotEnoughMoney", 3f);
                }
            }
        }

        public void DisableNotEnoughMoney()
        {
            notEnoughMoney.SetActive(false);
        }
    }
}
