using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]

public class Player_State
{
    public string Character_Name;
    public int Ability_Strength;
    public int Ability_Dexterity;
    public int Ability_Constitution;
    public int Ability_Intelligence;
    public int Ability_Wisdom;
    public int Ability_Charisma;
    public string Race;
    public string Class;
    public string Alignment;
    public int Experience_Points;
    public int Hit_Points;
    public int Armor_Class;
    public int Walking_Speed;
    public int Running_Speed;
    public int Jumping_Speed;
    public List<String> Item_List;

    Player_State myPlayerState;

    public void Awake()
    {
        myPlayerState = new Player_State();
    }

    public string SaveToString()
    {
        return JsonUtility.ToJson(this);
    }

}