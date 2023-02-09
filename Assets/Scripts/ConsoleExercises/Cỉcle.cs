using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cỉcle : MonoBehaviour
{
    float area;

    [SerializeField]
    int radius;


    // Start is called before the first frame update
    void Start()
    {
        area = Mathf.PI * radius * radius;

        Vector3 scale = transform.localScale;
        scale.x = radius;
        scale.y = radius;
        transform.localScale = scale;

        print("Radius: " + radius + " - Area: " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
