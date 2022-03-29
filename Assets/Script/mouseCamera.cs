using UnityEngine;

namespace Assets.Script
{
    public class mouseCamera : MonoBehaviour
    {
        public Transform player;
        Vector3 offset;
        Vector3 value;
        public float rotateSpeed = 1f;

        void Start()
        {
            offset = player.position - transform.position;
        }

        void LateUpdate()
        {
            value.y = 1.5f;

            float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
            player.Rotate(0, horizontal, 0);

            float desiredAngle = player.eulerAngles.y;
            Quaternion rotation = Quaternion.Euler(-7.550f, desiredAngle, 0);
            transform.position = player.position - (rotation * offset);

            transform.LookAt(player.position + value);
        }
    }
}
