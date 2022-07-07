using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrickDoor : MonoBehaviour
{
    public GameObject[] door = new GameObject[2];

    public GameObject anotherPart;
    public bool isTriggered;
    
    // Start is called before the first frame update
    void Start()
    {
        door[0].SetActive(false);
        door[1].SetActive(false);
        anotherPart.SetActive(true);
        isTriggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && isTriggered == false)
        {
            door[0].SetActive(true);
            anotherPart.SetActive(false);
            isTriggered = true;
        }
    }
}
