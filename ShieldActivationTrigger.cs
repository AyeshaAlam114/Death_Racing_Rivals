
using UnityEngine;

public class ShieldActivationTrigger : MonoBehaviour
{
    public static bool shield=false;
    public GameObject effect;
    
    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
        {
            shield = true;
            Invoke("TimeDelay", 20f);
          

        }
    }
    void OnTriggerExit(Collider target)
    {
        if (target.tag == "Player")
        {
            effect.SetActive(false);


        }
    }
    void TimeDelay()
    {
        shield = false;
    }
}
