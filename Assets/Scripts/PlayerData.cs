using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class PlayerData
{

    public int score;
    public string Name;

    public PlayerData(string _name, int _score) { 
        Name = _name;
        score = _score;
    }
    public PlayerData()
    {
        
    }

}
