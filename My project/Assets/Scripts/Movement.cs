using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 direction = new Vector3 (0f,0f,1f);
    public float speed = 2f; 
    public int attack = 1;
    public int hp = 5;
    public float liveTime = 3f; 
    public GameObject bullets; 


    // Start is called before the first frame update
    void Start()
    {
        Damage(attack);
        Invoke("DestroyDelay", liveTime);
    
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyUp(KeyCode.E))
        { 
            Shoot();
        }
        
        Move();
    }

    private void Move ()
    {
        transform.position += direction * speed * Time.deltaTime;

    
    }
    public void Damage (int value)
    {
        hp = hp - value;

    }
    private void DestroyDelay()
    {
        Destroy(gameObject);


    }
    private void Shoot()
    {
        transform.localScale = transform.localScale * 2f;
    
    }

}
