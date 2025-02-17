using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tone : MonoBehaviour
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
        
        
        //меняет цвет и положение слайдера, а так же делает не активными остальные меню
        //
        GameObject.Find("slider").transform.position = new Vector3(-2.94f, 1.25f, -10f);
        GameObject.Find("slider").GetComponent<SpriteRenderer>().color = new Color(1f, 0.5843138f, 0.2509804f, 1f);
        MenuOn.SetActive(true);
        MenuOff1.SetActive(false);
        MenuOff2.SetActive(false);
        MenuOff3.SetActive(false);
        MenuBackColor.GetComponent<SpriteRenderer>().color = new Color(0.9647059f, 0.5803922f, 0.2588235f, 1f);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
