using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//含时间的门控制（基本同triggeredbutton1）
public class TriggeredButton2 : MonoBehaviour
{
    public float maintainTime;
    public GameObject objectToControl;
    bool isPushed;
    public string theTag;
    public bool startVanished = true;
    public bool isTimeup = true;
    float lastTime;

    // Start is called before the first frame update
    void Start()
    {
        isPushed = false;
        objectToControl.SetActive(!startVanished);
        isTimeup = true;
        lastTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(lastTime > 0)
        {
            lastTime -= Time.deltaTime;
        }
        else
        {
            isTimeup = true;
        }
        if (isTimeup == false)
        {
            objectToControl.SetActive(startVanished);
        }
        else
        {
            objectToControl.SetActive(!startVanished);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(theTag) && isPushed == false)
        {
            isPushed = true;
            //objectToControl.SetActive(startVanished);
            isTimeup = false;
            lastTime = maintainTime;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(theTag) && isPushed == true)
        {
            isPushed = false;
            //objectToControl.SetActive(!startVanished);
        }
    }
}
