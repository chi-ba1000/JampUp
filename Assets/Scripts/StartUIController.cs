using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUIController : MonoBehaviour
{
    public GameObject uiElement; // ��\���ɂ���UI�v�f

    private void Start()
    {
        // �Q�[���J�n����UI�v�f���A�N�e�B�u�ɂ���
        uiElement.SetActive(false);
    }
}
