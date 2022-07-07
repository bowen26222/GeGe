using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject paw;
    public CharacterData playerData;
    public Rigidbody2D body;
    public Vector2 vToBodyLeft = new Vector2(0, 0);
    public Vector2 vToBodyRight = new Vector2(0, 0);
    public Vector2 vToBodyUp = new Vector2(0, 0);
    public bool IsGround;
    public bool CanRotate;
    Vector2 MousePositionStart;
    Vector2 MousePositionEnd;
    public int flag = 0;
    public float LerpOffset = 0.1f;

    void Start()
    {
        paw = GameObject.Find("PawToRotate");
        IsGround = false;
        CanRotate = true;
        playerData.currentEndurance = playerData.maxEndurance;
    }
    void FixedUpdate()
    {
        if(GetComponent<CatchBox>().box == null)
        {
            CanRotate = true;
        }
        MousePositionStart = MousePositionEnd;
        MousePositionEnd = Input.mousePosition;
        Vector2 MouseDistance = MousePositionEnd - MousePositionStart;
        if (MouseDistance.y > 0)
        {
            flag = 1;
            playerData.FlyAble = false;
        }
        else if (MouseDistance.y < 0 && flag == 1)
        {
            flag = 0;
            playerData.FlyAble = true;
        }
        else if(MouseDistance.y < 0 && flag == 0)
        {
            flag = 0;
            playerData.FlyAble = false;
        }

        if (flag == 1) 
        {
            if (Input.GetKey("a"))
            {
                playerData.RightWing = true;
                playerData.LeftWing = false;
            }
            else if(Input.GetKey("d"))
            {
                playerData.LeftWing = true;
                playerData.RightWing = false;
            }
            else
            {
                playerData.LeftWing = true;
                playerData.RightWing = true;
            }
        }
        else
        {
            playerData.LeftWing = false;
            playerData.RightWing = false;
        }
        if (body.velocity.x > 0.3)
        {
            if(CanRotate || paw.transform.rotation.eulerAngles.z>0)
                paw.transform.rotation = Quaternion.Slerp(paw.transform.rotation, Quaternion.Euler(0, 0 , -60), Time.deltaTime * 2f);
            else
                paw.transform.rotation = Quaternion.Slerp(paw.transform.rotation, Quaternion.Euler(0, 0, paw.transform.rotation.eulerAngles.z + 0.1f), Time.deltaTime * 2f);
        }
        else if (body.velocity.x < -0.3)
        {
            if (CanRotate || paw.transform.rotation.eulerAngles.z<0)
                paw.transform.rotation = Quaternion.Slerp(paw.transform.rotation, Quaternion.Euler(0, 0, 60), Time.deltaTime * 2f);
            else
                paw.transform.rotation = Quaternion.Slerp(paw.transform.rotation, Quaternion.Euler(0, 0, paw.transform.rotation.eulerAngles.z - 0.1f), Time.deltaTime * 2f);
        }
        else
        {
            paw.transform.rotation = Quaternion.Slerp(paw.transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * 2f);
        }
        if (playerData.FlyAble == true && playerData.currentEndurance > 0)
        {
            playerData.FlyAble = false;
            if (Input.GetKey("a"))
            {
                body.velocity = Vector2.Lerp(vToBodyLeft, Vector2.zero, LerpOffset);
                
                if (playerData.isOccupied == true)
                {
                    playerData.currentEndurance -= playerData.consumeSpeed;
                }
            }
            else if (Input.GetKey("d"))
            {
                body.velocity = Vector2.Lerp(vToBodyRight, Vector2.zero, LerpOffset);
                if (playerData.isOccupied == true)
                {
                    playerData.currentEndurance -= playerData.consumeSpeed;
                }
            }
            else
            {
                body.velocity = Vector2.Lerp(vToBodyUp, Vector2.zero, LerpOffset);
                if (playerData.isOccupied == true)
                {
                    playerData.currentEndurance -= playerData.consumeSpeed;
                }
            } 
        }
        if (IsGround == true || playerData.isOccupied == false)
        {
             if (playerData.currentEndurance < playerData.maxEndurance)
            {
                 playerData.currentEndurance += playerData.recoverSpeed * Time.deltaTime;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "floor")
        {
            IsGround = true;
        }
        if(collision.gameObject == GetComponent<CatchBox>().box)
        {
            CanRotate = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            IsGround = false;
        }
        if (collision.gameObject == GetComponent<CatchBox>().box)
        {
            CanRotate = true;
        }
    }
}
