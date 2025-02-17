using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uptime : MonoBehaviour
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
        //������ ���� � ��������� ��������, � ��� �� ������ �� ��������� ��������� ����
        GameObject.Find("slider").transform.position = new Vector3(-2.94f, 4.16f, -10f);
        GameObject.Find("slider").GetComponent<SpriteRenderer>().color = new Color(0.6235294f, 0.7450981f, 0f, 1f);
        MenuOn.SetActive(true);
        MenuOff1.SetActive(false);
        MenuOff2.SetActive(false);
        MenuOff3.SetActive(false);
        MenuBackColor.GetComponent<SpriteRenderer>().color = new Color(0.6235294f, 0.7450981f, 0f, 1f);



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
