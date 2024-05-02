using UnityEngine;

//https://micha-l-davis.medium.com/coding-challenge-a-bouncing-ball-9841d66d6988
public class BallBouncer : MonoBehaviour 
{
    public Vector3 direction;
    public float speed;
    public Vector3 velocity;

    private void FixedUpdate()
    {
        velocity = direction * speed; 
        transform.Translate(velocity * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision) 
    {
        direction = collision.GetContact(0).normal;
    }
}

//https://unity3d.college/2017/07/03/using-vector3-reflect-to-cheat-ball-bouncing-physics-in-unity/
// public class BallBouncer : MonoBehaviour
// {
//     [SerializeField]
//     [Tooltip("Just for debugging, adds some velocity during OnEnable")]
//     private Vector3 initialVelocity;

//     [SerializeField]
//     private float minVelocity = 10f;

//     private Vector3 lastFrameVelocity;
//     private Rigidbody rb;
    
//     private void OnEnable()
//     {
//         rb = GetComponent<Rigidbody>();
//         rb.velocity = initialVelocity;
//     }

//     private void Update()
//     {
//         lastFrameVelocity = rb.velocity;
//     }

//     private void OnCollisionEnter(Collision collision)
//     {
//         Bounce(collision.contacts[0].normal);
//     }

//     private void Bounce(Vector3 collisionNormal)
//     {
//         var speed = lastFrameVelocity.magnitude;
//         var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);

//         Debug.Log("Out Direction: " + direction);
//         rb.velocity = direction * Mathf.Max(speed, minVelocity);
//     }
// }