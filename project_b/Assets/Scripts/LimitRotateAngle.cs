using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitRotateAngle : MonoBehaviour
{
    public Rigidbody2D theObject;
    public float AngleLimited = 90;

    // Update is called once per frame
    void Update()
    {
        if(theObject.rotation>=AngleLimited)
        {
            theObject.rotation = AngleLimited;
        }
        if(theObject.rotation<=-AngleLimited)
        {
            theObject.rotation = -AngleLimited;
        }
    }
}
