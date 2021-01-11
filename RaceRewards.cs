using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceRewards : MonoBehaviour
{
    public GameObject resultpannel;
    public GameObject rewardpannel;
    public GameObject tier;
    public GameObject performancereward;
    public GameObject racereward;
    int tierInt;
    int prInt;
    int rrInt;


    void Update()
    {

        tierInt = PlayerPrefs.GetInt("CompletedTier");
        Debug.Log("tier at reward level" + tierInt);
        tier.GetComponent<Text>().text = tierInt.ToString();


        prInt = PlayerPrefs.GetInt("PerformanceReward");
        performancereward.GetComponent<Text>().text = prInt.ToString();


        rrInt = PlayerPrefs.GetInt("RaceReward");
        racereward.GetComponent<Text>().text = rrInt.ToString();
    }

    public void rewardNext()
    {
        resultpannel.SetActive(true);
        rewardpannel.SetActive(false);
    }
}
