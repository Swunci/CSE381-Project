using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PortalController : MonoBehaviour
{
    public float speed;
    //public GameObject target;
    public Rigidbody rb;
    private Vector3 direction = new Vector3(0, 0, -1);
    public bool moving = false;

    public Animator anim;
    public Image black;
    public GameObject input;
    private InputControl input_script;

    private void Start()
    {
        input_script = input.GetComponent<InputControl>();
        rb = GetComponent<Rigidbody>();
        rb.AddForce(direction * speed);
        //direction = Vector3.Normalize(target.transform.position - transform.position);
    }
    void FixedUpdate()
    {
        if (moving)
        {
            rb.AddForce(direction * speed);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Victory screen
            Debug.Log("Victory");
            moving = false;
            Destroy(other.gameObject);
            input_script.enabled = false;
            StartCoroutine(Fading());
            SceneManager.LoadScene("Trapped");
            
        }
    }
    IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
    }
}
