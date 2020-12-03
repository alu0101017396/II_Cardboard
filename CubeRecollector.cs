using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRecollector : MonoBehaviour
{
    public GameObject CuboNuevo;

    void SpawnCube(){
        Vector3 position = new Vector3(Random.Range(-15.0F, 15.0F), Random.Range(0.5F, 2.5F), Random.Range(-15.0F, 15.0F));
        Instantiate (CuboNuevo, position, Quaternion.identity);
    }
    public void recolectarCubo() {
        GlobalVariables.CubosRecolectados++;
        SpawnCube();
        Destroy (this.gameObject);
    }
}
