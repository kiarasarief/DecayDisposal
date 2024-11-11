using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player(health: 100);
        Enemy enemy = new Enemy(health: 50);

        while (player.Health > 0 && enemy.Health > 0)
        {
            Console.WriteLine("\n--- Pertarungan Dimulai ---");
            Console.WriteLine($"Pemain HP: {player.Health} | Musuh HP: {enemy.Health}");
            
            Console.WriteLine("Pilih aksi:");
            Console.WriteLine("1. Serangan Biasa");
            Console.WriteLine("2. Serangan Kuat");
            Console.WriteLine("3. Bertahan");
            Console.Write("Pilihan: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    player.SetStrategy(new NormalAttack());
                    break;
                case "2":
                    player.SetStrategy(new StrongAttack());
                    break;
                case "3":
                    player.SetStrategy(new Defend());
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid, kamu melewatkan giliran!");
                    continue;
            }

            player.ExecuteStrategy(enemy);

            if (enemy.Health > 0)
            {
                enemy.Attack(player);
            }
        }

        Console.WriteLine("\n--- Pertarungan Selesai ---");
        if (player.Health > 0)
        {
            Console.WriteLine("Selamat! Kamu menang.");
        }
        else
        {
            Console.WriteLine("Kamu kalah. Coba lagi!");
        }
    }
}
