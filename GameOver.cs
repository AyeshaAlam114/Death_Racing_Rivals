
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gameoverYES()
    {
        //race start with default selection
        string scene = PlayerPrefs.GetString("SelectedScene");
        string car = PlayerPrefs.GetString("SelectedRCCVehicle");
        SceneManager.LoadScene(scene);
        Time.timeScale = 1f;
    }
}
