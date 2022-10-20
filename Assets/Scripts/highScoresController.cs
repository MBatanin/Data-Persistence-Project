using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class highScoresController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text tHihgScores;
    public GameObject pNameScore;
    public ScrollView svScore;


    public void Start()
    {
        
        tHihgScores.text = DataString.tHighScores;

        var pane1 = Instantiate(pNameScore,transform);
        
        
    }
}
