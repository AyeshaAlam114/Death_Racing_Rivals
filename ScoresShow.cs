
using UnityEngine;
using UnityEngine.UI;

public class ScoresShow : MonoBehaviour
{

    public GameObject Button;
    // Update is called once per frame
    void Update()
    {

        int scores = PlayerPrefs.GetInt("Scores");
        Debug.Log(scores);
        Button.GetComponent<Text>().text = scores.ToString();
        //Debug.Log(scores);

       
    }
}
