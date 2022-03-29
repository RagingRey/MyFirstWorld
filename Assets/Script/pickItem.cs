using UnityEngine;

namespace Assets.Script
{
    public class pickItem : MonoBehaviour
    {
        public Transform player;

        void FixedUpdate()
        {
        
        }

        void OnMouseDown()
        {
            this.transform.position = player.position;
            this.transform.parent = GameObject.Find("RigidBodyFPSController").transform;
            this.transform.parent = GameObject.Find("MainCamera").transform;
        }

        void OnMouseUp()
        {
            this.transform.parent = GameObject.Find("RigidBodyFPSController").transform;
            this.transform.parent = null;
        }
    }
}
