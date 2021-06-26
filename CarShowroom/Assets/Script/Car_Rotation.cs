using UnityEngine;
public class Car_Rotation : MonoBehaviour
{
    public GameObject Car; 
    private float Speed = 20f; //Speed of the Car Rotation
    private bool isCR;
    public void CR()
    {
        if (!isCR)
        {
            gameObject.transform.GetComponent<Car_Rotation>().enabled = true;
            isCR = true;
        }
        else
        {
            gameObject.transform.GetComponent<Car_Rotation>().enabled = false;
            isCR = false;
        }

    }
    void Update()
    {
        Car.transform.Rotate(Vector3.up * (Speed * Time.deltaTime));
            
    }
}
