using UnityEngine;

namespace Assets.Script
{
    public class enemy : MonoBehaviour
    {
        public float health = 50;

        void OnCollisionEnter(Collision obj)
        {
            if (obj.collider.tag == "Weapon" && attack.attacked)
            {
                health -= 1;
            }

            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
