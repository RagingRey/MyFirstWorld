using System.Collections;
using UnityEngine;

namespace Assets.Script
{
    public class randomizingScripts : MonoBehaviour
    {
        public GameObject obj1;
        public GameObject obj2;
        public GameObject obj3;
        int number;
        public bool randomize = true;

        void Update()
        {
            if (randomize)
            {
                randomize = false;
                StartCoroutine(Randomize());
            }
        }

        IEnumerator Randomize()
        {
            number = Random.Range(1, 4);

            if (number == 1)
            {
                obj1.SetActive(true);
                obj2.SetActive(false);
                obj3.SetActive(false);
            }
            else if (number == 2)
            {
                obj2.SetActive(true);
                obj1.SetActive(false);
                obj3.SetActive(false);
            }
            else if (number == 3)
            {
                obj3.SetActive(true);
                obj2.SetActive(false);
                obj1.SetActive(false);
            }

            yield return new WaitForSeconds(3);
            randomize = true;
        }
    }
}
