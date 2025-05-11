using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterUIController : MonoBehaviour
{
    public Transform targetPosition; // �L�����N�^�[�����B���ׂ��ʒu
    public GameObject uiElement; // �\������UI�v�f

    private void Update()
    {
        // �L�����N�^�[�ƖڕW�ʒu�̋������v�Z
        float distance = Vector3.Distance(transform.position, targetPosition.position);

        // �L�����N�^�[���ڕW�ʒu�ɓ��B������UI��\��
        if (distance < 2.0f) // �K�؂ȋ�����ݒ�
        {
            uiElement.SetActive(true);
        }
        else
        {
            uiElement.SetActive(false);
        }
    }
}
