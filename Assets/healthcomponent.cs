using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class healthcomponent : MonoBehaviour
{
    private float Health = 10;
    public float MaxHealth = 15;

    public delegate void OnHealthChangedHandler(float newHealth, float amountChanged);
    public event OnHealthChangedHandler OnHealthChanged;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddDamage(float damage)
    {
        Health -= damage;
       // Debug.Log(Health);

        if (Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
        public void AddHealth(float HealingValue)
        {
            Health += HealingValue;

        if (Health >= MaxHealth) 
        {
            Health = MaxHealth;
        }
        OnHealthChanged?.Invoke(Health, HealingValue);
           // Debug.Log(Health);
        

        }
    }

