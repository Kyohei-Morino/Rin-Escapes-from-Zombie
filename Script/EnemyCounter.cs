using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{
    public GameObject zombie;

    public Text zombieCounter;

    private int count;


    // Start is called before the first frame update
    void Start()
    {
        zombie = GameObject.Find("Zombie3");
    }

    // Update is called once per frame
    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("ZombieTag").Length;

        zombieCounter.text = "ENEMY : " + count.ToString();
    }
}
