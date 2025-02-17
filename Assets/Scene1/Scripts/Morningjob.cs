using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morningjob : MonoBehaviour
{

    [SerializeField] GameObject MenuOn;
    [SerializeField] GameObject MenuOff1;
    [SerializeField] GameObject MenuOff2;
    [SerializeField] GameObject MenuOff3;
    [SerializeField] GameObject MenuBackColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {  
        //
        //меняет цвет и положение слайдера, а так же делает не активными остальные меню
        GameObject.Find("slider").transform.position = new Vector3(-2.94f, -0.16f, -10f);
        GameObject.Find("slider").GetComponent<SpriteRenderer>().color = new Color(1f, 0.7450981f, 0.2509804f, 1f);
        MenuOn.SetActive(true);
        MenuOff1.SetActive(false);
        MenuOff2.SetActive(false);
        MenuOff3.SetActive(false);
        MenuBackColor.GetComponent<SpriteRenderer>().color = new Color(1f, 0.7490196f, 0.1803922f, 1f);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
