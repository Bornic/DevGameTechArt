using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMelody : MonoBehaviour
{

    [SerializeField] GameObject SetPos;
    [SerializeField] GameObject GetPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnMouseDown()
    {
        //переключение ползунка при выборе мелодии
        var x = GetPos.transform.position;
        SetPos.transform.position = x + new Vector3(-1.22f,0.94f,5f);




    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
