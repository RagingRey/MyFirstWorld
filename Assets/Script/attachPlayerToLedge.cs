using UnityEngine;

namespace Assets.Script
{
    public class attachPlayerToLedge : MonoBehaviour
    {
        public GameObject thePlayer;

        void OnTriggerEnter()
        {
            thePlayer.transform.parent = this.transform;
        }

        void OnTriggerExit()
        {
            thePlayer.transform.parent = null;
        }
    }
}
