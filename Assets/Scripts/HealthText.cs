using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public Text textField;
    public Player p;
    int number;
   void Start()
    {
        textField = GameObject.Find("NumberHealth").GetComponent<Text>();
    }

    public void changeHealthPlus()
    {
        number += 1;
        textField.text = "" + number;
        p.ChangeHealth(1);
    }
    //subtracts 1 to health text everytime plus button is pressed
    public void changeHealthMinus()
    {
        number -= 1;
        textField.text = "" + number;
        p.ChangeHealth(-1);
    }


    public void setHealth(int h)
    {
        number = h;
        textField.text = "" + number;
    }

}
