using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reinstantiate : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxTime = 1;
    private float timer = 0;
    public GameObject Boulder;
    
    void Start()
    {
        GameObject new_Boulder = Instantiate(Boulder, new Vector3(14,-3.5f,0),Quaternion.identity);
       // new_Boulder.transform.position = transform.position +new Vector3(14,-3,0);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject new_Boulder = Instantiate(Boulder,new Vector3(14,-3.5f,0),Quaternion.identity);
            //new_Boulder.transform.position = transform.position + new Vector3(14, -3, 0);
            Destroy(new_Boulder, 10);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
