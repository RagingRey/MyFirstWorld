using UnityEngine;

namespace Assets.Script
{
    public class dungeonCameraFollow : MonoBehaviour
    {
        public Transform player;
        Vector3 offset;
        Vector3 value;
        public float damping = 1f;

        void Start()
        {
            offset = transform.position - player.position;
        }

        void LateUpdate()
        {
            value.y = 1.2f;

            Vector3 desiredPosition = player.position + offset + value;
            Vector3 position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
            transform.position = position;

            transform.LookAt(player.position);
        }
    }
}
