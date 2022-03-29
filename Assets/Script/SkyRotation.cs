using UnityEngine;

namespace Assets.Script
{
    public class SkyRotation : MonoBehaviour
    {
        public float rotateSpeed = 1f;

        void Update()
        {
            RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);
        }
    }
}
