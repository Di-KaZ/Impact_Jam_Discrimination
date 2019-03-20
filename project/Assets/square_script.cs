using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square_script : MonoBehaviour
{
    public GameObject circle;
    private float x = 0;
    private float y = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0;i < 100; i++) {
            x = Random.Range(-10.0f, 10.0f);
            y = Random.Range(-10.0f, 10.0f);
            Instantiate(circle, new Vector2(x, y), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
