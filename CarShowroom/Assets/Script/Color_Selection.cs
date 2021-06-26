using UnityEngine;
public class Color_Selection : MonoBehaviour 
{
    public Material CarMaterial; 
 
    public void Car_Color_Red()
    {
        CarMaterial.color = UnityEngine.Color.red;
    }
    public void Car_Color_White()
    {
        CarMaterial.color = UnityEngine.Color.white;
    }
    public void Car_Color_Blue()
    {
        CarMaterial.color = UnityEngine.Color.blue;
    }
    public void Car_Color_Green()
    {
        CarMaterial.color = UnityEngine.Color.green;
    }
    public void Car_Color_Yellow()
    {
        CarMaterial.color = UnityEngine.Color.yellow;
    }
    public void Car_Color_Black()
    {
        CarMaterial.color = UnityEngine.Color.black;
    }
}
