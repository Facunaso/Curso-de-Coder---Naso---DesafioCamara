using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float posicionY = 2f;
    public float velocidadPlayer = 1f;
    public int hp = 5;
    public int attack = 2;
    public int health = 1;
    public string namePlayer = "ZEEN";


    void Start()
    { 
    Debug.Log(hp);

    Damage(attack);
    Life(health);

     transform.position = Vector3.up * posicionY;    
     transform.localScale = transform.localScale * 1f;
     velocidadPlayer = velocidadPlayer + 5f;
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = transform.position + Vector3.forward * Time.deltaTime;  
       MovementPlayer();
       
    }
    void Damage(int value)
    {
        hp = hp - value; 
    }
    void Life(int value)
    {
        hp = hp + value;
    }    
    private void MovementPlayer ()
    {
          transform.position = transform.position + Vector3.forward * velocidadPlayer * Time.deltaTime;


    }

    
}
