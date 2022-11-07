using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class populatedScript : MonoBehaviour
{

    public GameObject pNameScore, content;


    // Start is called before the first frame update

    void Start()
    {
        GameObject go = content;
        foreach (PlayerData playerData in GamerScore.getInstance().playerData)
        {
           
            GamerScore.getInstance().nome =playerData.Name;
            GamerScore.getInstance().score = playerData.score;

            go.transform.position = new Vector3(content.transform.position.x, go.transform.position.y-30, content.transform.position.z);
            //GameObject obj = Instantiate(pNameScore, content.transform);
            GameObject obj = Instantiate(pNameScore, go.transform);
            
            //Debug.Log(obj.GetComponents<RectTransform>().GetValue(0));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
