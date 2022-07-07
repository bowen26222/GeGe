using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObstacle : MonoBehaviour
{
    public int damage;
    private PlayerHealth playerHealth;
    
    // Start is called before the first frame update
    public void Start()
    {
        //playerHealth = GameObject.FindGameObjectsWithTag("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && collision.GetType().ToString() == "UnityEngine.PolygonCollider2D")
        {
            playerHealth.DamagePlayer(damage);
        }
    }
}
