//Структурныq паттерн Декоратор
Enemy enemy1 = new Fighter();
enemy1 = new SwordEnemy(enemy1.Hp, enemy1.Atk,3, "Крутой меч", enemy1);
enemy1.Run();
enemy1.Atack();

Enemy enemy2 = new Fighter();
enemy2 = new BowEnemy(enemy2.Hp, enemy2.Atk, 1, "Лук", enemy2);
enemy2.Run();
enemy2.Atack();

Enemy enemy3 = new Tank();
enemy3 = new SwordEnemy(enemy3.Hp, enemy3.Atk, 3, "Меч", enemy3);
enemy3.Run();
enemy3.Atack();
abstract class Enemy
{
    public Enemy(int hp, int atk)
    {
        Hp = hp;
        Atk = atk;
    }
    public int Hp { get; protected set; }
    public int Atk { get; protected set; }
    public abstract void Atack();
    public abstract void Run();
}

class Fighter : Enemy
{
    public Fighter() : base(3, 5)
    { }
    public override void Atack()
    {
        Console.Write("Боец атакует");
    }
    public override void Run()
    {
        Console.Write("Боец ходит");
    }
}
class Tank : Enemy
{
    public Tank(): base(10, 3)
    { }
    public override void Atack()
    {
        Console.Write("Танк атакует");
    }
    public override void Run()
    {
        Console.Write("Танк ползет");
    }
}

abstract class EnemyWithWeapon : Enemy
{
    protected Enemy enemy;
    protected string weapon_name;
    public EnemyWithWeapon(int hp, int atk,int weapon_boost,string weapon_name, Enemy enemy) : base(hp, atk + weapon_boost)
    {
        this.enemy = enemy;
        this.weapon_name = weapon_name;
    }
}

class SwordEnemy : EnemyWithWeapon
{
    public SwordEnemy(int hp, int atk, int weapon_boost, string weapon_name, Enemy enemy) : base(hp, atk, weapon_boost, weapon_name, enemy)
    { }

    public override void Atack()
    {
        enemy.Atack();
        Console.WriteLine($"({weapon_name})");
    }
    public override void Run()
    {
        enemy.Run();
    }
}

class BowEnemy : EnemyWithWeapon
{
    public BowEnemy(int hp, int atk, int weapon_boost, string weapon_name, Enemy enemy) : base(hp, atk, weapon_boost, weapon_name, enemy)
    { }

    public override void Atack()
    {
        enemy.Atack();
        Console.WriteLine($"({weapon_name})");
    }
    public override void Run()
    {
        enemy.Run();
    }
}