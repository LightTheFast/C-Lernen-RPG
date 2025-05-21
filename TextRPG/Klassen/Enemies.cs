using TextRPG.Inventory;
namespace TextRPG.Klassen{
    
    class Slime : Enemy{
        public Slime () : base("Slime", 50, 5, new Potion()){}
    }
}