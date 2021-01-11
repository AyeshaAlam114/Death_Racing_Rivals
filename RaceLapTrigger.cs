
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RaceLapTrigger : MonoBehaviour
{
  
   /*
    int enemycount=0;
    int playerposition=0;
    int performanceReward;
    int raceReward;
    public GameObject rewardspannel;
   // public Text a;
    // Start is called before the first frame update
    void Start()
    {
        enemycount = 0;
        playerposition = 0;
      
        
    }

   
    void OnTriggerEnter(Collider target)
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
            Debug.Log("player position"+playerposition);

            //for rewards and results
           
           
            
                
                performanceReward = 500;
                raceReward = 1000;
                PlayerPrefs.SetInt("PerformanceReward", performanceReward);
                PlayerPrefs.SetInt("RaceReward", raceReward);
                int totalPoints = performanceReward + raceReward;
                PlayerPrefs.SetInt("TotalPoints", totalPoints);
            PlayerPrefs.SetInt("CompletedTier", lap_Identifier.lapcount);
            Debug.Log("lapcount at lap 1 trigger level====" + lap_Identifier.lapcount);
            //rewardspannel active
            rewardspannel.SetActive(true);

            lap_Identifier.lapcount = 2;
         
        }
       
    }*/
}


