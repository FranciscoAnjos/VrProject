using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Camera _maincam;
    

    void Start()
    {
        _maincam = Camera.main;
    }


    void Update()
    {
       transform.LookAt(_maincam.transform); 
    }
}
