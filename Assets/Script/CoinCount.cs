using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script
{
    public class CoinCount : MonoBehaviour
    {
        public static int count = 40;
        public Text coins;

        void Update()
        {
            coins.text = "Coins: " + count;
        }
    }
}
