using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Shield_label_switch : MonoBehaviour
{
    public GameObject weaponactive;
    public GameObject weapondeactive;
    public GameObject shieldactive;
    public GameObject shielddeactive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (WeaponActivationTrigger.weapons == true)
        {
            weaponactive.SetActive(true);
            weapondeactive.SetActive(false);

        }
        if (WeaponActivationTrigger.weapons == false)
        {
            weaponactive.SetActive(false);
            weapondeactive.SetActive(true);

        }
        if (ShieldActivationTrigger.shield == true)
        {
            shieldactive.SetActive(true);
            shielddeactive.SetActive(false);
        }
        if (ShieldActivationTrigger.shield == false)
        {
            shieldactive.SetActive(false);
            shielddeactive.SetActive(true);
        }
    }
}
