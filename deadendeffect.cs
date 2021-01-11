using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deadendeffect : MonoBehaviour
{
    public GameObject blasteffect;
    GameObject imagelifeline;
    public GameObject gameOverpannel;
    float valueL;

    void Start()
    {
        imagelifeline = GameObject.FindGameObjectWithTag("lifeline");
       // gameOverpannel = GameObject.FindGameObjectWithTag("gameover");
        //gameOverpannel.SetActive(false);
    }
    void overtimegap()
    {
        Time.timeScale = 0f;
    }
    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
        {
            Instantiate(blasteffect, target.transform.position, target.transform.rotation);
            //target->lifeline->0
            imagelifeline.GetComponent<Image>().fillAmount = 0f;
            valueL = imagelifeline.GetComponent<Image>().fillAmount;
            valueL *= 100;
            int lifeline = (int)valueL;
            //store playerpref
            PlayerPrefs.SetInt("LifeLine", lifeline);

            Debug.Log("lifeline current value is =  " + lifeline);
            Debug.Log("deadend effect on player and life line ->0");

            ///gameover pannel true;
            gameOverpannel.SetActive(true);
            
            Invoke("overtimegap", 2f);
        }
        if (target.tag == "Enemy")
          {
              Instantiate(blasteffect, target.transform.position, target.transform.rotation);
              //target->lifeline->0
              Debug.Log("deadend effect on enemy");
          }
         if (target.tag == "tank")
          {
              Instantiate(blasteffect, target.transform.position, target.transform.rotation);
              //target->lifeline->0
              Debug.Log("deadend effect on tank");
          }
      
    }
}
