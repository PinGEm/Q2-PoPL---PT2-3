using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCStats : MonoBehaviour
{
    [SerializeField] protected int Health;
    [SerializeField] protected int Defense;
    [SerializeField] protected float Speed;
    public int Attack;

    protected abstract void Strike();
}
