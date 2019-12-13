using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    public Transform cameraOrbit;
    public Transform target;
    public GameObject[] forms;
    public GameObject[] deathForms;
    public bool isLastLevel = false;
    private int formIndex = 0;
    
    // Update is called once per frame
    void Update()
    {
        cameraOrbit.position = target.position;
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0);
        transform.LookAt(target.position);
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Trapped");
        }
        if (isLastLevel)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                if (formIndex == forms.Length - 1)
                {
                    GameObject clone = Instantiate(forms[formIndex], target.transform.position, target.transform.rotation);
                    clone.AddComponent<PlayerController>();
                    foreach (Transform child in clone.transform)
                    {
                        Debug.Log("ASDKJHASL:KD");
                        child.gameObject.AddComponent<PlayerDeath>().setValues(deathForms[formIndex], forms[formIndex], this.gameObject);
                    }
                    formIndex = 0;
                    Destroy(target.gameObject);
                    target = clone.transform;
                }
                else
                {
                    GameObject clone = Instantiate(forms[formIndex], target.transform.position, target.transform.rotation);
                    clone.AddComponent<PlayerController>();
                    foreach (Transform child in clone.transform)
                    {
                        child.gameObject.AddComponent<PlayerDeath>().setValues(deathForms[formIndex], forms[formIndex], this.gameObject);
                    }
                    formIndex++;
                    Destroy(target.gameObject);
                    target = clone.transform;
                }
            }
        }
    }
}
