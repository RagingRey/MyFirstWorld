using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

namespace Assets.Script
{
    public class PauseGame : MonoBehaviour
    {
        public GameObject thePlayer;
        public GameObject ui;
        public GameObject pausePanel;

        void Update()
        {
            if (Input.GetButtonDown("Cancel"))
            {
                Time.timeScale = 0;
                pausePanel.SetActive(true);
                thePlayer.GetComponent<RigidbodyFirstPersonController>().enabled = false;
                Cursor.lockState = CursorLockMode.None; 
                Cursor.visible = true;
                ui.SetActive(false);
            }
        }

        public void Resume()
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
            thePlayer.GetComponent<RigidbodyFirstPersonController>().enabled = true;
            Cursor.visible = false;
            ui.SetActive(true);
        }

        public void MainMenu()
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
            thePlayer.GetComponent<RigidbodyFirstPersonController>().enabled = true;
            Cursor.visible = false;
            ui.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
