using System.Reflection.Metadata.Ecma335;

abstract class Character
{
    private string characterType;
    private bool isVulnerable;
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return this.isVulnerable;
    }

    public override string ToString()
    {
        return $"Character is a {this.characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        return target.Vulnerable() ? 10 : 6;
    }
}

class Wizard : Character
{
    public Wizard() : base("Wizard")
    {
    }

    public bool preparedSpell;

    public override int DamagePoints(Character target)
    {
        return !Vulnerable() ? 12 : 3;
    }

    public override bool Vulnerable()
    {
        return !preparedSpell;
    }

    public void PrepareSpell()
    {
        this.preparedSpell = true;
    }
}
