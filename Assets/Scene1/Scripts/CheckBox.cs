using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBox : MonoBehaviour
{
    bool isOn;
    //
    [SerializeField] GameObject onStateObj;
    [SerializeField] GameObject offStateObj;

    private void OnEnable()
    {
        isOn = false;
        onStateObj.SetActive(false);
        offStateObj.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    //По нажатию мыши проверяет активен ли чек бокс и меняет его состояние
    private void OnMouseDown()
    {

        if (isOn)
        {
            // make this off
            isOn = false;
            onStateObj.SetActive(false);
            offStateObj.SetActive(true);
        }
        else
        {
            // make this on
            isOn = true;
            onStateObj.SetActive(true);
            offStateObj.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
