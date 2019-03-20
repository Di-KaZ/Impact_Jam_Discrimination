using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bille_blanche : MonoBehaviour
{
    public float movementSpeed = 1;
    public GameObject w_circle;
    public GameObject safe_zone;
    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
//        Vector2 p_circle = GameObject.Find("w_circle").transform.position;
//        Vector2 p_safe_zone = GameObject.Find("safe_zone").transform.position;
        float speedo = 0.01f;
         transform.position = Vector2.MoveTowards(w_circle.transform.position, safe_zone.transform.position, speedo);
    }
}
