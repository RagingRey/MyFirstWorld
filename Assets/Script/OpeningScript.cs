using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Script
{
    public class OpeningScript : MonoBehaviour
    {
        public GameObject rawImageAnim;
        public GameObject textAnim;

        void Update()
        {
            StartCoroutine(Process());
        }

        IEnumerator Process()
        {
            rawImageAnim.GetComponent<Animation>().Play("OpeningFadeInAnim");
            yield return new WaitForSeconds(1);
            textAnim.GetComponent<Animation>().Play("OpeningTextAnim");
            yield return new WaitForSeconds(2);
            textAnim.SetActive(false);
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
