using UnityEngine;

namespace Assets.Script
{
    public class attack : MonoBehaviour
    {
        public static bool attacked = false;

        void Update()
        {
            //you can press p or use left mouse button to attack
            if (Input.GetKey(KeyCode.LeftControl) || Input.GetButton("Attack"))
            {
                GetComponent<Animation>().Play("AttackAnimation");
                attacked = true;
            }
        }
    }
}
