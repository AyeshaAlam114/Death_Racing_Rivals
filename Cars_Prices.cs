
using UnityEngine;
using UnityEngine.UI;

public class Cars_Prices : MonoBehaviour
{
    GameObject Car;
    public GameObject selectbutton;
    public GameObject purchasebuttonCar3;
    public GameObject purchasebuttonCar4;

    public GameObject car3price;
    public GameObject car4price;
    public GameObject car3pricetext;
    public GameObject car4pricetext;

    public GameObject tiger;
    public GameObject panzer;
    public GameObject legion;
    public GameObject arrow;
    public GameObject priceTag;
    public static int price = 0;
    string priceSt;


    // Update is called once per frame
    void Update()
    {
        Car = GameObject.FindGameObjectWithTag("Player");

        if (Car.name == "Body_23" || Car.name == "Wheel_Back_L")//car 1
        {
            // Car.GetComponent<CarUnlock>().status = true;
            if (CarUnlock.status == true && CarUnlock.carname == "Car 1(Clone)")
            {
                tiger.SetActive(true);
                panzer.SetActive(false);
                legion.SetActive(false);
                arrow.SetActive(false);

                selectbutton.SetActive(true);
                purchasebuttonCar3.SetActive(false);
                purchasebuttonCar4.SetActive(false);

                priceTag.SetActive(false);
                car3price.SetActive(false);
                car4price.SetActive(false);

            }
            if (CarUnlock.status == false && CarUnlock.carname == "Car 1(Clone)")
            {
                tiger.SetActive(true);
                panzer.SetActive(false);
                legion.SetActive(false);
                arrow.SetActive(false);

                selectbutton.SetActive(true);
                purchasebuttonCar3.SetActive(false);
                purchasebuttonCar4.SetActive(false);

                priceTag.SetActive(false);
                car3price.SetActive(false);
                car4price.SetActive(false);

            }

        }
        if (Car.name == "Car 2(Clone)")//car 2
        {
            if (CarUnlock.status == true && CarUnlock.carname == "Car 2(Clone)")
            {
                tiger.SetActive(false);
                panzer.SetActive(true);
                legion.SetActive(false);
                arrow.SetActive(false);

                selectbutton.SetActive(true);
                purchasebuttonCar3.SetActive(false);
                purchasebuttonCar4.SetActive(false);

                priceTag.SetActive(false);

                car3price.SetActive(false);
                car4price.SetActive(false);

            }
            if (CarUnlock.status == false && CarUnlock.carname == "Car 2(Clone)")
            {
                tiger.SetActive(false);
                panzer.SetActive(true);
                legion.SetActive(false);
                arrow.SetActive(false);

                selectbutton.SetActive(true);
                purchasebuttonCar3.SetActive(false);
                purchasebuttonCar4.SetActive(false);

                priceTag.SetActive(false);

                car3price.SetActive(false);
                car4price.SetActive(false);

            }

        }
        if (Car.name == "Car_13_Interior_B")//car 3
        {
            if (CarUnlock.status3 == true && CarUnlock.carname == "Car 3(Clone)")
            {
                tiger.SetActive(false);
                panzer.SetActive(false);
                legion.SetActive(true);
                arrow.SetActive(false);

                selectbutton.SetActive(false);
                purchasebuttonCar3.SetActive(true);
                purchasebuttonCar4.SetActive(false);

                priceTag.SetActive(true);

                car3price.SetActive(true);
                car4price.SetActive(false);
                priceSt = car3pricetext.GetComponent<Text>().text;
                price = int.Parse(priceSt);
                Debug.Log(price);
            }
            if (CarUnlock.status3 == false && CarUnlock.carname == "Car 3(Clone)")
            {

                tiger.SetActive(false);
                panzer.SetActive(false);
                legion.SetActive(true);
                arrow.SetActive(false);

                selectbutton.SetActive(true);
                purchasebuttonCar3.SetActive(false);
                purchasebuttonCar4.SetActive(false);

                car3price.SetActive(false);
                car4price.SetActive(false);
                priceSt = car3pricetext.GetComponent<Text>().text;
                price = int.Parse(priceSt);
                Debug.Log(price);
            }

        }
        if (Car.name == "silencer001")//car 4
        {
            if (CarUnlock.status4 == true && CarUnlock.carname == "Car4(Clone)")
            {
                tiger.SetActive(false);
                panzer.SetActive(false);
                legion.SetActive(false);
                arrow.SetActive(true);

                selectbutton.SetActive(false);
                purchasebuttonCar3.SetActive(false);
                purchasebuttonCar4.SetActive(true);

                priceTag.SetActive(true);

                car3price.SetActive(false);
                car4price.SetActive(true);
                priceSt = car4pricetext.GetComponent<Text>().text;
                price = int.Parse(priceSt);
                Debug.Log(price);
            }
            if (CarUnlock.status4 == false && CarUnlock.carname == "Car4(Clone)")
            {
                tiger.SetActive(false);
                panzer.SetActive(false);
                legion.SetActive(false);
                arrow.SetActive(true);

                selectbutton.SetActive(true);
                purchasebuttonCar3.SetActive(false);
                purchasebuttonCar4.SetActive(false);

                car3price.SetActive(false);
                car4price.SetActive(false);
                priceSt = car4pricetext.GetComponent<Text>().text;
                price = int.Parse(priceSt);
                Debug.Log(price);
            }

        }
        Debug.Log(Car.name);
    }
}
