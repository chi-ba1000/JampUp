using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public Button resetButton;

    private void Start()
    {
        // �{�^�����N���b�N���ꂽ�Ƃ���ResetGame���Ăяo��
        resetButton.onClick.AddListener(ResetGame);
    }

    void ResetGame()
    {
        // �Q�[�����̃��Z�b�g�����������Ɏ���
        // ��: �L�����N�^�[�̈ʒu���������A���_���[���ɐݒ�A�Q�[����Ԃ�������Ԃɖ߂��Ȃ�
    }
}
