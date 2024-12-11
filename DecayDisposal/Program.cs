using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Selamat datang di game Decay Disposal!");
        Console.WriteLine("Tekan Enter untuk melanjutkan");
        Console.ReadLine();

        Player player = new Player(health: 100, level: 1);
        Random rand = new Random();

        while (player.Level <= 10 && player.Health > 0)
        {
            Enemy enemy = EnemyFactory.GetEnemy(player.Level);
            Console.WriteLine($"\n--- Musuh Muncul! (Level Pemain: {player.Level}) ---");
            Console.WriteLine($"Musuh: HP = {enemy.Health}, Damage = {enemy.Damage}");

            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine($"\nPemain HP: {player.Health} | Musuh HP: {enemy.Health} | Level: {player.Level} | Exp: {player.Exp}");
                Console.WriteLine("Pilih aksi:");
                Console.WriteLine("1. Serangan Biasa");
                Console.WriteLine("2. Serangan Kuat");
                Console.WriteLine("3. Bertahan");
                Console.WriteLine("4. Gunakan Potion");
                Console.WriteLine("5. Keluar Game");
                Console.Write("Pilihan: ");

                string? choice = Console.ReadLine();

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
                    case "4":
                        player.UsePotion();
                        continue;
                    case "5":
                        Console.WriteLine("Kamu yakin ingin keluar game? (y/n)");
                        string? input = Console.ReadLine();
                        if (input == "y")
                        {
                            Console.WriteLine("Kamu memutuskan untuk keluar dari permainan. Terima kasih telah bermain!");
                            return;
                        }
                        else
                        {
                            continue;
                        }
                    default:
                        Console.WriteLine("Pilihan tidak valid, kamu melewatkan giliran!");
                        break;
                }

                player.ExecuteStrategy(enemy);

                if (enemy.Health > 0)
                {
                    enemy.Attack(player);
                }
            }

            if (player.Health > 0)
            {
                Console.WriteLine("Kamu mengalahkan musuh!");
                player.AddExp(50);

                if (rand.NextDouble() < 0.3)
                {
                    double roll = rand.NextDouble();
                    PotionType potionType;
                    if (roll < 0.33)
                        potionType = PotionType.Red;
                    else if (roll < 0.66)
                        potionType = PotionType.Yellow;
                    else
                        potionType = PotionType.Green;

                    player.AddPotion(new Potion(potionType));
                }

                if (player.Level == 10 && enemy is BossEnemy && enemy.Health <= 0)
                {
                    Console.WriteLine("Kamu berhasil mengalahkan Final Boss! Selamat! Kamu telah menyelesaikan game Decay Disposal.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Kamu kalah! Game Over.");
                break;
            }
        }
    }
}
