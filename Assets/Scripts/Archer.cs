using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Archer : PlayerStats, Damage_System
{
    [SerializeField] private Mercenary merc;
    private void Start()
    {
        Strike();
        Damage_System(merc.Attack);
    }

    protected override void Strike()
    {
        Debug.Log("Archer is about to get hit!");
    }

    public void Damage_System(int dmg)
    {
        Debug.Log("Archer Current HP: " + Health);
        Health -= dmg; // Will probably change later
        Debug.Log("Archer HP: " + Health);
    }
}
