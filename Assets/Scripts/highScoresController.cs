using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class highScoresController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text tHihgScores;
    public GameObject pNameScore;
    public ScrollView svScore;
    public UnityEngine.UI.Button bBackMenu;


    public void Start()
    {
        bBackMenu.GetComponentInChildren<Text>().text = DataString.bBackMenu;

        tHihgScores.text = DataString.tHighScores;

        //var pane1 = Instantiate(pNameScore, transform);


    }
    public void bBackMenuPressed()
    {

        SceneManager.LoadScene(DataString.sMenu);

    }
}
