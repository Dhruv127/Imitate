using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scorePoints;
     public int score=0;
    bool isOUT=false;
    // Start is called before the first frame update
    
   
    // Update is called once per frame
    public void Update()
    {
        while(!isOUT)
        {
        scorePoints.text=(score+1).ToString("0");
        score=+1;
        }
    }
}
