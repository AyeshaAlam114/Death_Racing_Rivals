using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Image backimage;
    public GameObject startpannel;
    public GameObject watchTutorialpannel;
    public GameObject MainMenupannel;
    public GameObject garagepannel;
    public GameObject selectlevel;
    public GameObject statusboard;
    public GameObject rewardspannel;
    public GameObject resultspannel;
    public GameObject quitpannel;
    public GameObject settingspannel;
    public GameObject audiosettings;
    public GameObject controlssettings;
    public GameObject graphicssettings;
    public GameObject cityviewpannel;
    public GameObject forestviewpannel;
    public GameObject industrialviewpannel;
    private AsyncOperation async;
    public Slider slider;
    static MainMenu instance;

    public static bool backtomenu = false;

   

    void Start()
    {
        if (!backtomenu)
        {
            startpannel.SetActive(true);
            watchTutorialpannel.SetActive(false);
            MainMenupannel.SetActive(false);
            garagepannel.SetActive(false);
            selectlevel.SetActive(false);
            statusboard.SetActive(false);
            rewardspannel.SetActive(false);
            resultspannel.SetActive(false);
            settingspannel.SetActive(false);
            audiosettings.SetActive(false);
            controlssettings.SetActive(false);
            graphicssettings.SetActive(false);

            Invoke("WatchTutorial", 3f);
        }
        if(backtomenu)
        {
            startpannel.SetActive(false);
            watchTutorialpannel.SetActive(false);
            MainMenupannel.SetActive(true);
            garagepannel.SetActive(false);
            selectlevel.SetActive(false);
            statusboard.SetActive(false);
            rewardspannel.SetActive(false);
            resultspannel.SetActive(false);
            settingspannel.SetActive(false);
            audiosettings.SetActive(false);
            controlssettings.SetActive(false);
            graphicssettings.SetActive(false);
            backtomenu = false;
        }
      
    }

    void Update()
    {
        //loading slider
       if (async != null && !async.isDone)
        {

            if (!slider.gameObject.activeSelf)
                slider.gameObject.SetActive(true);

            slider.value = async.progress;

        }
        else
        {

            if (slider.gameObject.activeSelf)
                slider.gameObject.SetActive(false);

        }
    }
    public void WatchTutorial()
    {
        startpannel.SetActive(false);
        watchTutorialpannel.SetActive(true);
        MainMenupannel.SetActive(false);
        garagepannel.SetActive(false);
        selectlevel.SetActive(false);
        statusboard.SetActive(false);
        rewardspannel.SetActive(false);
        resultspannel.SetActive(false);
        settingspannel.SetActive(false);
        audiosettings.SetActive(false);
        controlssettings.SetActive(false);
        graphicssettings.SetActive(false);
    }
    public void Skip()
    {
        startpannel.SetActive(false);
        watchTutorialpannel.SetActive(false);
        MainMenupannel.SetActive(true);
        garagepannel.SetActive(false);
        selectlevel.SetActive(false);
        statusboard.SetActive(false);
        rewardspannel.SetActive(false);
        resultspannel.SetActive(false);
        settingspannel.SetActive(false);
        audiosettings.SetActive(false);
        controlssettings.SetActive(false);
        graphicssettings.SetActive(false);
    }
    public void MainMenuset()
    {
        startpannel.SetActive(false);
        watchTutorialpannel.SetActive(false);
        MainMenupannel.SetActive(true);
        garagepannel.SetActive(false);
        selectlevel.SetActive(false);
        statusboard.SetActive(false);
        rewardspannel.SetActive(false);
        resultspannel.SetActive(false);
        settingspannel.SetActive(false);
        audiosettings.SetActive(false);
        controlssettings.SetActive(false);
        graphicssettings.SetActive(false);
    }


    public void Garage()
   {

        SceneManager.LoadScene("Garage");//garage

     
    }

   public void SelectLevel()
   {
       startpannel.SetActive(false);
       watchTutorialpannel.SetActive(false);
       MainMenupannel.SetActive(false);
        garagepannel.SetActive(false);
       selectlevel.SetActive(true);
       statusboard.SetActive(false);
       rewardspannel.SetActive(false);
       resultspannel.SetActive(false);
        settingspannel.SetActive(false);
        audiosettings.SetActive(false);
        controlssettings.SetActive(false);
        graphicssettings.SetActive(false);
    }

   public void StartRace()
   {
        //race start with selection
        string scene = PlayerPrefs.GetString("SelectedScene");
        string car = PlayerPrefs.GetString("SelectedRCCVehicle");
       // SceneManager.LoadScene(scene);
        async = SceneManager.LoadSceneAsync(scene);
        Time.timeScale = 1f;

    }


   public void StatusBoard()
   {
       startpannel.SetActive(false);
       watchTutorialpannel.SetActive(false);
       MainMenupannel.SetActive(false);
        garagepannel.SetActive(false);
       selectlevel.SetActive(false);
       statusboard.SetActive(true);
       rewardspannel.SetActive(false);
       resultspannel.SetActive(false);
        settingspannel.SetActive(false);
        audiosettings.SetActive(false);
        controlssettings.SetActive(false);
        graphicssettings.SetActive(false);
    }


   public void Settings()
   {
       startpannel.SetActive(false);
       watchTutorialpannel.SetActive(false);
       MainMenupannel.SetActive(false);
        garagepannel.SetActive(false);
       selectlevel.SetActive(false);
       statusboard.SetActive(false);
       rewardspannel.SetActive(false);
       resultspannel.SetActive(false);
        settingspannel.SetActive(true);
        audiosettings.SetActive(false);
        controlssettings.SetActive(false);
        graphicssettings.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Quit()
    {
       
        quitpannel.SetActive(true);

    }
    public void QuitYes()
    {
        backimage.enabled = true;
        MainMenupannel.SetActive(true);
        quitpannel.SetActive(false);
        startpannel.SetActive(false);
        watchTutorialpannel.SetActive(false);
        garagepannel.SetActive(false);
        selectlevel.SetActive(false);
        statusboard.SetActive(false);
        rewardspannel.SetActive(false);
        resultspannel.SetActive(false);
        settingspannel.SetActive(false);
        audiosettings.SetActive(false);
        controlssettings.SetActive(false);
        graphicssettings.SetActive(false);
    }

    public void QuitNo()
    {
        
        quitpannel.SetActive(false);
    }

    public void BeginnerLevel()
    {
        // BackgroundMusic.SetActive(true);
        PlayerPrefs.SetString("SelectedLevel","Beginners Level");
        PlayerPrefs.SetString("SelectedScene","CityView");
        //view display pannel active
        cityviewpannel.SetActive(true);
        Invoke("Delay", 0.7f);



    }
    public void IntermediateLevel()
    {
        PlayerPrefs.SetString("SelectedLevel", "Intermediate Level");
        PlayerPrefs.SetString("SelectedScene", "ForestView");
        //view display pannel active
        forestviewpannel.SetActive(true);
        Invoke("Delay", 0.7f);

    }
    public void ExpertLevel()
    {
        PlayerPrefs.SetString("SelectedLevel", "Expert Level");
        PlayerPrefs.SetString("SelectedScene", "IndustrialView");
        //view display pannel active
        industrialviewpannel.SetActive(true);
        Invoke("Delay", 0.7f);


    }
    void Delay()
    {
        cityviewpannel.SetActive(false);
        forestviewpannel.SetActive(false);
        industrialviewpannel.SetActive(false);
    }

    public void AudioSettings()
    {
        startpannel.SetActive(false);
        watchTutorialpannel.SetActive(false);
        MainMenupannel.SetActive(false);
        garagepannel.SetActive(false);
        selectlevel.SetActive(false);
        statusboard.SetActive(false);
        rewardspannel.SetActive(false);
        resultspannel.SetActive(false);
        settingspannel.SetActive(false);
        audiosettings.SetActive(true);
        controlssettings.SetActive(false);
        graphicssettings.SetActive(false);
    }
    public void GraphicsSettings()
    {
        startpannel.SetActive(false);
        watchTutorialpannel.SetActive(false);
        MainMenupannel.SetActive(false);
        garagepannel.SetActive(false);
        selectlevel.SetActive(false);
        statusboard.SetActive(false);
        rewardspannel.SetActive(false);
        resultspannel.SetActive(false);
        settingspannel.SetActive(false);
        audiosettings.SetActive(false);
        controlssettings.SetActive(false);
        graphicssettings.SetActive(true);

    }
    public void ControlsSettings()
    {
        startpannel.SetActive(false);
        watchTutorialpannel.SetActive(false);
        MainMenupannel.SetActive(false);
        garagepannel.SetActive(false);
        selectlevel.SetActive(false);
        statusboard.SetActive(false);
        rewardspannel.SetActive(false);
        resultspannel.SetActive(false);
        settingspannel.SetActive(false);
        audiosettings.SetActive(false);
        controlssettings.SetActive(true);
        graphicssettings.SetActive(false);
    }

  
     public void Back()
    {
        startpannel.SetActive(false);
        watchTutorialpannel.SetActive(false);
        MainMenupannel.SetActive(false);
        garagepannel.SetActive(false);
        selectlevel.SetActive(false);
        statusboard.SetActive(false);
        rewardspannel.SetActive(false);
        resultspannel.SetActive(false);
        settingspannel.SetActive(true);
        audiosettings.SetActive(false);
        controlssettings.SetActive(false);
        graphicssettings.SetActive(false);
    }
    public void RewardNext()
    {
        startpannel.SetActive(false);
        watchTutorialpannel.SetActive(false);
        MainMenupannel.SetActive(false);
        garagepannel.SetActive(false);
        selectlevel.SetActive(false);
        statusboard.SetActive(false);
        rewardspannel.SetActive(false);
        resultspannel.SetActive(true);
        settingspannel.SetActive(false);
        audiosettings.SetActive(false);
        controlssettings.SetActive(false);
        graphicssettings.SetActive(false);
    }
}
