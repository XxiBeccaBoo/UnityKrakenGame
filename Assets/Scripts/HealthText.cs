using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public Text textField;
    int number;
   void Start()
    {
        textField = GameObject.Find("NumberHealth").GetComponent<Text>();
    }

    public void changeHealthPlus()
    {
        number += 1;
        textField.text = "" + number;
    }
    public void changeHealthMinus()
    {
        number -= 1;
        textField.text = "" + number;
    }

}
