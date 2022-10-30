using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CapsuleCollider2D sc = gameObject.AddComponent(typeof(CapsuleCollider2D)) as CapsuleCollider2D;
    }
}
