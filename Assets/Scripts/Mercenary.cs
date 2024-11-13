using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Mercenary : NPCStats, Damage_System
    {
    [SerializeField] private Swordsman sword;
    private void Start()
        {
            Strike();
            Damage_System(sword.Attack);
        }

        protected override void Strike()
        {
            Debug.Log("Mercenary is about to get hit!");
        }

        public void Damage_System(int dmg)
        {
            Debug.Log("Mercenary Current HP: " + Health);
            Health -= dmg; // Will probably change later
            Debug.Log("Mercenary HP: " + Health);
            Debug.Log("---------");
        }

    }