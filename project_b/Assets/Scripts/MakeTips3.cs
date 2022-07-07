using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Õ‚¬Ù±ªÕµ
public class MakeTips3 : MakeTips
{
    public GameObject WM;
    
    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isInside == true && WM.active == false)
        {
            dialogText.text = dialogTitle;
            dialogBox.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && times == 0)
        {
            times = 1;
            isInside = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && times == 1)
        {
            times = 0;
            isInside = false;
            dialogBox.SetActive(false);
        }
    }
}
