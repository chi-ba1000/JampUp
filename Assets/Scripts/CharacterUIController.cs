using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterUIController : MonoBehaviour
{
    public Transform targetPosition; // キャラクターが到達すべき位置
    public GameObject uiElement; // 表示するUI要素

    private void Update()
    {
        // キャラクターと目標位置の距離を計算
        float distance = Vector3.Distance(transform.position, targetPosition.position);

        // キャラクターが目標位置に到達したらUIを表示
        if (distance < 2.0f) // 適切な距離を設定
        {
            uiElement.SetActive(true);
        }
        else
        {
            uiElement.SetActive(false);
        }
    }
}
