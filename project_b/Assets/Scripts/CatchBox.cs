using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchBox : MonoBehaviour
{
    public GameObject CatchPoint;
    public GameObject Joint;
    public GameObject Paw;
    public GameObject box;
    public CharacterData playerData;
    public bool isCaught = false;
    public bool IsGround;
    public Vector3 posPaw;
    public float posOffset;
    public float CatchRange = 1;
    public float theGravityScale = 1;
    public float range;
    // Start is called before the first frame update
    void Start()
    {
        playerData.isOccupied = false;
        isCaught = false;
        IsGround = false;
        posPaw = CatchPoint.transform.position;
        posOffset = (CatchPoint.transform.position - posPaw).magnitude;
    }
    private void Update()
    {
        if (box!=null && Input.GetKeyDown(KeyCode.Space))
        {
            box.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            Vector3 curPosition = box.transform.position - CatchPoint.transform.position - new Vector3(0, 0.1f, 0);
            Vector3 curRotation = box.transform.eulerAngles - CatchPoint.transform.eulerAngles;
            box.transform.parent.transform.position = CatchPoint.transform.position;
            box.transform.transform.localPosition = curPosition;
            box.transform.transform.localEulerAngles = curRotation;
            isCaught = true;
            playerData.isOccupied = true;
        }
        if (!Input.GetKey(KeyCode.Space))
        {
            isCaught = false;
            playerData.isOccupied = false;
            box.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        }
        if (isCaught)
        {
            box.transform.parent.position = CatchPoint.transform.position;
            box.transform.parent.rotation = Paw.transform.rotation;
        }
    }
    
}
