using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {


    
    public void ChangeLevel(string level)
    {
        SceneManager.LoadScene(level); 
    }
   
}
