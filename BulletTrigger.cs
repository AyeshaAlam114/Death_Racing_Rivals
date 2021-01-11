﻿
using UnityEngine;
using UnityEngine.UI;

public class BulletTrigger : MonoBehaviour
{
    GameObject imagelifeline;
    GameObject gameOverpannel;
    float valueL;

    void Start()
    {
        imagelifeline = GameObject.FindGameObjectWithTag("lifeline");
        gameOverpannel= GameObject.FindGameObjectWithTag("gameover");

    }
    void OnCollisionEnter(Collision target)
    {
       

        if (target.gameObject.tag == "bullet")
        {
            if (this.gameObject.tag == "Player")
            {
                
                Destroy(target.gameObject);
              /*  if (imagelifeline.GetComponent<Image>().fillAmount > 0)
                {
                    //gameOverpannel.SetActive(false);
                    imagelifeline.GetComponent<Image>().fillAmount -= 0.01f;
                    valueL = imagelifeline.GetComponent<Image>().fillAmount;
                    valueL *= 100;
                    int lifeline = (int)valueL;
                    //store playerpref
                    PlayerPrefs.SetInt("LifeLine", lifeline);
                   
                    Debug.Log("lifeline current value is =  " + lifeline);
                    Debug.Log("player damaged by bullet//BulletTrigger");
                }
                    
                else
                {
                    ///gameover pannel true;
                    gameOverpannel.SetActive(true);
                    Time.timeScale = 0f;
                }*/
            }
            if (this.gameObject.tag == "Enemy")
            {
                
                Destroy(target.gameObject);
                
                Debug.Log("enemy damaged by bullet//BulletTrigger");
            }
            if (this.gameObject.tag == "tank")
            {
                
                Destroy(target.gameObject);
               
                Debug.Log("tank damaged by bullet//BulletTrigger");
            }

        }

    }
    void Update()
    {
       
       // valueL = imagelifeline.GetComponent<Image>().fillAmount;
       // int lifeline = (int)valueL*100;
        //store playerpref
       // PlayerPrefs.SetInt("LifeLine", lifeline);
       // int ll=PlayerPrefs.GetInt("LifeLine");
        //Debug.Log("lifeline current value is =  "+ll);
    }
}

