using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class spherecolor : MonoBehaviour
{
    public Button red_sphere;
    public Button blue_sphere;
    public Button green_sphere;
    // Start is called before the first frame update
    void Start()
    {
        red_sphere.onClick.AddListener(esferasRojas);
        blue_sphere.onClick.AddListener(esferasAzules);
        green_sphere.onClick.AddListener(esferasVerdes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void esferasRojas(){
        Debug.Log("Cambiando a color rojo");
        GlobalVariables.ColorEsfera = "Rojo";
    }

    void esferasAzules(){
        Debug.Log("Cambiando a color azul");
        GlobalVariables.ColorEsfera = "Azul";
    }

    void esferasVerdes(){
        Debug.Log("Cambiando a color verde");
        GlobalVariables.ColorEsfera = "Verde";
    }

}
