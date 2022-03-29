using UnityEngine;

namespace Assets.Script
{
    public class LeverAnimation : MonoBehaviour
    {
        public GameObject lever;
        public AudioSource leaverAudio;
        public GameObject movingLedge;

        void OnMouseDown()
        {
            lever.GetComponent<Animation>().enabled = true;
            leaverAudio.Play();
            movingLedge.GetComponent<Animator>().enabled = true;
            Destroy(gameObject);
        }
    }
}
