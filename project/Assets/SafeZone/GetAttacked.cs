using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAttacked : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;
    private float time = 0.0f;
    public float life = 1.0f;
    // Update is called once per frame

    void OnCollisionStay2D(Collision2D col) {
        if (col.gameObject.tag == "Person_c_attack" || col.gameObject.tag == "Person_c") {
            life -= .0005f;
            healthBar.SetSize(life);
            time -= 0.5f;
        }
    }
    void Update()
    {
        time += Time.deltaTime;
    }
}
