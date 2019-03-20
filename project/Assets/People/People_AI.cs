using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People_AI : MonoBehaviour
{
    public float movementSpeed = 1;
    public GameObject safe_zone;
    private Rigidbody2D body;
    private Vector2 goal;
    private int contamination_state = 0;
    private float timer_beofre_next_contamination = 0.0f;
    private float timer_walk_random = 0.0f;
    private float beofre_change_dir = 1f;

    void OnMouseDown()
    {
        if (this.tag == "Person_c") {
            this.tag = "Person";
            contamination_state = 0;
            this.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
        }
    }
    
    void Start()
    {
        string[] tags = {"Person", "Person_c", "Person", "Person", "Person", "Person", "Person", "Person", "Person_c", "Person_c"};
        goal = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        body = GetComponent<Rigidbody2D>();
        this.tag = tags[Random.Range(0, 10)];
        if (this.tag == "Person_c")
            this.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
    }
    
    void increment_contamination()
    {
        contamination_state += 1;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        int[] greyShade = {255, 150, 0};

        if (col.gameObject.tag == "Wall")
            goal = new Vector2(goal.x * -1, goal.y * -1);
        if (this.tag == "Person" && col.gameObject.tag == "Person_c" && timer_beofre_next_contamination >= 2.0f) {
            contamination_state += 1;
            if (contamination_state > 2)
                contamination_state = 2;
            this.GetComponent<SpriteRenderer>().color = new Color(greyShade[contamination_state],
                                                                  greyShade[contamination_state],
                                                                  greyShade[contamination_state]);
            timer_beofre_next_contamination -= 3.0f;
        }
    }
    void move_toward_safezone()
    {
        float speedo = 0.005f;
        transform.position = Vector2.MoveTowards(this.transform.position, safe_zone.transform.position, speedo);
    }

    void move_randomly()
    {
        if (timer_walk_random >= beofre_change_dir) {
            goal = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timer_walk_random -= beofre_change_dir;
            beofre_change_dir = Random.Range(1f, 2f);
        }
        body.MovePosition(body.position + goal * Time.fixedDeltaTime);
    }

    void Update()
    {
        timer_beofre_next_contamination += Time.deltaTime;
        timer_walk_random += Time.deltaTime;
        if (contamination_state >= 2) {
            contamination_state = 0;
           this.tag = "Person_c";
        }
    }
    private void FixedUpdate()
    {
        if (this.tag == "Person")
            move_toward_safezone();
        else
            move_randomly();
    }
}
