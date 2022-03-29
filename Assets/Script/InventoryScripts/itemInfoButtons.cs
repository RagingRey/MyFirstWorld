using UnityEngine;

namespace Assets.Script.InventoryScripts
{
    public class itemInfoButtons : MonoBehaviour
    {
        public GameObject realAxe;
        public GameObject equip;
        public GameObject unEquip;

        public void Equip()
        {
            realAxe.SetActive(true);
            unEquip.SetActive(true);
            equip.SetActive(false);
        }

        public void UnEquip()
        {
            realAxe.SetActive(false);
            unEquip.SetActive(false);
            equip.SetActive(true);
        }

        public void Cancel()
        {
            this.gameObject.SetActive(false);
        }
    }
}
