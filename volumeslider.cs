using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeslider : MonoBehaviour
{

    public static float soundvalue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        soundvalue=this.GetComponent<Slider>().value;
        AudioListener.volume = soundvalue;
      

    }
    public void SoundSaveButton()
    {
        soundvalue *= 100;
        int soundInt = (int)soundvalue;
        PlayerPrefs.SetInt("Sound", soundInt);
    }
}
