using UnityEngine;
public class Entity : MonoBehaviour
{
    // Entity
    public string Name;
    public string Description;
    // Inventory
    public int[] Bullets;
    public string[] Items;
    public int[] Items_Amount;
    public string[] Weapons;
    // Health Stats
    // Defence Stats
    public int MaxDefence; // How High Health Can Be
    public int Defence;
    public int MinDefence; // How Low Health Can Be Before You Die
    public string Defence_Weakness;
    public int Defence_Weakness_Power;
    public string Defence_Ressistence;
    public int Defence_Ressistence_Power;
    // Armor Stats
    public int MaxArmor; // How High Armor Can Be
    public int Armor;
    public int MinArmor; // How Low Armor Can Be Before It Breaks
    public string Armor_Weakness;
    public int Armor_Weakness_Power;
    public string Armor_Ressistence;
    public int Armor_Ressistence_Power;
    // Damage Stats
    public int MaxDamage; // The Highest Damage Will Be For Any Hit
    public int Damage;
    public int MinDamage; // The Lowest Damage Will Be For Any Hit
    public string Damage_Type; // Aka For Weakness And Ressistence
    // Speed Stats
    public float Movement_Speed; // The Speed You Accelerate
    public float MaxMovement_Speed; // The Max Speed Of Movement Speed
    public float Attack_Speed;
}