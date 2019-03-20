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
        if (col.gameObject.tag == "Person")
            How_Many_Saved += 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (How_Many_Saved == 50)
            Debug.Log("You Win !");
    }
}
