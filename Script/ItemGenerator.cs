using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject LogPrefab;

    public GameObject car4Prefab;
        
    // Start is called before the first frame update
    void Start()
    {        

        //Instantiate(LogPrefab, new Vector3(vecX, 0, vecZ),Quaternion.identity);

        for (var i = 0; i < 15; i++)
        {
            int item = Random.Range(1, 11);

            float offsetX = Random.Range(-21.0f,22.0f);

            if(-2 <= offsetX && offsetX <= 2)
            {
                offsetX = offsetX + 4;
            }

            float offsetZ = Random.Range(-18.0f, 19.0f);

            if (1 <= item && item <= 3)
            {
                GameObject carObject = Instantiate(car4Prefab);
                carObject.transform.position = new Vector3(offsetX, carObject.transform.position.y, offsetZ);
            }         
            
            if (4 <= item && item <= 10)
            {
                GameObject logObject = Instantiate(LogPrefab);
                logObject.transform.position = new Vector3(offsetX, logObject.transform.position.y, offsetZ);
            }
                       
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
