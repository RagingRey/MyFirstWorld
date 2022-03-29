using UnityEngine;

namespace Assets.Script
{
    public class theFollowCamera : MonoBehaviour
    {
        public Transform player;
        Vector3 offset;
        Vector3 value;
        public float damping = 1;

        void Start()
        {
            offset = transform.position - player.position;
        }

        void LateUpdate()
        {
            value.y = 2f;
            value.z = 2f;
            float currentAngle = transform.eulerAngles.y;
            float desiredAngle = player.eulerAngles.y;
            float angle = Mathf.LerpAngle(currentAngle, desiredAngle, Time.deltaTime * damping);

            Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);

            transform.position = player.position - (rotation * offset);

            transform.LookAt(player.position + value);
        }
    }
}
