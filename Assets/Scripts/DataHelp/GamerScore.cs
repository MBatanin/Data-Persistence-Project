using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamerScore
{
    // Start is called before the first frame update
    public string nome;
    public int score;
    public List<PlayerData> playerData;
    private static GamerScore instancia = new GamerScore();

    private GamerScore()
    {
        playerData = new List<PlayerData>();
        populaPlayerData();
    }

    private void populaPlayerData()
    {
        playerData.Add(new PlayerData("lol",10));
        playerData.Add(new PlayerData("lol2",14));
        playerData.Add(new PlayerData("lol2",1));
        playerData.Add(new PlayerData("lol5",19));
        playerData.Add(new PlayerData("lol1",7));
        playerData.Add(new PlayerData("lol3",30));
        playerData.Add(new PlayerData("lol1",20));
    }
    public static GamerScore getInstance()
    {
        return instancia;
    }

}
