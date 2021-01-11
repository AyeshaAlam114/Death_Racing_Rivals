using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select_purchaseSwitch : MonoBehaviour
{

    public GameObject lowpricepannel;
    public static bool car3b = true;
    public static bool car4b = true;
    GameObject price;
    GameObject Car;
    public GameObject priceTag;


    // Update is called once per frame
    void Update()
    {


        Car = GameObject.FindGameObjectWithTag("Player");
        Debug.Log("car name at select_purchaseSwitch script@@@@@ " + Car.name);

    }
    public void Purchase3()
    {
        int totalpoints = PlayerPrefs.GetInt("TotalPoints");
        // int totalpoints = 2000;
        Debug.Log("purchase");
        Debug.Log(totalpoints);
        if (totalpoints >= Cars_Prices.price)
        {
            if (Car.name == "Car_13_Interior_B")
            {
                car3b = false;
            }
            totalpoints -= Cars_Prices.price;
            Cars_Prices.price = 0;
            PlayerPrefs.SetInt("TotalPoints", totalpoints);
            Debug.Log(totalpoints);
            Debug.Log(Cars_Prices.price);
            priceTag.SetActive(false);
        }
        if (totalpoints < Cars_Prices.price)
        {
            //low price notification shown
            lowpricepannel.SetActive(true);
            Invoke("LPDisable", 1f);
        }
    }
    public void Purchase4()
    {
        int totalpoints = PlayerPrefs.GetInt("TotalPoints");


        // int totalpoints = 2000;
        Debug.Log("purchase");
        Debug.Log(totalpoints);
        if (totalpoints >= Cars_Prices.price)
        {
            if (Car.name == "silencer001")
            {
                car4b = false;
            }

            totalpoints -= Cars_Prices.price;
            Cars_Prices.price = 0;
            PlayerPrefs.SetInt("TotalPoints", totalpoints);
            Debug.Log(totalpoints);
            Debug.Log(Cars_Prices.price);
            priceTag.SetActive(false);
        }
        if (totalpoints < Cars_Prices.price)
        {
            //low price notification shown
            lowpricepannel.SetActive(true);
            Invoke("LPDisable", 1f);
        }
    }
    void LPDisable()
    {
        lowpricepannel.SetActive(false);
    }
}
