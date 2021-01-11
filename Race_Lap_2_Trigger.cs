
using UnityEngine;
using UnityEngine.UI;

public class Race_Lap_2_Trigger : MonoBehaviour
{

    int enemycount = 0;
    int playerposition = 0;
    // int performanceReward;
    // int raceReward;
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
        /* if (target.gameObject.tag == "Enemy")
         {
             enemycount++;
             Debug.Log(enemycount);
         }*/
        if (target.gameObject.tag == "Player")
        {
            //for player positions
            //  playerposition = enemycount + 1;
              PlayerPrefs.SetInt("PlayerPosition", 0);
              // a.text = PlayerPrefs.GetInt("PlayerPosition").ToString();
             // Debug.Log("player position" + playerposition);
            
            //for rewards and results






            Race_Lap_1_Trigger.performanceReward += 5000;
            Race_Lap_1_Trigger.raceReward += 10000;
            PlayerPrefs.SetInt("PerformanceReward", 5000);
            PlayerPrefs.SetInt("RaceReward", 10000);
            int totalPoints = Race_Lap_1_Trigger.performanceReward + Race_Lap_1_Trigger.raceReward;
            PlayerPrefs.SetInt("TotalPoints", totalPoints);
            PlayerPrefs.SetInt("CompletedTier", 2);
            Debug.Log("lapcount at lap 2 trigger level====" + lap_Identifier.lapcount);
            //rewardspannel active
            // rewardspannel.SetActive(true);
            rewardspannel.SetActive(true);
            Debug.Log("rewards pannel of lap 2 should show");
            Time.timeScale = 0f;
            lap_Identifier.lapcount = 3;

        }

    }
}
