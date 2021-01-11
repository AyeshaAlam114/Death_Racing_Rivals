using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponActivationTrigger : MonoBehaviour
{
    public static bool weapons=false;
    public GameObject effect;
   void OnTriggerExit(Collider target)
    {
        if (target.tag == "Player")
        {
            weapons = true;
            effect.SetActive(false);

        }
       
    }
   
}
