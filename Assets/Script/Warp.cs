using UnityEngine;

namespace Assets.Script
{
    public class Warp : MonoBehaviour
    {
        public Transform location1;
        public Transform location2;
        Vector3 value;

        void OnTriggerEnter(Collider obj)
        {
            value.z = 2f;

            if (obj.gameObject.tag == "Warp1")
            {
                this.transform.position = location1.position + value;
            }
            if (obj.gameObject.tag == "Warp2")
            {
                this.transform.position = location2.position - value;
            }
        }
    }
}
