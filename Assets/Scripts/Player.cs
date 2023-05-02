using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 3;
    public int health = 40;

    [SerializeField] public LevelText _lt;
    [SerializeField] public HealthText _ht;
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        level = data.level;
        health = data.health;

        _lt.setLevel(level);
        _ht.setHealth(health);
    }



    //ignore below for now.4:20 in video
    public void ChangeLevel (int amount)
    {
        level += amount;
        //Debug.Log("Player Level has increased to " + level +"!");
    }
    public void ChangeHealth(int amount)
    {
        health += amount;
    }
}
