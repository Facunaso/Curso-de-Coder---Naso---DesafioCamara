using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    [Range(1f, 10f)]
    private float speed = 2f;


    [SerializeField]
    [Range(0, 2)]
    private int typeEnemy = 0;

    enum EnemyTypes { Sprinter, Hunter, Shooter };
    [SerializeField] EnemyTypes enemyType;

    [SerializeField] Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
        switch (enemyType)
        {
            case EnemyTypes.Sprinter:
                MoveForward();
                break;
            case EnemyTypes.Hunter:
                ChasePlayer();
                break;
            case EnemyTypes.Shooter:
                RotateAroundPlayer();
                break;
        }
    }

    private void MoveForward()
    {

    }
    private void ChasePlayer()
    {
        LookPlayer();
        Vector3 direction = (playerTransform.position - transform.position);
        if (direction.magnitude > 1f)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;
           
        }
        
    }
    private void RotateAroundPlayer()
    {
        LookPlayer();
        transform.RotateAround(playerTransform.position, Vector3.up, 10f * Time.deltaTime);
    }
    private void LookPlayer()
    {
        transform.LookAt(playerTransform);
    }
}
