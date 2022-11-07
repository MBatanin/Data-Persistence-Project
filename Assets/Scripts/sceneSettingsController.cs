using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneSettingsController : MonoBehaviour
{
    public Button bBackMenu;
    // Start is called before the first frame update
    void Start()
    {
        bBackMenu.GetComponentInChildren<Text>().text = DataString.bBackMenu;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void bBackMenuPressed()
    {

        SceneManager.LoadScene(DataString.sMenu);

    }
}
