using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

namespace Assets.Script.QTE
{
    public class FirstQTE : MonoBehaviour
    {
        public GameObject QTESystem;
        public static int i;
        public GameObject thePlayer;

        void OnTriggerEnter()
        {
            QTESystem.gameObject.SetActive(true);
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            thePlayer.GetComponent<RigidbodyFirstPersonController>().enabled = false;
        }


        void Update()
        {
            if (i == 3)
            {
                QTESystem.gameObject.SetActive(false);
                thePlayer.GetComponent<RigidbodyFirstPersonController>().enabled = true;
            }
        }
        
    }
}
