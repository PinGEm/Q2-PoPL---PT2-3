using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : NPCStats, Damage_System
{
    [SerializeField] private Archer bow;
    private void Start()
    {
        Strike();
        Damage_System(bow.Attack);
    }

    protected override void Strike()
    {
        Debug.Log("Goblin is about to get hit!");
    }

    public void Damage_System(int dmg)
    {
        Debug.Log("Goblin Current HP: " + Health);
        Health -= dmg; // Will probably change later
        Debug.Log("Goblin HP: " + Health);
        Debug.Log("---------");
    }
}
