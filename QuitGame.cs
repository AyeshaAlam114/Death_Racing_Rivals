
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{

    public GameObject quitpannel;

    private AsyncOperation async;
    public void Quit()
    {
       quitpannel.SetActive(true);
        Time.timeScale = 0f;

    }
    public void QuitYes()
    {

       

        MainMenu.backtomenu = true;
        SceneManager.LoadScene("UI DRR");
        Time.timeScale = 1f;

    }
    public void QuitNo()
    {
       quitpannel.SetActive(false);
        Time.timeScale = 1f;

    }

    public void GameOverYes()
    {
        //load same scene again here

        //race start with selection
        string scene = PlayerPrefs.GetString("SelectedScene");
        string car = PlayerPrefs.GetString("SelectedRCCVehicle");
        // SceneManager.LoadScene(scene);
        async = SceneManager.LoadSceneAsync(scene);
        Time.timeScale = 1f;

    }
}
