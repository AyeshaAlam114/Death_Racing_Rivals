using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCount : MonoBehaviour
{
    public GameObject[] bulletarray;
    int arraycount;
    GameObject bullet;

    void Start()
    {
        arraycount = 0;
       
        //bullet = GameObject.FindGameObjectWithTag("bullet");
        bulletarray = new GameObject[10];
    }

   

    // Update is called once per frame
    void Update()
    {
        if (BulletDistanceCal.playervalue == true)
        {

            bulletarray[arraycount] = Gun.bullett;
            Debug.Log(arraycount);
            arraycount+=1;
            if (arraycount >= 10)
            {
                foreach (GameObject val in bulletarray)
                {
                    Destroy(val);
                }
            }
        }
    }
}
