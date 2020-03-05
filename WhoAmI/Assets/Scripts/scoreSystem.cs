using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreSystem : MonoBehaviour
{
    //public int sanguine;
    //public int choleric;
    //public int melancholic;
    //public int phlegmatic;
    private int[] scoreArray;

    // Start is called before the first frame update
    void Start()
    {
        scoreArray = new int[4];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextScene()
    {
       
        int maxIndex = findMax();
   

        if(maxIndex == 0)
        {
            SceneManager.LoadScene(1);
        }
        if (maxIndex == 1)
        {
            SceneManager.LoadScene(2);
        }
        if (maxIndex == 2)
        {
            SceneManager.LoadScene(3);
        }
        if (maxIndex == 3)
        {
            SceneManager.LoadScene(4);
        }
    }


    int findMax()
    {
        
        int max = 0;
        int maxIndex = -1;

        for (int i = 0; i < scoreArray.Length; i++)
        {
            if (scoreArray[i] > max)
            {
                max = scoreArray[i];
                maxIndex = i;
            }
        }
        print("MaxIndex: " + maxIndex);
        return maxIndex;

        
    }

    public void UpdateScoreArray(int sanguine, int choleric, int melancholic, int phlegmatic)
    {
        scoreArray[0] += melancholic;
        scoreArray[1] += phlegmatic;
        scoreArray[2] += sanguine;
        scoreArray[3] += choleric;

        for (int i = 0; i < scoreArray.Length; i++)
        {
            print(scoreArray[i]);

        }
       
    }
}
