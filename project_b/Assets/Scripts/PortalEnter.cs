using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalEnter : MonoBehaviour
{
    int times = 0;
    public Transform exitDoor;
    public Transform playerTrans;

    // Start is called before the first frame update
    void Start()
    {
        times = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && times == 0)
        {
            times = 1;
            playerTrans.position = exitDoor.position;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && times == 1)
        {
            times = 0;
        }
    }
}
