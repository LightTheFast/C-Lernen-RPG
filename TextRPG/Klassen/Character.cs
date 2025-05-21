using TextRPG.Inventory;
namespace TextRPG.Klassen{
    
    public class Character{ 
        public string Name {get;set;}
        public int Health {get;set;}
        public int AttackPower {get;set;}

        public Character(string name, int health, int attackPower){
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        public void CharacterDescription(){ // public wenn auf werte zugegriffen werden muss
            Console.WriteLine($"Name: {Name}\n Health: {Health}\n Attack: {AttackPower}");
        }   
    }

    public class Player : Character{
        public List<IItem> Inventory {get;set;} = new List<IItem>();
        public void ShowInventory(){
            if (Inventory.Count == 0){
                System.Console.WriteLine("Dein Inventar ist leer.");
                return;
            }
            System.Console.WriteLine("Dein Inventar:");
            for (int i = 0; i < Inventory.Count; i++){
                System.Console.WriteLine($" {i + 1}: {Inventory[i].Name}");
            }
        }
        public Player (string name) : base(name, 100, 20){}
    }
    
    public class Enemy : Character{
        public IItem? DropItem{get;set;}
        public Enemy (string name, int health, int attackPower, IItem? dropItem = null) : base(name, health, attackPower){
            DropItem = dropItem;
        }
    }
}