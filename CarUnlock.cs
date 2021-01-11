using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarUnlock : MonoBehaviour
{
   
    public bool locked;
    public static bool status;
    public static bool status3;
    public static bool status4;

    public static string carname;
    void Start()
    {
        status3 = true;
        status4 = true;
}
    void Update()
    {
       
      
            
        
       
        if (select_purchaseSwitch.car3b == false)
        {
            locked = false;
            status3 = locked;
        }

        if (select_purchaseSwitch.car4b == false)
        {
            locked = false;
            status4 = locked;
        }

        status = locked;
        carname = this.name;
       // PlayerPrefs.SetString("SelectedCar", carname);
        Debug.Log("car names at carunlock script ====" + carname);
       
    }
    

}
