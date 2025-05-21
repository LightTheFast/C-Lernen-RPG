using TextRPG.Klassen;
namespace TextRPG.Inventory;

    public interface IItem
    {
        string Name { get; }
        void Use(Player player);
    }
    
