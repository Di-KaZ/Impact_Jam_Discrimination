using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private Transform bar;
    // Start is called before the first frame update
    void Start()
    {
        bar = transform.Find("Bar");
       bar.localScale = new Vector3(1f, 1f);
    }

    public void SetSize(float size)
    {
        if (size < 0f)
            size = 0f;
        bar.localScale = new Vector3(size, 1f);
    }
}
