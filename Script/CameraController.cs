using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject rin;

    private float differenceZ;

    private float differenceX;

    // Start is called before the first frame update
    void Start()
    {
        this.rin = GameObject.Find("Rin");

        this.differenceZ = rin.transform.position.z - this.transform.position.z;

        this.differenceX = rin.transform.position.x - this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.rin.transform.position.x - differenceX, this.transform.position.y, this.rin.transform.position.z - differenceZ);
    }
}
