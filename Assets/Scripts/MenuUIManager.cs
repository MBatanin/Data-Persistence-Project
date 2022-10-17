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
    public Button bStart, bQuit;


    void Start()
    {
        tBestScore.text = DataString.bestScore;
        ifName.GetComponentInChildren<Text>().text = DataString.plcaHolder;
        bStart.GetComponentInChildren<Text>().text = DataString.bStart;
        bQuit.GetComponentInChildren<Text>().text = DataString.bQuit;
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
    public void onClickQuit()
    {
        Application.Quit();
    }

}
