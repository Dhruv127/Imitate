using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reinstantiate : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxTimeBoulder= 1;
     public float maxTimeTunnel = 1;
      public float maxTimeHyena = 1;
       public float maxTimePond= 1;
        public float maxTimeTree = 1;
    private float timer = 0;
    public GameObject Boulder;
    public GameObject tunnel;
     public GameObject pond;
       public GameObject tree;
       public GameObject Hyena;
    
    void Start()
    {
        GameObject new_Boulder = Instantiate(Boulder, new Vector3(14,-3.5f,0),Quaternion.identity);
       // new_Boulder.transform.position = transform.position +new Vector3(14,-3,0);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (timer > maxTimeBoulder)
        {
            GameObject new_Boulder = Instantiate(Boulder,new Vector3(14,-3.5f,0),Quaternion.identity);
            //new_Boulder.transform.position = transform.position + new Vector3(14, -3, 0);
            Destroy(new_Boulder, 10);
            timer = 0;
        }
        if (timer > maxTimeTunnel)
        {
            GameObject new_tunnel = Instantiate(tunnel,new Vector3(14,-3.5f,0),Quaternion.identity);
            //new_Boulder.transform.position = transform.position + new Vector3(14, -3, 0);
            Destroy(new_tunnel, 10);
            timer = 0;
        }
         if (timer > maxTimeHyena)
        {
            GameObject new_hyena = Instantiate(Hyena,new Vector3(14,-3.5f,0),Quaternion.identity);
            //new_Boulder.transform.position = transform.position + new Vector3(14, -3, 0);
            Destroy(new_hyena, 10);
            timer = 0;
        }
         if (timer > maxTimePond)
        {
            GameObject new_pond = Instantiate(tunnel,new Vector3(14,-3.5f,0),Quaternion.identity);
            //new_Boulder.transform.position = transform.position + new Vector3(14, -3, 0);
            Destroy(new_pond, 10);
            timer = 0;
        }
         if (timer > maxTimeTree)
        {
            GameObject new_tree = Instantiate(tunnel,new Vector3(14,-3.5f,0),Quaternion.identity);
            //new_Boulder.transform.position = transform.position + new Vector3(14, -3, 0);
            Destroy(new_tree, 10);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
