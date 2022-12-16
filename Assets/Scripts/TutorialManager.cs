using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
        // Start is called before the first frame update
    public LineRenderer LR;
    public Transform[] points;
   void Start()
    {
        LR = GetComponent<LineRenderer>();
    }
    void Update(){
        for (int i = 0; i < points.Length; i++)
        {
         LR.SetPosition(i,points[i].position);   
        }
    }

    // Update is called once per frame
    void setUpLine(Transform[] points)
    {
        LR.positionCount = points.Length;
        this.points = points;
    }
}
