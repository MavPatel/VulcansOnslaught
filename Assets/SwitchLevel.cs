using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevel : MonoBehaviour {



    LevelManager level;
    private void Start()
    {
        level = GameObject.FindGameObjectWithTag("Level").GetComponent<LevelManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && SceneManager.GetActiveScene().name == "Level-1")
        {
            level.ChangeLevel("Level-2");
        }else if(collision.gameObject.tag == "Player" && SceneManager.GetActiveScene().name == "Level-2")
        {
            level.ChangeLevel("Level-3");
        }
        else if (collision.gameObject.tag == "Player" && SceneManager.GetActiveScene().name == "Level-3")
        {
            level.ChangeLevel("Level-4");
        }
    }
}
