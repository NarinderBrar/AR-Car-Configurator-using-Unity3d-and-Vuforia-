using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{
    public Color color1;
    public Color color2;
    public Color color3;

    public Material carBodyMaterial;

    private int carId;

    public GameObject[] cars;
    public string[] carNames;
    public string[] carDetails;

    public Text carNameText;
    public Text carDetailText;

    public Transform carsTf;
    private float scale = 0.2f;

    private int wheelId;
    public GameObject[] carWheelsA;
    public GameObject[] carWheelsB;
    public GameObject[] carWheelsC;

    public Slider slider;

    public void changeColor(int colorId)
    {
		switch( colorId )
		{
            case 1:
                carBodyMaterial.color = color1;
                break;
            case 2:
                carBodyMaterial.color = color2;
                break;
            case 3:
                carBodyMaterial.color = color3;
                break;
        }
    }

    public void changeCar()
    {
        cars[0].SetActive(false);
        cars[1].SetActive(false);
        cars[2].SetActive(false);

        carId++;

        if( carId == 3 )
            carId = 0;

        cars[carId].SetActive(true);
        
        carNameText.text = carNames[carId];
        carDetailText.text = carDetails[carId];
    }

    public void changeScale(float s)
    {
        scale += s;

        carsTf.localScale = new Vector3( scale, scale, scale);
    }

    public void changeWheel()
    {
		for( int i = 0; i < 3; i++ )
		{
            carWheelsA[i].SetActive(false);
            carWheelsB[i].SetActive( false );
            carWheelsC[i].SetActive( false );
        }

        wheelId++;

        if( wheelId == 3 )
            wheelId = 0;

        carWheelsA[wheelId].SetActive( true );
        carWheelsB[wheelId].SetActive( true );
        carWheelsC[wheelId].SetActive( true );
    }

    public void changeRotation()
    {
        carsTf.localRotation = Quaternion.Euler(0, -slider.value, 0);
    }

}
