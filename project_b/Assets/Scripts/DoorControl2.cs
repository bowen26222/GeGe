using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//此脚本控制玩家本体触发某trigger时打开的门（单次）
public class DoorControl2 : MonoBehaviour
{
    public GameObject Door;
    bool opened = false;
    
    // Start is called before the first frame update
    void Start()
    {
        opened = false;
        Door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(opened == false && other.gameObject.CompareTag("Player"))
        {
            Door.SetActive(false);
            opened = true;
        }
    }
}
