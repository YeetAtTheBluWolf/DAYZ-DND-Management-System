using DAYZDND.loot;

public abstract class Weapon : Item
{

	public WeaponType MeleeType { get; set; }

	public Weapon(LootRarity rarity, string name, string description, WeaponType weaponType) : base(rarity, name, description)
	{
		MeleeType = weaponType;
	}

	public abstract void Attack();

}
