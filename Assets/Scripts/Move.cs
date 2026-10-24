using UnityEngine;

public class Move
{
    public string MoveName { get; protected set; }
    public string Type { get; protected set; }

    public Move(string name, string type)
    {
        MoveName = name;
        Type = type;
    }

    public virtual void Apply(Beast user, Beast target)
    {
        Debug.Log($"{user.Status()} uses {MoveName}!");
    }
}