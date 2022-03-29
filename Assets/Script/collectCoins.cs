using UnityEngine;

namespace Assets.Script
{
    public class collectCoins : MonoBehaviour
    {
        void OnTriggerEnter(Collider player)
        {
            AudioSource coinAudio = GetComponent<AudioSource>();

            if (player.tag == "Player")
            {
                coinAudio.Play();
                CoinCount.count++;
                transform.position = new Vector3(0, 100000, 0);
                Invoke("Destroy", 1);
            }
        }

        void Destroy()
        {
            Destroy(gameObject);
        }
    }
}
