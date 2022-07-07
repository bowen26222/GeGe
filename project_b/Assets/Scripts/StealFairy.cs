using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StealFairy : MonoBehaviour
{
    public bool isPlayerIn = false;
    public bool isBoxIn = false;
    public float sumTime;
    public float curTime;
    public GameObject WM;
    
    // Start is called before the first frame update
    void Start()
    {
        curTime = sumTime;
        WM.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayerIn == false && isBoxIn == true)
        {
            curTime -= Time.deltaTime;
        }
        else
        {
            curTime = sumTime;
        }
        if(curTime < 0 && WM.active == true)
        {
            WM.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && isPlayerIn == false)
        {
            isPlayerIn = true;
        }
        if (other.gameObject.CompareTag("onlybox") && isBoxIn == false)
        {
            isBoxIn = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && isPlayerIn == true)
        {
            isPlayerIn = false;
        }
        if (other.gameObject.CompareTag("onlybox") && isBoxIn == true)
        {
            isBoxIn = false;
        }
    }
}
