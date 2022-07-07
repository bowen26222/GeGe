using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//特定情况的maketips，即被关住
public class MakeTips1 : MakeTips
{
    public TriggeredButton2 theButton;

    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isInside == true && theButton.isTimeup == true)
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
