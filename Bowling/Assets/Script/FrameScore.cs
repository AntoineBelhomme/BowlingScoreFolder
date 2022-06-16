using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrameScore : MonoBehaviour
{

    public Text text;
    public Text prevScore;
    public Text special;
    public InputField input1;
    public InputField input2;
    public InputField input3;
    public InputField input4;
    public InputField input5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void math()
    {
        int prev = 0;
        if(prevScore.text != "")
        {
            prev = int.Parse(prevScore.text);
        }

        int x = int.Parse(input1.text);
        int y = int.Parse(input2.text);
        if (x == 10)
        {
            int three = int.Parse(input3.text);
            special.text = "Strike";

            if (three == 10)
            {
                int five = int.Parse(input5.text);
                text.text = (prev + x + three + five).ToString();
            }
            else
            {
                int four = int.Parse(input4.text);
                
                text.text = (prev + x + three + four).ToString();
            }

        }
        else if( (x + y) == 10)
        {
            special.text = "Spare";
            int three = int.Parse(input3.text);
            text.text = (prev + x + three + y).ToString();
        }
        else
        {
            special.text = "";
            text.text = (prev + x + y).ToString();
        }
    }   
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
