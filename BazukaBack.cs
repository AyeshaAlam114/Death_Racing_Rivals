using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BazukaBack : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public GameObject Car;
    public GameObject bulletprefeb;
    RaycastHit hit;
   
    public GameObject bulletPosition;
    public GameObject effectPrefeb;
    bool fireDelay;


    GameObject effectedenemytank;
    GameObject effectedenemyfromplayer;

    public static GameObject bullett;
    void Start()
    {
        fireDelay = true;

    }
    // Update is called once per frame
    void Update()
    {
        if (WeaponActivationTrigger.weapons == true)
        {
            if (Car.tag == "Player")
            {
                if (Input.GetKey("7"))
                {
                    //PlayerShoot();
                    Vector3 bulletposition = bulletPosition.transform.position;
                    Instantiate(effectPrefeb, bulletposition, Quaternion.identity);
                    if (Physics.Raycast(Car.transform.position, Car.transform.forward, out hit, range))
                    {
                        Debug.Log(hit.transform.name);
                        Debug.Log("ray initiate from player but don't reached at enemy");

                        if (hit.transform.tag == "Enemy")
                        {

                            Debug.Log("ray reached enemy and now instantiate bullet");


                            BulletDistanceCal.playervalue = true;

                            BulletDistanceCal.playertoenemy = true;
                            effectedenemyfromplayer = hit.transform.gameObject;
                            BulletDistanceCal.hitedenemyfromplayer = effectedenemyfromplayer.name;


                            bullett = Instantiate(bulletprefeb, bulletposition, Quaternion.identity);
                            Instantiate(effectPrefeb, bulletposition, Quaternion.identity);



                        }
                        if (hit.transform.tag == "tank")
                        {

                            Debug.Log("ray reached tank and now instantiate bullet");
                            //Vector3 bulletposition = cube.transform.position;

                            BulletDistanceCal.playervalue = true;

                            BulletDistanceCal.playertotank = true;

                            Instantiate(bulletprefeb, bulletposition, Quaternion.identity);
                            Instantiate(effectPrefeb, bulletposition, Quaternion.identity);

                        }


                        Enemy enemy = hit.transform.GetComponent<Enemy>();
                        if (enemy != null)
                        {
                            enemy.TakeDamage(damage);
                            Debug.Log(damage);
                        }
                        Debug.Log("Hit by player");

                    }
                }

            }
            if (Car.tag == "Enemy")
            {
                if (fireDelay == true)
                {
                    //EnemyShoot();
                    Ray shootingRay = new Ray(Car.transform.position, Car.transform.forward);
                    Debug.DrawRay(Car.transform.position, Car.transform.forward * range);
                    if (Physics.Raycast(shootingRay, out hit, range))
                    {
                        Debug.Log("ray initiate from enemy but don't reached at player");
                        if (hit.transform.tag == "Player")
                        {
                            Debug.Log("ray reached player and now instantiate bullet");

                            BulletDistanceCal.enemyvalue = true;
                            Vector3 bulletposition = bulletPosition.transform.position;
                            Instantiate(bulletprefeb, bulletposition, Quaternion.identity);
                            Instantiate(effectPrefeb, bulletposition, Quaternion.identity);

                        }
                    }
                    Debug.Log("Hit by enemy");
                    fireDelay = false;
                }
                Invoke("FireDelay", 5f);
            }
            if (Car.tag == "tank")
            {
                if (TankTrigger.tankactive == true)
                {
                    if (fireDelay == true)
                    {
                        //TankShoot();
                        Ray shootingRay = new Ray(Car.transform.position, Car.transform.forward);
                        Debug.DrawRay(Car.transform.position, Car.transform.forward * range);
                        if (Physics.Raycast(shootingRay, out hit, range))
                        {
                            Debug.Log("ray initiate from tank but don't reached at any car");
                            if (hit.transform.tag == "Player")
                            {
                                Debug.Log("ray reached player from tank and now instantiate bullet");

                                Vector3 bulletposition = bulletPosition.transform.position;

                                BulletDistanceCal.tankvaluetoplayer = true;
                                Instantiate(effectPrefeb, bulletposition, Quaternion.identity);
                                Instantiate(bulletprefeb, bulletposition, Quaternion.identity);


                            }
                            if (hit.transform.tag == "Enemy")
                            {
                                Debug.Log("ray reached enemy from tank and now instantiate bullet");

                                Vector3 bulletposition = bulletPosition.transform.position;

                                BulletDistanceCal.tankvaluetoenemy = true;
                                effectedenemytank = hit.transform.gameObject;
                                BulletDistanceCal.hitedenemyfromtank = effectedenemytank.name;
                                Instantiate(effectPrefeb, bulletposition, Quaternion.identity);
                                Instantiate(bulletprefeb, bulletposition, Quaternion.identity);


                            }
                        }
                        Debug.Log("Hit by enemy");
                        fireDelay = false;
                    }
                    Invoke("FireDelay", 10f);
                }


            }
        }
    }

    void FireDelay()
    {
        fireDelay = true;
    }

}



