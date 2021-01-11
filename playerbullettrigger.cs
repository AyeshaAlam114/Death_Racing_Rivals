using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerbullettrigger : MonoBehaviour
{
    GameObject imagelifeline;
    GameObject gameOverpannel;
    float valueL;

    void Start()
    {
        imagelifeline = GameObject.FindGameObjectWithTag("lifeline");
        gameOverpannel = GameObject.FindGameObjectWithTag("gameover");
        gameOverpannel.SetActive(false);

    }
    void Awake()
    {
       // gameOverpannel.SetActive(false);
    }
    void OnCollisionEnter(Collision target)
    {


        if (target.gameObject.tag == "enemybullet")
        {
            if (this.gameObject.tag == "Player")
            {

                Destroy(target.gameObject);
                if (ShieldActivationTrigger.shield == false)
                {
                    if (imagelifeline.GetComponent<Image>().fillAmount > 0)
                    {

                        imagelifeline.GetComponent<Image>().fillAmount -= 0.005f;
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
                    }
                }
                
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
}
