using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        GameObject[] Bad_Persons = GameObject.FindGameObjectsWithTag("Person_c");
        GameObject[] Good_Person = GameObject.FindGameObjectsWithTag("Person");
        if (Good_Person.Length == 0) {
            for (int i = 0; i != Bad_Persons.Length; i += 1) {
                    Bad_Persons[i].tag = "Person_c_attack";
                }
                return;
        }
        else if ((Bad_Persons.Length / Good_Person.Length) * 100 >= 70) {
            for (int i = 0; i != Bad_Persons.Length; i += 1) {
                Bad_Persons[i].tag = "Person_c_attack";
            }
        }
    }
}
