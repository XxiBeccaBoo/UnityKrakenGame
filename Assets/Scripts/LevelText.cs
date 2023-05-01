using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    public Text textField;
    int number;
   void Start()
    {
        textField = GameObject.Find("Number").GetComponent<Text>();
    }

    public void changeLevelPlus()
    {
        number += 1;
        textField.text = "" + number;
    }
    public void changeLevelMinus()
    {
        number -= 1;
        textField.text = "" + number;
    }

}
