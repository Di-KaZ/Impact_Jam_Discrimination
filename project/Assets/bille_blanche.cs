using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bille_blanche : MonoBehaviour
{
    public float movementSpeed = 1;
    public GameObject w_circle;
    public GameObject safe_zone;
    private Rigidbody2D body;
    private Vector2 goal;
    private int status = 1;
    void OnMouseDown()
    {
        if (status == 1)
            status = 2;
        else
            status = 1;
    }
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void move_toward_safezone()
    {
        float speedo = 0.01f;
        transform.position = Vector2.MoveTowards(w_circle.transform.position, safe_zone.transform.position, speedo);
    }
    
    void move_randomly_invoke()
    {
        goal = new Vector2(Random.Range(-2f, 2f), Random.Range(-2f, 2f));
        CancelInvoke();
    }

    void move_randomly()
    {
        InvokeRepeating("move_randomly_invoke", 1f, 1f);
        body.MovePosition(body.position + goal * Time.fixedDeltaTime);

    }
    void Update()
    {
    }
    private void FixedUpdate()
    {
        if (status == 1)
            move_toward_safezone();
        else
            move_randomly();
    }
}
