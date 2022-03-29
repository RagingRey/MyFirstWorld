using UnityEngine;

namespace Assets.Script.Shop
{
    public class GlobalShop : MonoBehaviour
    {
        public static string item1;
        public static string item2;
        public static string item3;
        public static string item4;
        public static int price1;
        public static int price2;
        public static int price3;
        public static int price4;

        public static int shopNumber;

        void Update()
        {
            if (shopNumber == 1)
            {
                item1 = "Wood block";
                price1 = 10;
                item2 = "Black feather";
                price2 = 10;
                item3 = "Red portion";
                price3 = 15;
                item4 = "Blue portion";
                price4 = 20;
            }
            else if (shopNumber == 2)
            {
                item1 = "Iron block";
                price1 = 25;
                item2 = "Black feather";
                price2 = 12;
                item3 = "Red portion";
                price3 = 13;
                item4 = "";
            }
        }
    }
}
