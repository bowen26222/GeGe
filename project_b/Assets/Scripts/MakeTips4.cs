using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeTips4 : MonoBehaviour
{
    public int times = 0;
    public GameObject dialogBox;
    public Text dialogText;
    public string dialogTitle;
    public bool isInside;
    public bool isTouched;

    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(false);
        isTouched = false;
        isInside = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isInside == true && isTouched == true)
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
            isTouched = true;
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
