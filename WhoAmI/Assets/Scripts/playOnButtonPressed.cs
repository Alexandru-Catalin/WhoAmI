using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playOnButtonPressed : MonoBehaviour
{

    public AudioClip audioClip;
    public AudioSource audioSource;
    public bool played = false;
    public GameObject[] destroy;
    private bool inRange;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        played = false;
    }

    // Update is called once per frame
    void Update()
    {
           
       

    }

    private void OnTriggerEnter(Collider other)
    {
        //inRange = true;
        //if (Input.GetKeyDown(KeyCode.E) && other.gameObject.tag == "Player")
        //{
        //    if (played == false)
        //    {
        //        audioSource.Play();
        //        played = true;
        //    }
        //}
    }

    private void OnTriggerExit(Collider other)
    {
        inRange = false;
    }
}

  