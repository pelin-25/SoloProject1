
using System.Collections.Generic;
using UnityEngine;

public class Beast
{
    private string beastName;
    private string type;
    private int level;
    private int maxHp;
    private int currentHp;
    private int attack;
    private int defense;

    public List<Move> Moves { get; private set; } = new List<Move>();

    public Beast(string name, string type, int level, int maxHp, int attack, int defense)
    {
        this.beastName = name;
        this.type = type;
        this.level = level;
        this.maxHp = maxHp;
        this.currentHp = maxHp;
        this.attack = attack;
        this.defense = defense;
    }

    public string Status()
    {
        return $"{beastName} (Lv.{level} {type}) - HP: {currentHp}/{maxHp} | Atk: {attack} | Def: {defense}";
    }

    public void Learn(Move move)
    {
        Moves.Add(move);
    }

    public void TakeDamage(int amount)
    {
        currentHp -= amount;
        if (currentHp < 0) currentHp = 0;
    }

    public void Heal(int amount)
    {
        currentHp += amount;
        if (currentHp > maxHp) currentHp = maxHp;
    }

    public bool IsFainted()
    {
        return currentHp <= 0;
    }
}