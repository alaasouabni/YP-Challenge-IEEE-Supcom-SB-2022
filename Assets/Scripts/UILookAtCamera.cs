using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILookAtCamera : MonoBehaviour
{
    private GameObject cam;
    void Start(){
        cam = gameObject;
    }
    void LateUpdate() {
        transform.LookAt(cam.transform);
        
    }
}
