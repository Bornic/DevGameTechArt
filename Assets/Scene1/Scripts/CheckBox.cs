using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBox : MonoBehaviour
{
    bool isOn;
    
    [SerializeField] GameObject onStateObj;
    [SerializeField] GameObject offStateObj;

	
	private void OnMouseDown()
	{
		isOn = !isOn; // ����������� ��������� ��������
		ToggleVisibility(onStateObj, isOn);
		ToggleVisibility(offStateObj, !isOn);
	}

	// ����� ��� ���������/���������� ���������
	private void ToggleVisibility(GameObject obj, bool visible)
	{
		if (obj.TryGetComponent<SpriteRenderer>(out var spriteRenderer))
		{
			spriteRenderer.enabled = visible;
		}
	}

// Update is called once per frame
void Update()
    {
        
    }
}
