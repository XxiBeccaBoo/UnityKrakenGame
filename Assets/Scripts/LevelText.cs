using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    public Text textField;
    public Player p;
    int number;
   void Start()
    {
        textField = GameObject.Find("Number").GetComponent<Text>();
    }

    //adds 1 to level text everytime plus button is pressed
    public void changeLevelPlus()
    {
        number += 1;
        textField.text = "" + number;
        p.ChangeLevel(1);
    }
    //subtracts 1 to level text everytime plus button is pressed
    public void changeLevelMinus()
    {
        number -= 1;
        textField.text = "" + number;
        p.ChangeLevel(-1);
    }



    public void setLevel(int l)
    {
        number = l;
        textField.text = "" + number;
    }

}
