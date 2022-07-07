using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool IsGround;
    private void Awake()
    {
        IsGround = false;
    }
}
