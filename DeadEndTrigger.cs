using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadEndTrigger : MonoBehaviour
{
    public GameObject deadend;
   void Start()
    {
        //deadend = GameObject.FindGameObjectWithTag("deadend");
    }
  void OnTriggerEnter(Collider target)
    {
        float y = 61.15f;
       
        if (target.tag == "Player")
        {

            deadend.transform.position = new Vector3(this.transform.position.x, y, this.transform.position.z);
            Debug.Log("deadendtrigger");
        }
        if (target.tag == "Enemy")
        {

            deadend.transform.position = new Vector3(this.transform.position.x, y, this.transform.position.z);
            Debug.Log("deadendtrigger");
        }
        if (target.tag == "tank")
        {

            deadend.transform.position = new Vector3(this.transform.position.x, y, this.transform.position.z);
            Debug.Log("deadendtrigger");
        }

    }
}
