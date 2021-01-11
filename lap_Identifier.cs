
using UnityEngine;

public class lap_Identifier : MonoBehaviour
{
    public GameObject lap1;
    public GameObject lap2;
    public GameObject lap3;
    public static int lapcount;
   
    void Start()
    {
        lapcount = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (lapcount == 1)
        {
            lap1.SetActive(true);
            lap2.SetActive(false);
            lap3.SetActive(false);
        }
        if (lapcount == 2)
        {
            lap1.SetActive(false);
            lap2.SetActive(true);
            lap3.SetActive(false);
        }
        if (lapcount == 3)
        {
            lap1.SetActive(false);
            lap2.SetActive(false);
            lap3.SetActive(true);
        }
    }
}
