
using UnityEngine;
using UnityEngine.UI;

public class ScoresDRR : MonoBehaviour
{
   
    public float score;
    int scoreInt;
    public GameObject KMHLabel;
    string speed;
    int speedInt;
  
  

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        speed = KMHLabel.GetComponent<Text>().text;
        speedInt = int.Parse(speed);
         if (speedInt >= 30 && Time.timeScale == 1f)
        {
            score = score + 1;// 10 * Time.deltaTime;
            scoreInt = (int)score;
            this.GetComponent<Text>().text = scoreInt.ToString();

           
            PlayerPrefs.SetInt("Scores", scoreInt);
        }
       
    }
}
