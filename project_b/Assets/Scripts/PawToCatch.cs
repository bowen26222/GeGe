using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawToCatch : MonoBehaviour
{
    public CatchBox PlayerCatchBox;
    private void Awake()
    {
        PlayerCatchBox = GameObject.Find("Player").GetComponent<CatchBox>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "box"|| collision.gameObject.tag == "onlybox")
        {
            PlayerCatchBox.box = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == PlayerCatchBox.box)
        {
            PlayerCatchBox.box.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            PlayerCatchBox.box = null; 
        }
    }
}
