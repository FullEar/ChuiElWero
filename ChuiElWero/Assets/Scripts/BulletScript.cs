using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rb;
    public float force;
    public float damage = 1f;
  

    // Start is called before the first frame update
    void Start()
    {
       
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 180
    );
           
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        
        var enemBehaviour = collision.GetComponent<EnemyBehaviour>();

        if(enemBehaviour != null)
        {
            enemBehaviour.Takehit(damage);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
