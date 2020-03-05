using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldIngots : MonoBehaviour
{
    private bool inRange;
    public int M;
    public int P;
    public int S;
    public int C;
    public bool end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange == true)
        {

            GameObject.Find("ScoreManager").GetComponent<scoreSystem>().UpdateScoreArray(S, C, M, P);

            if (end == true)
            {
                GameObject.Find("ScoreManager").GetComponent<scoreSystem>().nextScene();
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
