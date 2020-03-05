using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class doorOpening : MonoBehaviour
{

    private Animator anim;
    private bool inRange;
    public GameObject destroy;
    public int M;
    public int P;
    public int S;
    public int C;
    public bool end;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange)
        {
            if (!anim.GetBool("Open"))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    anim.SetBool("Open", true);
                    destroy.GetComponent<doorOpening>().enabled = false;
                    GameObject.Find("ScoreManager").GetComponent<scoreSystem>().UpdateScoreArray(M, P, S, C);
                  
                    if (end == true)
                    {
                        GameObject.Find("ScoreManager").GetComponent<scoreSystem>().nextScene();
                    }
                                 
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetBool("Open", false);
            }
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        inRange = true;
    }

    private void OnTriggerExit(Collider collider)
    {
        inRange = false;
    }
}
