using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform player;
    public float offset;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(player != null)
        {
            if(transform.position != player.position)
            {
                Vector3 playerPos = player.position;
                transform.position = Vector3.Lerp(transform.position, playerPos, offset);
            }
        }
    }

    void Update()
    {
        
    }
}
