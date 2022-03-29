using System.Collections;
using UnityEngine;

namespace Assets.Script
{
    public class TownCutscene : MonoBehaviour
    {
        public GameObject firstCutSceneCamera;
        public GameObject secondCutSceneCamera;
        public GameObject thePlayer;
        public GameObject ui;

        void OnTriggerEnter()
        {
            StartCoroutine(Process());
        }

        IEnumerator Process()
        {
            thePlayer.SetActive(false);
            ui.SetActive(false);
            firstCutSceneCamera.SetActive(true);
            yield return new WaitForSeconds(4.5f);
            firstCutSceneCamera.SetActive(false);
            secondCutSceneCamera.SetActive(true);
            yield return new WaitForSeconds(4.5f);
            secondCutSceneCamera.SetActive(false);
            thePlayer.SetActive(true);
            ui.SetActive(true);
            Destroy(gameObject);
        }
    }
}
