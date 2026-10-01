using System;


class Character
{
    public string Name;
    public int HP;
    public int Attack;
}

class Player : Character
{
    public Player(string name, int hp, int attack)
    {
        Name = name;
        HP = hp;
        Attack = attack;
    }
}

class Enemy : Character
{
    public Enemy(string name, int hp, int attack)
    {
        Name = name;
        HP = hp;
        Attack = attack;
    }
}

class Program
{
    static void Main()
    {
        Player player = new Player("", 100, 15);
        Enemy enemy = new Enemy("Slime", 50, 8);

        Console.WriteLine("=== Text RPG ===");
        Console.WriteLine("플레이어 이름을 입력하세요: ");
        player.Name = Console.ReadLine();
        Console.WriteLine("야생의 Slime이 나타났습니다!");

        Console.WriteLine($"{player.Name} HP : {player.HP}");
        Console.WriteLine($"{enemy.Name} HP : {enemy.HP}");

        while (player.HP > 0 || enemy.HP > 0)
        {

        Console.WriteLine("1. 공격");
        Console.WriteLine("2. 상태 확인");

        Console.Write("선택: ");

        int input;
        if (!int.TryParse(Console.ReadLine(), out input))
        {   
            Console.WriteLine("숫자를 입력해 주세요.");
            continue;
        }

        if (input != 1 && input != 2)
        {
            Console.WriteLine("1 또는 2를 입력해 주세요.");
            continue;
        }

        if (input == 1)
        {
            Console.WriteLine($"{player.Name}의 공격!");
            Console.WriteLine($"{enemy.Name}에게 15의 데미지!");
            enemy.HP = enemy.HP - player.Attack;
            Console.WriteLine($"{enemy.Name} HP : {enemy.HP}");

            Console.WriteLine($"{enemy.Name}의 공격!");
            Console.WriteLine($"{player.Name}에게 8의 데미지!");
            player.HP = player.HP - enemy.Attack;
            Console.WriteLine($"{player.Name} HP : {player.HP} ");

        }
        if (input == 2)
        {
            Console.WriteLine($"{player.Name} HP : {player.HP}");
            Console.WriteLine($"{enemy.Name} HP : {enemy.HP}");
        }
        if (player.HP <= 0)
            {
                Console.WriteLine("패배!");
                break;
            }
        if (enemy.HP <= 0)
            {
                Console.WriteLine("승리!");
                break;
            }
        

        }

        

    }
}
