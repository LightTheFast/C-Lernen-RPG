using TextRPG.Klassen;
namespace TextRPG.Inventory;

public class Potion : IItem{
    public string Name => "Heiltrank";
    public void Use (Player player){
        player.Health += 50;
        System.Console.WriteLine($"{player.Name} trinkt eine Potion und stellt 50 HP wieder her.");
    }
}