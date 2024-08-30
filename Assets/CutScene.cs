using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CutScene : MonoBehaviour
{
    //public SceneandLogicManager manager;
    
    // Start is called before the first frame update
    void Start()
    {   
       
        Invoke("changeToSequence", 9.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeToSequence()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
