using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : MonoBehaviour
{

    private bool inRange;
    public GameObject[] destroy;
    public GameObject audio;
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

            destroy[0].GetComponent<Trees>().enabled = false;
            destroy[1].GetComponent<Trees>().enabled = false;
            destroy[2].GetComponent<Trees>().enabled = false;

            GameObject.Find("ScoreManager").GetComponent<scoreSystem>().UpdateScoreArray(S, C, M, P);
            audio.GetComponent<AudioSource>().Play();

            this.gameObject.SetActive(false);

            if (end == true)
            {
                GameObject.Find("ScoreManager").GetComponent<scoreSystem>().nextScene();
            }
        }

        if (Input.GetMouseButtonDown(0) && inRange == true)
        {

            destroy[0].GetComponent<Trees>().enabled = false;
            destroy[1].GetComponent<Trees>().enabled = false;
            destroy[2].GetComponent<Trees>().enabled = false;

            GameObject.Find("ScoreManager").GetComponent<scoreSystem>().UpdateScoreArray(S, C, M, P);
            audio.GetComponent<AudioSource>().Play();

            this.gameObject.SetActive(false);

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
