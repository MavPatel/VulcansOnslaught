using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

    public static GameManagerScript Instance { get; private set; }
    public LevelManager levelmanager;

    public int maxHealth = 4;
    public int health;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        levelmanager = GameObject.FindGameObjectWithTag("Level").GetComponent<LevelManager>();
        health = maxHealth;
    }

    public void SetHealth(int SetAmmount)
    {
        health = SetAmmount;
        Mathf.Clamp(health, 0, maxHealth);
        if(health <= 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
        }
    }
    public void SetHealth(int AddAmmount,int useless)
    {

        health += AddAmmount;
        Mathf.Clamp(health, 0, maxHealth);
        if (health <= 0)
        {
            health = maxHealth;
            levelmanager.ChangeLevel("GameOver");
        }
    }

    public int GetHealth()
    {
        return health;
    }
}
