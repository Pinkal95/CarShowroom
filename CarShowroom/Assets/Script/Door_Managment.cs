using DG.Tweening;
using UnityEngine;
public class Door_Managment : MonoBehaviour
{
    public GameObject FrontLeftDoor;
    public GameObject FrontRightDoor;
    public GameObject BackLeftDoor;
    public GameObject BackRightDoor;
    public GameObject TruckDoor;
   
    private float OpeningAngle = 60;

    private bool isFLD;
    private bool isFRD;
    private bool isBLD;
    private bool isBRD;
    private bool isTD;
    
    public void FLD() //Open and Close Front Left Door
    {
        if (!isFLD)
        {
            FrontLeftDoor.transform.DOLocalRotate(new Vector3(0, OpeningAngle, 0), 0.5f); //Open the door
            isFLD = true;
        }
        else
        {
            FrontLeftDoor.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f); //Close the door
            isFLD = false;
        }
    }

    public void FRD() //Open and Close Front Right Door
    {
        if (!isFRD)
        {
            FrontRightDoor.transform.DOLocalRotate(new Vector3(0, -OpeningAngle, 0), 0.5f); //Open the door
            isFRD = true;
        }
        else
        {
            FrontRightDoor.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f); //Close the door 
            isFRD = false;
        }
    }
    public void BLD() //Open and Close Back Left Door
    {
        if (!isBLD)
        {
            BackLeftDoor.transform.DOLocalRotate(new Vector3(0, OpeningAngle, 0), 0.5f); //Open the door
            isBLD = true;
        }
        else
        {
            BackLeftDoor.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f); //Close the door
            isBLD = false;
        }
    }
    public void BRD() //Open and Close Back Right Door
    {
        if (!isBRD)
        {
            BackRightDoor.transform.DOLocalRotate(new Vector3(0, -OpeningAngle, 0), 0.5f); //Open the door
            isBRD = true;
        }
        else
        {
            BackRightDoor.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f); //Close the door 
            isBRD = false;
        }
    }
    public void TD() //Open and Close Truck Door.
    {
        if (!isTD)
        {
            TruckDoor.transform.DOLocalRotate(new Vector3(OpeningAngle, 0, 0), 0.5f); //Open the door
            isTD = true;
        }
        else
        {
            TruckDoor.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.5f); //Close the door
            isTD = false;
        }
    }
    
}
