﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class contadorTexto : MonoBehaviour
{
    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        txt.text="Cubos Recolectados: " + GlobalVariables.CubosRecolectados;
    }
}
