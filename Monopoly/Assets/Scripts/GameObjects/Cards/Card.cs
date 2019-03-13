namespace GameObjects.Cards{
    public abstract class Card {
        public int Type { get; set; } // type 3 is get out of jail. Type 4 is go to jail
        public abstract int Activate(int[] values); //This is for things that change your money based on parameters. type 2
        public abstract int Activate(); //these move you. type 0
        public abstract int Activate(int money); // change your money based on set amount. type 1
    }
}