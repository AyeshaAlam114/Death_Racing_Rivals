using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAcivatorTrigger : MonoBehaviour
{
    public GameObject tankprefeb;
    public Transform tankspawn;
   // public bool tank;
    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
        {
            Debug.Log("tankk apear");
            GameObject clone = Instantiate(tankprefeb, tankspawn.position, tankspawn.rotation);
        }
       
    }


}
