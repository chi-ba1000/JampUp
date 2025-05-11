using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUIController : MonoBehaviour
{
    public GameObject uiElement; // 非表示にするUI要素

    private void Start()
    {
        // ゲーム開始時にUI要素を非アクティブにする
        uiElement.SetActive(false);
    }
}
