using Assets.Script.TitleScreenScripts;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script.JV
{
    public class JVAreaLoad : MonoBehaviour
    {
        public GameObject thePlayer;
        public GameObject startingScript;
        public GameObject villageBox;

        float playerX = -7;
        float playerY = 6;
        float playerZ = 30;

        Vector3 position;

        public Text obj;

        public string loadedCode;

        void Start()
        {
            position.x = playerX;
            position.y = playerY;
            position.z = playerZ;

            loadedCode = ButtonClick.globalCode;
            if (loadedCode == "savingthegame")
            {
                thePlayer.transform.position = position;
                startingScript.SetActive(false);
                villageBox.SetActive(false);
                obj.text = "Objective: none.";
            }
        }
    }
}
