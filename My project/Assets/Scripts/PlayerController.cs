using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 4f;
    public string namePlayer = "ZEEN";
    public GameObject bullets; 
     
    
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        { 
            MovePlayer(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.A))
        { 
            MovePlayer(Vector3.back);
        }     
        
        
         if (Input.GetKeyDown(KeyCode.Space))
        { 
            Shoot();
        }     
    
        
    
    }
    
    private void MovePlayer(Vector3 direction)
    {
     transform.Translate(direction * speed * Time.deltaTime);
    
    }
    private void Shoot()
    {
        Instantiate(bullets, transform.position, transform.rotation);
    
    }

}
