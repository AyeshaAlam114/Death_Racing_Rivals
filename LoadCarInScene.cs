using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCarInScene : MonoBehaviour
{
    public GameObject[] carsPrefabs;
    public Transform spawnPoint;
    //public Text label;


    // Start is called before the first frame update
    void Start()
    {


        int selectedCharacter = PlayerPrefs.GetInt("SelectedRCCVehicle");
        GameObject prefab = carsPrefabs[selectedCharacter];
        GameObject clone = Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
       // label.text = prefab.name;
    }

}
