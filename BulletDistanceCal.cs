using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDistanceCal : MonoBehaviour
{
    float distfromplayer;
    float distfromenemy;
    GameObject player;
    GameObject tank;
    public float angleBetween = 0.0f;
    public static bool enemyvalue = false;
    public static bool playervalue=false;
    public static bool tankvaluetoplayer = false;
    public static bool tankvaluetoenemy = false;
    public static bool playertotank = false;
    public static bool playertoenemy = false;
    public static string hitedenemyfromtank = null;
    public static string hitedenemyfromplayer = null;
    GameObject enemyhitfromtank;
    GameObject enemyhitfromplayer;
  


    private void Update()
    {
        float step = 10f * Time.deltaTime;
        player = GameObject.FindGameObjectWithTag("Player");
        tank= GameObject.FindGameObjectWithTag("tank");


        enemyhitfromtank = GameObject.Find(hitedenemyfromtank);
        enemyhitfromplayer = GameObject.Find(hitedenemyfromplayer);
       
        if (enemyvalue == true)
        {
            distfromplayer = Vector3.Distance(player.transform.position, this.transform.position);
            //if (distfromplayer <= 10)
            {
                this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, step);
                // this.transform.position = transform.forward;
                // Vector3 targetDir = player.transform.position - this.transform.position;
                //angleBetween = Vector3.Angle(transform.forward, targetDir);
                Debug.Log("bullet reaced to player from enemy // BulletDistanceCal");
                //Destroy(this.gameObject);
            }
            enemyvalue = false;



        }
        if (playervalue == true)
        {
            
            

            if (playertoenemy == true)
            {
                distfromenemy = Vector3.Distance(enemyhitfromplayer.transform.position, this.transform.position);
               // if (distfromenemy <= 10)
                {
                    this.transform.position = Vector3.MoveTowards(this.transform.position, enemyhitfromplayer.transform.position, step);
                    // this.transform.position = transform.forward;
                    // Vector3 targetDir = player.transform.position - this.transform.position;
                    //angleBetween = Vector3.Angle(transform.forward, targetDir);
                    Debug.Log("bullet reaced to enemy from player // BulletDistanceCal");
                    //Destroy(this.gameObject);
                }
               
                playertoenemy = false;
               
            }
            if (playertotank == true)
            {
                distfromenemy = Vector3.Distance(tank.transform.position, this.transform.position);
                //if (distfromenemy <= 10)
                {
                    this.transform.position = Vector3.MoveTowards(this.transform.position, tank.transform.position, step);
                    // this.transform.position = transform.forward;
                    // Vector3 targetDir = player.transform.position - this.transform.position;
                    //angleBetween = Vector3.Angle(transform.forward, targetDir);
                    Debug.Log("bullet reaced to tank // BulletDistanceCal");
                    //Destroy(this.gameObject);
                }
                
                playertotank = false;
               
            }
            playervalue = false;
           

        }
        if (tankvaluetoenemy == true)
        {
            distfromenemy = Vector3.Distance(enemyhitfromtank.transform.position, this.transform.position);
           // if (distfromenemy <= 10)
            {
                this.transform.position = Vector3.MoveTowards(this.transform.position, enemyhitfromtank.transform.position, step);
                // this.transform.position = transform.forward;
                // Vector3 targetDir = player.transform.position - this.transform.position;
                //angleBetween = Vector3.Angle(transform.forward, targetDir);
                Debug.Log("bullet reaced to enemy from tank // BulletDistanceCal");
                //Destroy(this.gameObject);
            }
            tankvaluetoenemy = false;
           
        }
        if (tankvaluetoplayer == true)
        {
            distfromplayer = Vector3.Distance(player.transform.position, this.transform.position);
           // if (distfromplayer <= 10)
            {
                this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, step);
                // this.transform.position = transform.forward;
                // Vector3 targetDir = player.transform.position - this.transform.position;
                //angleBetween = Vector3.Angle(transform.forward, targetDir);
                Debug.Log("bullet reaced to player from tank // BulletDistanceCal");
                //Destroy(this.gameObject);
            }
            tankvaluetoplayer = false;
           
        }

        


    }

}
