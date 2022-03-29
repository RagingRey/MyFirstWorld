using System.IO;
using UnityEngine;

namespace Assets.Script.JV
{
    public class JVSaveMethod : MonoBehaviour
    {
        public string fileName = "savegame.data";

        void OnTriggerEnter()
        {
            StreamWriter ourFile = File.CreateText(fileName);
            ourFile.WriteLine("savingthegame");

            ourFile.Close();
        }
    }
}
