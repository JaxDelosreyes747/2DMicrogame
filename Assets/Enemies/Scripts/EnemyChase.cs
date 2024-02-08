using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class EnemyChase : MonoBehaviour
{
    public Transform target;
    public float followDistance;
    public float speed;

    private Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Vector2.Distance(target.position, transform.position) < followDistance)
        {
            rb2D.velocity = (target.position - transform.position).normalized * speed;
        }
    }
}
