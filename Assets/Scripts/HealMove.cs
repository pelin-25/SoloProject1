using UnityEngine;

public class HealMove : Move
{
    private int healAmount;

    public HealMove(string name, int healAmount) : base(name, "Healing")
    {
        this.healAmount = healAmount;
    }

    public override void Apply(Beast user, Beast target)
    {
        base.Apply(user, target);
        user.Heal(healAmount);
        Debug.Log($"{user.Status()} heals for {healAmount} HP!");
    }
}
