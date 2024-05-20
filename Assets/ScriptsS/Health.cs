using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    
    [SerializeField]
    private int maxHp = 45;
    private int hp;
    private int amount = 15;

    public int MaxHp => maxHp;
    public int Damage => amount;

    public int health
    {
        get => hp;
        private set
        {
            var isPunch = value < hp;
            hp = Mathf.Clamp(value, 0, maxHp);
            if (isPunch)
            {
                Punched?.Invoke(hp);
            }
            if (hp <= 0)
            {
                Defeated?.Invoke();
            }
        }
    }

    
public UnityEvent<int> Punched;
public UnityEvent Defeated;

private void Awake()
    {
        hp = maxHp;
    }

    public void Punch(int amount)
    {
        hp -= amount;
    }

    public void Defeat() 
    {
        hp = 0;
    }
}
