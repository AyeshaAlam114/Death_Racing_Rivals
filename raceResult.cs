
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class raceResult : MonoBehaviour
{
    public GameObject rewardspannel;
    public GameObject resultspannel;
    public GameObject lap1;
    public GameObject winningpannel;
    public GameObject position;
    public GameObject scores;
    public GameObject lifeline;
    public GameObject completedTier;
    public GameObject totalPoints;
    public GameObject tier2pannel;
    public GameObject tier3pannel;

    int positionInt;
    int scoresInt;
    int lifelineInt;
    int completedTierInt;
    int totalPointsInt;




    void Update()
    {


        positionInt = PlayerPrefs.GetInt("PlayerPosition");
        position.GetComponent<Text>().text = positionInt.ToString();


        scoresInt = PlayerPrefs.GetInt("Scores");
        scores.GetComponent<Text>().text = scoresInt.ToString();


        lifelineInt = PlayerPrefs.GetInt("LifeLine");
        lifeline.GetComponent<Text>().text = lifelineInt.ToString();


        completedTierInt = PlayerPrefs.GetInt("CompletedTier");
        Debug.Log("tier at result level" + completedTierInt);
        completedTier.GetComponent<Text>().text = completedTierInt.ToString();

        totalPointsInt = PlayerPrefs.GetInt("TotalPoints");
        totalPoints.GetComponent<Text>().text = totalPointsInt.ToString();
    }

    public void RaceNextButton()
    {
        Debug.Log("next lap pressed");
        if (completedTierInt == 1)
        {
            Debug.Log("tier 1 cmplete call for 2");
            Debug.Log("next lap is 2");
            rewardspannel.SetActive(false);
            resultspannel.SetActive(false);
            //PlayerPrefs.SetInt("CompletedTier", 2);
            Time.timeScale = 1f;
            //next tier 2 pannel active
            tier2pannel.SetActive(true);
            Invoke("lappanneldelay", 0.5f);



        }
        if (completedTierInt == 2)
        {
            Debug.Log("tier 2 cmplete call for 3");
            rewardspannel.SetActive(false);
            resultspannel.SetActive(false);
            //PlayerPrefs.SetInt("CompletedTier", 3);
            Time.timeScale = 1f;
            //next tier 3 pannel active
            tier3pannel.SetActive(true);
            Invoke("lappanneldelay", 0.5f);

        }
        if (completedTierInt == 3)
        {
            Debug.Log("tier 3 cmplete call for winning state");
            completedTierInt = 0;
            //lap1 true
            PlayerPrefs.SetInt("CompletedTier", completedTierInt);
            lap1.SetActive(true);
            Debug.Log("tier at after winning level==" + completedTierInt);
            //show winning pannel
            winningpannel.SetActive(true);
        }

    }
    void lappanneldelay()
    {
        tier2pannel.SetActive(false);
        tier3pannel.SetActive(false);

    }

    public void ResultMainMenuButton()
    {
        MainMenu.backtomenu = true;
        SceneManager.LoadScene("UI DRR");
    }
}

