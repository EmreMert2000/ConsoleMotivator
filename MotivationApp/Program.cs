using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Merhaba! Seni biraz motive edelim 😊");

        
        Console.Write("Adınız: ");
        string name = Console.ReadLine();

        Console.Write("Yaşınız: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Hayattaki en büyük hedefiniz nedir?: ");
        string goal = Console.ReadLine();

        Console.WriteLine("\n📢 İşte motivasyon mesajınız:");
        DisplayMotivation(name, age, goal);
    }

    
    static void DisplayMotivation(string name, int age, string goal)
    {
        string[] messages =
        {
            "Başarı, pes etmeyenlerindir!",
            "Bugün küçük bir adım at, yarın büyük farklar yarat!",
            "Hayallerine ulaşmak için her gün biraz daha ilerle!",
            "Her büyük başarı, bir zamanlar imkânsız gibi görünüyordu!",
            "Kendine inan, çünkü yapabilirsin!"
        };

        Random rnd = new Random();
        int index = rnd.Next(messages.Length); 

        Console.WriteLine($"\n{name}, {age} yaşındasın ve hedefin '{goal}'!");
        Console.WriteLine($"🎯 {messages[index]} 🚀");
    }
}

