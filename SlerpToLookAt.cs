using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlerpToLookAt : MonoBehaviour
{
    //values that will be set in the Inspector
    public Transform Target;
    public Transform Player;
    public float RotationSpeed;
    public GameObject wayPoint;
    public RCC_AIWaypointsContainer a;

    //values for internal use
    private Quaternion _lookRotation;
    private Vector3 _direction;
    int i;
    float dist;
    //public List<Transform> array;
   

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Start()
    {
       
        i = 0;
       
   
        wayPoint = GameObject.FindGameObjectWithTag("WavepointsCity");
        a = wayPoint.GetComponent<RCC_AIWaypointsContainer>();
        Target = a.waypoints[i].transform;
        //}
    }

    // Update is called once per frame
    void Update()
    {

        dist = Vector3.Distance(Player.transform.position, a.waypoints[i].transform.position);

        if (dist<=10)
        {
            i = i + 1;
            Target = a.waypoints[i].transform;
        }
       
        Debug.Log(a.waypoints[i]);
        //find the vector pointing from our position to the target
            _direction = (Target.position - transform.position).normalized;

        //create the rotation we need to be in to look at the target
        _lookRotation = Quaternion.LookRotation(_direction);

        //rotate us over time according to speed until we are in the required rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * RotationSpeed);
    }
}
