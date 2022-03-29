using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Assets.Script.TitleScreenScripts;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

namespace Assets.Script
{
    public class Save : MonoBehaviour
    {
        public static List<Game> savedGames = new List<Game>();
        public GameObject saveGamePanel;
        public GameObject emptyText;
        public GameObject maximumSaveFiles;
        public InputField gameSaveName;

        public GameObject thePlayer;

        void OnTriggerEnter()
        {
            saveGamePanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            thePlayer.GetComponent<RigidbodyFirstPersonController>().enabled = false;
        }

        public void OnSaveClick()
        {
            int count;
            DirectoryInfo files = new DirectoryInfo(@"C:\New folder");
            count = files.GetFiles().Length;

            if (String.IsNullOrWhiteSpace(gameSaveName.text))
            {
                emptyText.SetActive(true);
                Invoke("DeactivateEmptyTextBox", 3);
            }
            if (count > 2)
            {
                maximumSaveFiles.SetActive(true);
                Invoke("DeactivateMaximumSaveFiles", 3);
            }
            else
            {
                savedGames.Add(Game.current);
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Create(@"C:\New folder" + ("/" +gameSaveName.text +".gd"));
                bf.Serialize(file, Save.savedGames);
                file.Close();
            }
        }

        public void OnExitClick()
        {
            saveGamePanel.SetActive(false);
            Cursor.visible = false;
            thePlayer.GetComponent<RigidbodyFirstPersonController>().enabled = true;
        }

        public void DeactivateEmptyTextBox()
        {
            emptyText.SetActive(false);
        }

        public void DeactivateMaximumSaveFiles()
        {
            maximumSaveFiles.SetActive(false);
        }
    }
}
