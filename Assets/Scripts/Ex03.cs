using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ex03 : MonoBehaviour
{
    public TextMeshProUGUI textValue; //Textfield to modify
    private int value = 0; //value to display

    private void Start()
    {
        textValue.text = $"Value: {value}";    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            value++; //Increase value
            textValue.text = $"Value: {value}";
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            value--; //Decrease value
            textValue.text = $"Value: {value}";
        }
    }

}
