using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject button;
    public GameObject Man_Player;
      public GameObject Horse;
        public GameObject Bird;
          public GameObject Lion;
            public GameObject Snake;
    
    // Start is called before the first frame update
   
     public void On_Click()
    {
        Instantiate(Man_Player, new Vector3(0, 0, -1), Quaternion.identity);
        button.SetActive(false);
    }
    public void On_ClickHorse()
    {
        Horse.transform.position=Man_Player.transform.position;
        Man_Player.SetActive(false);
        Horse.SetActive(true);
    }
    
}
