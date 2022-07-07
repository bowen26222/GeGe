using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�����Ա�ǩΪtheTag����Ʒ��ѹ��ס��ť������/��ʧ������
public class TriggeredButton1 : MonoBehaviour
{
    public GameObject objectToControl;
    bool isPushed;
    public string theTag;
    public bool startVanished = true;
    
    // Start is called before the first frame update
    void Start()
    {
        isPushed = false;
        objectToControl.SetActive(!startVanished);
    }

    // Update is called once per frame
    void Update()
    {
        if(isPushed == true)
        {
            objectToControl.SetActive(startVanished);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag(theTag) && isPushed == false)
        {
            isPushed = true;
            objectToControl.SetActive(startVanished);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag(theTag) && isPushed == true)
        {
            isPushed = false;
            objectToControl.SetActive(!startVanished);
        }
    }
}
