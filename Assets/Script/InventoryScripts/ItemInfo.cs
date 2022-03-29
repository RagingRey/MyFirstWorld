using UnityEngine;

namespace Assets.Script.InventoryScripts
{
    public class ItemInfo : MonoBehaviour
    {
        public GameObject itemInfo;

        public void ToggleItemInfo()
        {
            itemInfo.SetActive(true);
        }
    }
}