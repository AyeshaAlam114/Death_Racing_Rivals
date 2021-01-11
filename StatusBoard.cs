using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusBoard : MonoBehaviour
{
    public GameObject selectedLevel;
    public GameObject selectedView;
    public GameObject selectedCar;
    public GameObject totalPoints;
    public GameObject weaponStatus;
    public GameObject shieldStatus;

    string selectedLevelST;
    string selectedViewST;
    string selectedCarST;
    int totalPointsInt;
  
   


    // Update is called once per frame
    void Update()
    {
        //selected level status
        selectedLevelST = PlayerPrefs.GetString("SelectedLevel");
        selectedLevel.GetComponent<Text>().text = selectedLevelST;

        //selected view status
        selectedViewST = PlayerPrefs.GetString("SelectedScene");
        if (selectedViewST == "CityView")
        {
            selectedView.GetComponent<Text>().text = "City";
        }
        if (selectedViewST == "ForestView")
        {
            selectedView.GetComponent<Text>().text = "Forest";
        }
        if (selectedViewST == "IndustrialView")
        {
            selectedView.GetComponent<Text>().text = "Industrial";
        }


        //selected car status
        selectedCarST = PlayerPrefs.GetString("SelectedCar");
        selectedCar.GetComponent<Text>().text = selectedCarST;
      
        //total points status
        totalPointsInt = PlayerPrefs.GetInt("TotalPoints");
        totalPoints.GetComponent<Text>().text = totalPointsInt.ToString();

        //weapon status
        if (WeaponActivationTrigger.weapons == true)
        {
            weaponStatus.GetComponent<Text>().text = "Active";
        }
        else if (WeaponActivationTrigger.weapons == false)
        {
            weaponStatus.GetComponent<Text>().text = "Deactive";
        }

        //shield status
        if (ShieldActivationTrigger.shield == true)
        {
            shieldStatus.GetComponent<Text>().text = "Active";
        }
        else if (ShieldActivationTrigger.shield == false)
        {
            shieldStatus.GetComponent<Text>().text = "Deactive";
        }
    }
}
