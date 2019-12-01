using UnityEngine;

public class ZWallController : MonoBehaviour
{
    public float speed;
    //public GameObject target;
    public Rigidbody rb;
    private Vector3 direction = new Vector3 (0, 0, -1);
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //direction = Vector3.Normalize(target.transform.position - transform.position);
    }
    void FixedUpdate()
    {
        rb.AddForce(direction * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }
    }
}
