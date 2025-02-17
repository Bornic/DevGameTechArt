using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ColorAndScene : MonoBehaviour
{
    SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {

        sprite = GetComponent<SpriteRenderer>();

        if (transform.position == new Vector3(-2.94f, 4.16f, -6f))
        {
            sprite.color = new Color(159, 190, 0, 255);
        }

        if (transform.position == new Vector3(-2.94f, 2.7f, -6f))
        {
            sprite.color = new Color(254, 114, 118, 255);
        }

        if (transform.position == new Vector3(-2.94f, 1.25f, -6f))
        {
            sprite.color = new Color(255, 149, 64, 255);
        }

        if (transform.position == new Vector3(-2.94f, -0.16f, -6f))
        {
            sprite.color = new Color(255, 190, 64, 255);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
