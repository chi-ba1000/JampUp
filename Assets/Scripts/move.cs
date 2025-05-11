using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 2.0f; // �ړ����x
    public float moveDistance = 5.0f; // �ړ����鋗��
    private Vector3 initialPosition;
    private bool movingForward = true;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // �O��Ɉړ�
        if (movingForward)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }

        // �ړ��������`�F�b�N���A�i�s������؂�ւ���
        if (Vector3.Distance(initialPosition, transform.position) >= moveDistance)
        {
            movingForward = !movingForward;
        }
    }
}
