using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Race_Lap_3_Trigger : MonoBehaviour
{

    int enemycount = 0;
    int playerposition = 0;
    // int performanceReward;
    //int raceReward;
    public GameObject rewardspannel;
    // public Text a;
    // Start is called before the first frame update
    void Start()
    {
        enemycount = 0;
        playerposition = 0;

    }


    void OnTriggerExit(Collider target)
    {
        if (target.gameObject.tag == "Enemy")
        {
            enemycount++;
            Debug.Log(enemycount);
        }
        if (target.gameObject.tag == "Player")
        {
            //for player positions
            playerposition = enemycount + 1;
            PlayerPrefs.SetInt("PlayerPosition", playerposition);
            // a.text = PlayerPrefs.GetInt("PlayerPosition").ToString();
            Debug.Log("player position" + playerposition);

            //for rewards and results




            Race_Lap_1_Trigger.performanceReward += 20000;
            Race_Lap_1_Trigger.raceReward += 50000;
            PlayerPrefs.SetInt("PerformanceReward", 20000);
            PlayerPrefs.SetInt("RaceReward", 50000);
            int totalPoints = Race_Lap_1_Trigger.performanceReward + Race_Lap_1_Trigger.raceReward;
            PlayerPrefs.SetInt("TotalPoints", totalPoints);

            PlayerPrefs.SetInt("CompletedTier", lap_Identifier.lapcount);
            Debug.Log("lapcount at lap 3 trigger level====" + lap_Identifier.lapcount);


            //rewardspannel active
            rewardspannel.SetActive(true);
            lap_Identifier.lapcount = 1;
            Time.timeScale = 0f;
        }

    }
}
