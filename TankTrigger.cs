using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTrigger : MonoBehaviour
{
    public GameObject tank;
    //Rigidbody tankR;
    public static bool tankactive=false;
    public GameObject effect;

    void Start()
    {
       // tank = GameObject.FindGameObjectWithTag("tank");
        //tankR = tank.GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
        {

            tank.SetActive(true);
            //  tankR.constraints=RigidbodyConstraints.None;
            tankactive = true;
        }
    }
    void OnTriggerExit(Collider target)
    {
        if (target.tag == "Player")
        {

            effect.SetActive(false);
            
        }
    }
}
