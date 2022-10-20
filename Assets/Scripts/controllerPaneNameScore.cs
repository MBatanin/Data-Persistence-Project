using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controllerPaneNameScore : MonoBehaviour
{


    public Text tName, tScore;

    // Start is called before the first frame update
    void Start()
    {
        tName.text = GamerScore.nome;
        tScore.text = Convert.ToString(GamerScore.score);
    }

    
}
