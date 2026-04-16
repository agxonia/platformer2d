using System;
using TMPro;
using UnityEngine;

public class UI_health_display : MonoBehaviour
{
    public healthcomponent healthComponent;
    public TextMeshProUGUI textComponent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthComponent.OnHealthInitialized += OnHealthInitialized;
        healthComponent.OnHealthChanged += OnHealthChanged;
    }

    private void OnHealthInitialized(float newHealth)
    {
        textComponent.text = newHealth.ToString(); 
    }

    private void OnHealthChanged(float newHealth, float amountChanged)
    {
        textComponent.text = newHealth.ToString();
        //Debug.Log(newHealth + ":" + amountChanged);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
