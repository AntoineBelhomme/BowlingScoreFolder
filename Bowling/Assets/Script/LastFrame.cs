using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastFrame : MonoBehaviour
{
    public Text text;
    public Text prevScore;
    public Text special;
    public Text finalScore;
    public InputField input1;
    public InputField input2;
    public InputField input3;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void math()
    {
        int prev = int.Parse(prevScore.text);
        int x = int.Parse(input1.text);
        int y = int.Parse(input2.text);
        int z = int.Parse(input3.text);
        if (x == 10)
        {
            special.text = "Strike";
            if (y == 10)
            {
                text.text = (prev + x + y + z).ToString();
            }
            else if (y + z > 10)
            {
                z = (10 - y);
                input3.text = z.ToString();
                text.text = (prev + x + y + z).ToString();
            }
            else
            {
                text.text = (prev + x + y + z).ToString();
            }
            input3.interactable = true;
        }
        else if(x + y == 10)
        {
            special.text = "Spare";
            text.text = (prev + x + y + z).ToString();
            input3.interactable = true;
        }
        else if(x + y > 10)
        {
            y = (10 - x);
            input2.text = y.ToString();
            special.text = "Spare";
            text.text = (prev + x + y + z).ToString();
            input3.interactable = true;
        }
        else
        {
            special.text = "";
            text.text = (prev + x + y).ToString();
            input3.text = "0";
            input3.interactable = false;
        }
    }
    public void DfinalScore()
    {
        if (input3.interactable == true)
        {
            if (input3.text != "0")
            {
                finalScore.text = "Final Score: " + text.text;
            }
        }
        else
        {
            finalScore.text = "Final Score: " + text.text;
        }
    }

            // Update is called once per frame
    void Update()
    {
        
    }
}
