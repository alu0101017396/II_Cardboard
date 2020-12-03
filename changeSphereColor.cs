using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSphereColor : MonoBehaviour
{
    public void cambiarColor() {
        switch(GlobalVariables.ColorEsfera){
            case "Rojo": 
                GetComponent<Renderer>().material.color = Color.red;
                break;
            case "Azul":
                GetComponent<Renderer>().material.color = Color.blue;
                break;
            case "Verde":
                GetComponent<Renderer>().material.color = Color.green;
                break;
        }   
    }
}
