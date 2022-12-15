using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public TMPro.TMP_Text text;
    public GameObject cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        text.text = cam.transform.position.ToString();
    }
}
