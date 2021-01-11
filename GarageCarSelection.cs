using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageCarSelection : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharacter = 0;


    public void NextCar()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);

    }

    public void PreviousCar()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
    }

    public void SelectCar()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        // SceneManager.LoadScene("Windridge City Demo Scene 1");//city

    }
}
