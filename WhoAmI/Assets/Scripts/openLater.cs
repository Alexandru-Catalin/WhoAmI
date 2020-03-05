using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openLater : MonoBehaviour
{

    private Animator anim;
    public float timer = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer < 0)
        {
            
            anim.SetBool("Open", true);
        }
    }
}
