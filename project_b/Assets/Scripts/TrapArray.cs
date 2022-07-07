using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapArray : MonoBehaviour
{
    public GameObject[] traps = new GameObject[5];
    public float turnTime;
    float curTime;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            traps[i].SetActive(false);
        }
        traps[0].SetActive(true);
        traps[2].SetActive(true);
        traps[4].SetActive(true);
        curTime = turnTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (curTime > 0)
        {
            curTime -= Time.deltaTime;
        }
        else
        {
            if (traps[0].active == true)
            {
                traps[0].SetActive(false);
                traps[2].SetActive(false);
                traps[4].SetActive(false);
                traps[1].SetActive(true);
                traps[3].SetActive(true);
            }
            else
            {
                traps[0].SetActive(true);
                traps[2].SetActive(true);
                traps[4].SetActive(true);
                traps[1].SetActive(false);
                traps[3].SetActive(false);
            }
            curTime = turnTime;
        }
    }
}
