using UnityEngine;
public class EntityVariables : MonoBehaviour
{
    // Entity Stats
    public int[] Bullets;
    public int[] Items;
    // Health Stats
    public int Health;
    public int MaxHealth;
    public string[] Resistances;
    public int MaxResistances;
    public string[] Weaknesses;
    public int MaxWeaknesses;
    // Armor Stats
    public int Armor;
    public int MaxArmor;
    public string[] ArmorResistances; // Armor Resistances
    public int MaxArmorResistances;
    public string[] ArmorWeaknesses; // Armor Weaknesses
    public int MaxArmorWeaknesses;
    // Defense Stats
    public float Defense;
    public string[] DefenseResistances; // Resistances
    public int MaxDefenseResistances;
    public string[] DefenseWeakness; // Weaknesses
    public int MaxDefenseWeaknesses;
    // Damage Stats
    public float Damage;
    public string[] DamageTypes; // Type
    public int MaxDamageTypes;
    public float ArmorPenetration;
    // Speed Stats
    public float MovementSpeed;
    public int MaxMovementSpeed;
    // Melee Weapon Stats
    public string MeleeWeapon;
    public int MeleeWeaponDurability;
    public int[] MeleeWeaponDamage; // Size = 3 Reason Weapon Has 3 Damage Veriables
    // Ranged Weapon Stats
    public string[] RangedWeapon; // Size = 3
    public int[] RangedWeaponDurability; // Size = 3
    public int[] RangedWeaponDamage; // Size = 9 Reason Each Weapon Has 3 Damage Veriables
    // Effect Stats
    public string[] EntityEffects; // Effects
    public int MaxEntityEffects;
    // Abilities Stats
    public string[] EntityAbilities; // Abilities
    public int MaxEntityAbilities;
    // Attributes Stats
    public string[] EntityAttributes; // Attributes
    public int MaxEntityAttributes;
    private void Start() // To Initiate All Arrays
    {
        
    }
}