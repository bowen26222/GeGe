using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�˽ű�������ұ��崥��ĳtriggerʱ�򿪵��ţ����Σ�
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
