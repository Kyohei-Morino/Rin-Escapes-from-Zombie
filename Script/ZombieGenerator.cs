using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieGenerator : MonoBehaviour
{
    public GameObject Zombie3;

    public AudioSource zombieVoice;

    // Start is called before the first frame update
    void Start()
    {
        zombieVoice = GetComponent<AudioSource>();

        InvokeRepeating("Generate", 0, 10f);
    }

    // Update is called once per frame
    void Generate()
    {
        zombieVoice.Play();

        float appearancePoint = Random.Range(-23.0f, 24.0f);

        GameObject zombie = Instantiate(Zombie3);
        zombie.transform.position = new Vector3(appearancePoint, transform.position.y, appearancePoint);

    }
}
