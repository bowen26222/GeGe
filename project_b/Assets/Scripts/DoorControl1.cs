using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl1 : MonoBehaviour
{
    public GameObject theDoor;
    public CharacterData characterData;

    // Start is called before the first frame update
    void Start()
    {
        theDoor.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        theDoor.SetActive(!characterData.isOccupied);
    }
}
