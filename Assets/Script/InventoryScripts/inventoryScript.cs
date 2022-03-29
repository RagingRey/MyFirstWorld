using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

namespace Assets.Script.InventoryScripts
{
    public class inventoryScript : MonoBehaviour
    {
        public bool inventoryActive = false;
        public GameObject inventory;
        public GameObject thePlayer;
        public GameObject map;

        void Update()
        {
            if (Input.GetKey(KeyCode.I) && inventoryActive == false)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                inventory.SetActive(true);
                inventoryActive = true;
                thePlayer.GetComponent<RigidbodyFirstPersonController>().enabled = false;
                map.SetActive(false);
            }
            else if (Input.GetKey(KeyCode.I) && inventoryActive)
            {
                Cursor.visible = false;
                inventory.SetActive(false);
                inventoryActive = false;
                thePlayer.GetComponent<RigidbodyFirstPersonController>().enabled = true;
                map.SetActive(true);
            }
        }
    }
}
