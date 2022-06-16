using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondShot : MonoBehaviour
{

    public string test = "0";
    public InputField input;
    public InputField input2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GetInput(string pins)
    {
        if (pins == "")
        {
            pins = "0";
            input2.text = pins;
        }
        else if (int.Parse(pins) < 0)
        {
            pins = "0";
            input2.text = pins;
        }
        int x = int.Parse(input.text);
        int y = int.Parse(input2.text);
        if (y >= (10-x))
        {
            input2.text = (10 - x).ToString();
           
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
