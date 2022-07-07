using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingsAction : MonoBehaviour
{
    public CharacterData wingsState;
    public GameObject leftWingup;
    public GameObject leftWingdown;
    public GameObject rightWingup;
    public GameObject rightWingdown;

    // Start is called before the first frame update
    void Start()
    {
        if(wingsState.LeftWing==true)
        {
            leftWingup.SetActive(true);
            leftWingdown.SetActive(false);
        }
        else
        {
            leftWingdown.SetActive(true);
            leftWingup.SetActive(false);
        }

        if(wingsState.RightWing == true)
        {
            rightWingup.SetActive(true);
            rightWingdown.SetActive(false);
        }
        else
        {
            rightWingdown.SetActive(true);
            rightWingup.SetActive(false);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (wingsState.LeftWing == true)
        {
            leftWingup.SetActive(true);
            leftWingdown.SetActive(false);
        }
        else
        {
            leftWingdown.SetActive(true);
            leftWingup.SetActive(false);
        }

        if (wingsState.RightWing == true)
        {
            rightWingup.SetActive(true);
            rightWingdown.SetActive(false);
        }
        else
        {
            rightWingdown.SetActive(true);
            rightWingup.SetActive(false);
        }
    }
}
