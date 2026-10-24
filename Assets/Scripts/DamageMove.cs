using UnityEngine;

public class DamageMove : Move
{
    protected int power;

    public DamageMove(string name, string type, int power) : base(name, type)
    {
        this.power = power;
    }

    public override void Apply(Beast user, Beast target)
    {
        base.Apply(user, target);
        int damage = power; // Base damage calculation
        target.TakeDamage(damage);
        Debug.Log($"{target.Status()} takes {damage} damage!");
    }
}
