using System;
using TextRPG.Klassen;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args){
            // Dein Code startet hier
            int title_input=Title();
            //System.Console.WriteLine("Gebe deinen Namen ein:");
            //string playerName = Console.ReadLine();
            Console.WriteLine("Willkommen im TextRPG!");
            //Console.WriteLine($"Hallo, {playerName}!");
            var player = new Player("Light");
            var enemy = new Slime();
            player.CharacterDescription();
            enemy.CharacterDescription();
            Combat(player, enemy);


            static void Combat(Character player, Character enemy){
                while(true){
                    bool enemyDead = Attack(player, enemy);
                    System.Threading.Thread.Sleep(1000); // 1 Sekunde
                    if (enemyDead){
                        if (enemy is Enemy e && e.DropItem != null && player is Player p){
                            p.Inventory.Add(e.DropItem);
                            Console.WriteLine($"{p.Name} erhält {e.DropItem.Name}!");
                        }
                        break;
                    }
                    bool playerDead = Attack(enemy, player);
                    System.Threading.Thread.Sleep(1000); // 1 Sekunde
                    if (playerDead){
                        break;
                    }
                }
                if (enemy.Health <= 0)
                    Console.WriteLine("Gewonnen!");
                else
                    Console.WriteLine("Verloren...");
            }

            static bool Attack(Character attacker, Character defender){
                defender.Health -= attacker.AttackPower; // schaden berechnen
                System.Console.WriteLine($"{attacker.Name} greift {defender.Name} an und verursacht {attacker.AttackPower} schaden.\n{defender.Name}'s verbleibende HP: {defender.Health}");
                    if (defender.Health <= 0) {
                        System.Console.WriteLine($"{defender.Name} wurde besiegt!");
                        return true; //verteidiger tot
                    }
                    return false; //verteidiger lebt
            }
            //int startingHealth = 100; // erstelle integer für leben
            //Console.WriteLine("Deine Start-Health ist: " + startingHealth);
            //GreetPlayer(playerName); // ruft methode GreetPlayer auf
        }
        //static void GreetPlayer(string name){ // eine methode 
        //    Console.WriteLine($"Willkommen, {name}, in deinem Abenteuer");
        //}

        static int Title(){ // eine methode mit rückgabe
            Console.WriteLine($"Willkommen in TextRPG!\n(1)Neues Spiel\n(2)Beenden");
            while(true){
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        return int.Parse(input); //Rückgabe als integer
                    case "2":
                        Environment.Exit(0); // beendet das programm
                        break;
                    default: 
                        Console.WriteLine("Ungültige Eingabe");
                        break;
                }
            }
        }
    }
}