using UnityEngine;

namespace Assets.Script
{
    public class mainFollowPlayer : MonoBehaviour
    {
        public Transform player;
        Vector3 value;
        Vector3 offset;
        public float rotateSpeed = 3f;

        void Start()
        {
            offset = player.position - transform.position;
        }

        void LateUpdate()
        {
            value.y = 1.5f;

            float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;

            transform.LookAt(player.position + value);
        }
    }
}
