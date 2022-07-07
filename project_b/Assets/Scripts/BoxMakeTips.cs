using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxMakeTips : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public string dialogTitle;

    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("deatharea"))
        {
            dialogText.text = dialogTitle;
            dialogBox.SetActive(true);
        }
    }
}
