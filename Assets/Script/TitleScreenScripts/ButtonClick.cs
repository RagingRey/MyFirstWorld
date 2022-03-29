using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Script.TitleScreenScripts
{
    public class ButtonClick : MonoBehaviour
    {
        public GameObject mainPage;
        public GameObject savedGamePage;

        public Text save1;
        public Text save2;
        public Text save3;

        public static bool loadError = false;

        public void NewGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void QuitGame()
        {
            Application.Quit();
        }

        public void LoadGame()
        {
            mainPage.SetActive(false);
            savedGamePage.SetActive(true);

            Invoke("AvailableGames", 0);
        }

        public void OnBackClick()
        {
            mainPage.SetActive(true);
            savedGamePage.SetActive(false);
            loadError = false;
        }

        void Start()
        {
            StreamReader ourfile = new StreamReader(fileName);

            string line = ourfile.ReadLine();
            while (line != null)
            {
                loadCode = line;
                line = ourfile.ReadLine();
            }

            ourfile.Close();
        }

        public string loadCode;
        public string fileName = "savegame.data";
        public static string globalCode;


        public void Game1()
        {
            globalCode = loadCode;

            if (globalCode == "savingthegame")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                loadError = true;
            }
        }

        void AvailableGames()
        {
            DirectoryInfo files = new DirectoryInfo(@"C:\New folder");
            FileInfo[] allFiles = files.GetFiles();

            if (allFiles.Length == 1)
            {
                save1.text = allFiles[0].Name;
            }
            if (allFiles.Length == 2)
            {
                save1.text = allFiles[0].Name;
                save2.text = allFiles[1].Name;
            }
            if (allFiles.Length == 3)
            {
                save1.text = allFiles[0].Name;
                save2.text = allFiles[1].Name;
                save3.text = allFiles[2].Name;
            }
        }

        public void Game2()
        {
            DirectoryInfo files = new DirectoryInfo(@"C:\New folder");
            FileInfo[] allFiles = files.GetFiles();

            if (save2.text != "No Save Data...")
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(allFiles[1].Name, FileMode.Open);
                Save.savedGames = (List<Game>)bf.Deserialize(file);
                file.Close();
            }
        }

        public void Game3()
        {
            DirectoryInfo files = new DirectoryInfo(@"C:\New folder");
            FileInfo[] allFiles = files.GetFiles();

            if (save3.text == "No Save Data...")
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(allFiles[2].Name, FileMode.Open);
                Save.savedGames = (List<Game>)bf.Deserialize(file);
                file.Close();
            }
        }

        public void Facebook()
        {
            Application.OpenURL("www.facebook.com");
        }
    }
}