using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RinController : MonoBehaviour
{
    
    private Animator myAnimator;
    
    private Rigidbody myRigidbody;
    
    private float velocityZ = 8f;

    private float velocityX = 8f;

    private bool isEnd = false;

    private GameObject stateText;       

    private AudioSource audioSource;

    private bool isOnce = true;

    private GameObject retryText;

       
    // Start is called before the first frame update
    void Start()
    {
        
        this.myAnimator = GetComponent<Animator>();
        
        this.myRigidbody = GetComponent<Rigidbody>();

        this.stateText = GameObject.Find("GameOverText");

        this.retryText = GameObject.Find("RetryText");

        audioSource = GetComponent<AudioSource>();
                             
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && isEnd == false)
        {
            myAnimator.SetBool("RunningBool", true);
            this.myRigidbody.velocity = new Vector3(0, 0, this.velocityZ);
            transform.rotation = Quaternion.AngleAxis(0, new Vector3(0, 1, 0));

        }
        else if (Input.GetKey(KeyCode.DownArrow) && isEnd == false)
        {
            myAnimator.SetBool("RunningBool", true);
            this.myRigidbody.velocity = new Vector3(0, 0, -this.velocityZ);
            transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 1, 0));
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && isEnd == false)
        {
            myAnimator.SetBool("RunningBool", true);
            this.myRigidbody.velocity = new Vector3(-this.velocityX, 0, 0);
            transform.rotation = Quaternion.AngleAxis(-90, new Vector3(0, 1, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow) && isEnd == false)
        {
            myAnimator.SetBool("RunningBool", true);
            this.myRigidbody.velocity = new Vector3(this.velocityX, 0, 0);
            transform.rotation = Quaternion.AngleAxis(90, new Vector3(0, 1, 0));
        }        
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            myAnimator.SetBool("RunningBool", false);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            myAnimator.SetBool("RunningBool", false);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            myAnimator.SetBool("RunningBool", false);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            myAnimator.SetBool("RunningBool", false);

        }

        if (isEnd == true)
        {
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");

                Time.timeScale = 1f;

            }
                        
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ZombieTag")
        {
            this.isEnd = true;
            this.stateText.GetComponent<Text>().text = "GAME OVER";
            this.retryText.GetComponent<Text>().text = "Press R Key to Retry";

            Time.timeScale = 0f;

            if (isOnce)
            {
                audioSource.Play();
                isOnce = false;
            }

        }        
    }
}
