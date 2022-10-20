using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class populatedScript : MonoBehaviour
{

    public GameObject pNameScore, content;


    // Start is called before the first frame update

    void Start()
    {
        GamerScore.nome = "Jose";
        GamerScore.score = 123;
        GameObject obj = Instantiate(pNameScore,content.transform);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
