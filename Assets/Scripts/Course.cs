using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Course : MonoBehaviour
{
     private float _vitesse = 1f;
    // Start is called before the first frame update
    void Start()
    {
        _vitesse = Random.Range(1f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
     transform.Translate(0f, 0f, _vitesse * Time.deltaTime);
        if (transform.position.x > 4f )
        {
            print(gameObject.name);
        }
    }
}
