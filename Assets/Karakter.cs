using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    GameObject top;
    Rigidbody rb;
    public bool degdi;
    public int guc = 120;
    // Start is called before the first frame update
    public void Sut()
    {
        rb = top.GetComponent<Rigidbody>();
        Vector3 sutDegerler = new Vector3(this.transform.forward.x, Random.Range(0,0.33f), this.transform.forward.z);

        rb.velocity = sutDegerler* guc;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonUp(0) && degdi==true)
        {
            Sut();
        }
    }
    
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="top")
        {
            top = other.gameObject;
            degdi = true;
                
        }
        
    }
    public void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "top")
        {
            degdi = false;
        }
    }
}
