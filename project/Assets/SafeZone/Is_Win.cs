using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Is_Win : MonoBehaviour
{
    private int How_Many_Saved = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Person"  || col.gameObject.tag == "Person_s") {
            How_Many_Saved += 1;
            col.gameObject.tag = "Person_s";
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        GameObject[] Bad_Persons = GameObject.FindGameObjectsWithTag("Person_c");
        GameObject[] Bad_Persons_a = GameObject.FindGameObjectsWithTag("Person_c_attack");

        if (Bad_Persons.Length  == 0 && Bad_Persons_a.Length == 0)
        {
            GameObject[] Last_Person = GameObject.FindGameObjectsWithTag("Person");
            for (int i = 0; i != Last_Person.Length; i += 1) {
                Last_Person[i].tag = "Person_s";
            }
        }
        if (How_Many_Saved == 35) {
            GameObject.FindGameObjectWithTag("Timer").GetComponent<timer_script>().is_stop = true;
            Debug.Log("You Win !");
        }
    }
}
