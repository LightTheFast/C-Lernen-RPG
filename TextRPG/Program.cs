using System;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args){
            // Dein Code startet hier
            int title_input=Title();
            System.Console.WriteLine("Gebe deinen Namen ein:");
            string playerName = Console.ReadLine();
            Console.WriteLine("Willkommen im TextRPG!");
            Console.WriteLine($"Hallo, {playerName}!");

            int startingHealth = 100; // erstelle integer für leben
            Console.WriteLine("Deine Start-Health ist: " + startingHealth);
        
            GreetPlayer(playerName); // ruft methode GreetPlayer auf


        }
        
        static void GreetPlayer(string name){ // eine methode 
            Console.WriteLine($"Willkommen, {name}, in deinem Abenteuer");
        
        }

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

    class Character{ // ohne () 
        public string this.Name {get;set;} // get und set statt __init__
        public int this.Health {get;set;}
        public int this.AttackPower {get;set;}

        public void CharacterDescription(){ // public wenn auf werte zugegriffen werden muss
            Console.WriteLine($"Name: {Name}\n Health: {Health}\n Attack: {AttackPower}")
        }   
    }

    class Player : Character{
        
        //public int this.beispiel {get;set;} = 1; beispiel für eine neue property

        public Player (string name) : base(name, 100, 20){ //weiss nicht warum ich public player brauche
        // oder was ich hier hin mache wenn ich keine weiteren initialisierungen habe
        }

        //public void Beispiel(){
            //falls ich noch eine neue methode brauche
        //}
    }

    class Enemy : Character{
        
        //public int this.beispiel {get;set;} = 1; beispiel für eine neue property

        public Enemy (string name) : base(name, 50, 5){ //weiss nicht warum ich public player brauche
        // oder was ich hier hin mache wenn ich keine weiteren initialisierungen habe
        }

        //public void Beispiel(){
            //falls ich noch eine neue methode brauche
        //}
    }
}