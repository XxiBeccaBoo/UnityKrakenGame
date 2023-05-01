using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 3;
    public int health = 40;
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        level = data.level;
        health = data.health;
    }



    //ignore below for now.4:20 in video
    public void ChangeLevel (int amount)
    {
        level += amount;
    }
    public void ChangeHealth(int amount)
    {
        health += amount;
    }
}
