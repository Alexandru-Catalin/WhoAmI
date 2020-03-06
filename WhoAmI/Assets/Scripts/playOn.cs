using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playOn : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;
    public bool played = false;

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
        if(other.gameObject.tag == "Player")
        {
            if (played == false)
            {
                audioSource.Play();
                played = true;
            }
           
            
        }
    }
}
