using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartButton : MonoBehaviour
{
   public TMP_Text scorePoints;
    public static int score=0;
   bool isOUT=false;
  string Current_player="MAN";
    
    public GameObject invisible;
    public GameObject Man_Player;
      public GameObject Horse;
        public GameObject Bird;
          public GameObject Lion;
            public GameObject Snake;
    private string CurrentScene="Level 2";
    private GameObject Mp;
    private GameObject Bp;
    private GameObject Sp;
    private GameObject Hp;
    private GameObject Lp;
    // Start is called before the first frame update
   
     void Start()
    {
       Mp=Instantiate(Man_Player, new Vector3(0, 0, -1), Quaternion.identity);
    }
    public void On_ClickHorse()
    {
      if(Current_player=="MAN")
      {
        Horse.transform.position=Man_Player.transform.position;
        Mp.SetActive(false);
        
      }
      if(Current_player=="SNAKE")
      {
        Horse.transform.position=Snake.transform.position;
        Sp.SetActive(false);
      }
      if(Current_player=="BIRD")
      {
        Horse.transform.position=Bird.transform.position;
        Bp.SetActive(false);
      }
      if(Current_player=="LION")
      {
        Horse.transform.position=Lion.transform.position;
      Lp.SetActive(false);
      }
      Hp=Instantiate(Horse, new Vector3(0, 0, -1), Quaternion.identity);
        Hp.SetActive(true);
        Current_player="HORSE";
    }
    public void On_ClickBird()
    {
       if(Current_player=="MAN")
      {
        Horse.transform.position=Man_Player.transform.position;
        Mp.SetActive(false);
      }
      if(Current_player=="SNAKE")
      {
        Horse.transform.position=Snake.transform.position;
        Sp.SetActive(false);
      }
      if(Current_player=="HORSE")
      {
        Horse.transform.position=Horse.transform.position;
        Hp.SetActive(false);
      }
      if(Current_player=="LION")
      {
        Horse.transform.position=Lion.transform.position;
        Lp.SetActive(false);
      }
       Bp=Instantiate(Bird, new Vector3(0, 0, -1), Quaternion.identity);
       Bp.SetActive(true);
      Current_player="BIRD";
    }
    public void On_ClickSnake()
    {
       if(Current_player=="MAN")
      {
        Horse.transform.position=Man_Player.transform.position;
        Mp.SetActive(false);
      }
      if(Current_player=="BIRD")
      {
        Horse.transform.position=Bird.transform.position;
        Bp.SetActive(false);
      }
      if(Current_player=="HORSE")
      {
        Horse.transform.position=Horse.transform.position;
        Hp.SetActive(false);
      }
      if(Current_player=="LION")
      {
        Horse.transform.position=Lion.transform.position;
        Lp.SetActive(false);
      }
       Sp=Instantiate(Snake, new Vector3(0, -3, 0), Quaternion.identity);
       Sp.SetActive(true);
      Current_player="SNAKE";
    }
    public void On_ClickLion()
    {
       if(Current_player=="MAN")
      {
        Horse.transform.position=Man_Player.transform.position;
        Mp.SetActive(false);
      }
      if(Current_player=="BIRD")
      {
        Horse.transform.position=Bird.transform.position;
        Bp.SetActive(false);
      }
      if(Current_player=="HORSE")
      {
        Horse.transform.position=Horse.transform.position;
        Hp.SetActive(false);
      }
      if(Current_player=="SNAKE")
      {
        Horse.transform.position=Snake.transform.position;
        Sp.SetActive(false);
      }
       Lp=Instantiate(Lion, new Vector3(0, 0, -1), Quaternion.identity);
       Lp.SetActive(true);
      Current_player="LION";
    }
 void Update()
{
  invisible.transform.position = invisible.transform.position + new Vector3(100f * Time.deltaTime, 0, 0);
  scorePoints.text = (invisible.transform.position.x-397).ToString("0");
  score=int.Parse(scorePoints.text);
   
  if(score>5000)
  {
    if(CurrentScene=="Level 2")
    {
    SceneManager.LoadScene("level 3");
    CurrentScene="Level 3";
    }
   
  }
}
}
