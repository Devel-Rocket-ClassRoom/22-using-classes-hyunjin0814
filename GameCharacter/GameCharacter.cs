using System;

class GameCharacter
{
    private string name;
    private int level;
    private int maxHp;
    private int currentHp;
    private int attackPower;
    private bool isAlive;

    public string Name { get { return name; }  }
    public int Level { get { return level; } }
    public int MaxHp { get { return maxHp; } }
    public int CurrentHp { get {return currentHp; } }
    public int AttackPower { get { return attackPower; } }
    public bool IsAlive { get { return isAlive; } }

    public GameCharacter(string name, int level)
    {
        this.name = name;
        this.level = level;
        this.maxHp = level * 100;
        this.currentHp = maxHp;
        this.attackPower = level * 10;
        this.isAlive = currentHp > 0;
    }

    public void Attack(GameCharacter target)
    {
        Console.WriteLine($"{Name}이(가) {target.Name}에게 {AttackPower} 데미지를 입혔습니다!");
        target.TakeDamage(AttackPower);
    }

    public void TakeDamage(int damage)
    {
        if (currentHp - damage < 0)
        {
            isAlive = false;
            currentHp = 0;
        }
        else
        {
            currentHp -= damage;
        }
    }

    public void ShowStatus()
    {
        Console.WriteLine($"[{Name}] Lv.{Level} - HP: {CurrentHp}/{MaxHp}, 공격력: {AttackPower}");
    }

}