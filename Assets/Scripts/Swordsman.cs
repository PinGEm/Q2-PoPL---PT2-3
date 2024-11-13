using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : PlayerStats, Damage_System
{
    [SerializeField] private Goblin gobbers;
    private void Start()
    {
        Strike();
        Damage_System(gobbers.Attack);
    }

    protected override void Strike()
    {
        Debug.Log("Swordsman is about to get hit!");
    }

    public void Damage_System(int dmg)
    {
        Debug.Log("Swordsman Current HP: " + Health);
        Health -= dmg; // Will probably change later
        Debug.Log("Swordsman HP: " + Health);
        Debug.Log("---------");
    }
}
