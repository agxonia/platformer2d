using UnityEngine;
using TMPro;
using UnityEngine.InputSystem.Android;

public class numbertextincreaser : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    int counter;

    public void ButtonPressed()
    {
        counter++;
        numberText.text = counter + "";

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
