using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject redLight;
    public GameObject greenLight;
    public bool isPassed = false;
    public float stopTime;
    public float curTime;
    
    // Start is called before the first frame update
    void Start()
    {
        isPassed = false;
        curTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPassed == true && curTime > 0)
        {
            curTime -= Time.deltaTime;
        }
        if(curTime < 0)
        {
            isPassed = false;
        }
        if(curTime > 0)
        {
            redLight.SetActive(true);
            greenLight.SetActive(false);
        }
        else
        {
            redLight.SetActive(false);
            greenLight.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && isPassed == false)
        {
            isPassed = true;
            curTime = stopTime;
        }
    }
}
