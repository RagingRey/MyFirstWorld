namespace Assets.Script.TitleScreenScripts
{
    [System.Serializable]
    public class Game
    {
        public static Game current;
        public Character daniel;
        public Character david;
        public Character desmond;

        public Game()
        {
            daniel = new Character();
            david = new Character();
            desmond = new Character();
        }
    }
}
