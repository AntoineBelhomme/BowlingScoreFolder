using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bowling : MonoBehaviour
{

    public string test = "0";
    public InputField input;
    public InputField input2;

    private void Awake()
    {
        
    }

    public void GetInput(string pins)
    {
        if (pins == "")
        {
            pins = "0";
            input.text = pins;
        }
        else if (int.Parse(pins)<0)
        {
            pins = "0";
            input.text = pins;
        }
        int x = int.Parse(input.text);
        int y = int.Parse(input2.text);
        if (x >= 10)
        {
            pins = "10";
            input.text = "10";
            input2.text = "0";
            input2.interactable = false;
        }
        else
        {
            input2.interactable = true;
            if ((x + y) > 10)
            {
                input.text = (10 - y).ToString();
            }
            else
            {
                input.text = pins;
            }
        }
    }

    
  

    // Update is called once per frame
    void Update()
    {
        
    }
}
