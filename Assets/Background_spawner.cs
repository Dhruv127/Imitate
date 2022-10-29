using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxTime = 1;
    private float timer = 0;
    public GameObject Pixel_Art_Background;
    void Start()
    {
        GameObject new_background = Instantiate(Pixel_Art_Background);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>maxTime)
        {
            GameObject new_background = Instantiate(Pixel_Art_Background);
           timer=0; 
        }
        timer+= Time.deltaTime;
    }
}
