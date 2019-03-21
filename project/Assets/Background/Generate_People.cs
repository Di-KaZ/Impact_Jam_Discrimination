using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate_People : MonoBehaviour
{
    public Transform People;
    private float x = 0;
    private float y = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 50; i++) {
            x = Random.Range(-8.0f, 8.0f);
            y = Random.Range(-8.0f, 8.0f);
            Instantiate(People, new Vector2(x, y), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
