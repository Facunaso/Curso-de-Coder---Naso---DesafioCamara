using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 4f;
    public string namePlayer = "ZEEN";
    public GameObject bullets;
    public float cameraAxisX = 0f; 
     
    
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
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
    public void RotatePlayer()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        Quaternion newRotation = Quaternion.Euler(0, cameraAxisX, 0);
        transform.rotation = Quaternion.Lerp (transform.rotation, newRotation, 2f * Time.deltaTime);

    }

}
