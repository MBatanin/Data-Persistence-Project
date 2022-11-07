using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text tBestScore;
    public InputField ifName;
    public Button bStart, bQuit, bHighScores, bSettings;



    void Start()
    {
        tBestScore.text = DataString.bestScore;
        ifName.GetComponentInChildren<Text>().text = DataString.plcaHolder;
        bStart.GetComponentInChildren<Text>().text = DataString.bStart;
        bQuit.GetComponentInChildren<Text>().text = DataString.bQuit;
        bHighScores.GetComponentInChildren<Text>().text = DataString.bHighScores;
        bSettings.GetComponentInChildren<Text>().text = DataString.bSettings;
        //Debug.Log(GamerScore.);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickStart()
    {
        DataString.playerName = ifName.text;
        SceneManager.LoadScene(DataString.sMainScene);
    }
    public void onClickHighScores()
    {
        SceneManager.LoadScene(DataString.sHighScores);
    }
    public void onClickSettings() {
        SceneManager.LoadScene(DataString.sSettings);
    }
    public void onClickQuit()
    {
        Application.Quit();
    }

}
