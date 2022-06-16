using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastShot : MonoBehaviour
{

    public InputField input;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void GetInput(string pins)
    {
        if (pins == "")
        {
            pins = "0";
            input.text = pins;
        }
        else if (int.Parse(pins) < 0)
        {
            pins = "0";
            input.text = pins;
        }
        else if (int.Parse(pins)>10)
        {
            pins = "10";
            input.text = pins;
        }
        int x = int.Parse(pins);
        input.text = pins;
        

        }
    // Update is called once per frame
    void Update()
    {
        
    }
}
