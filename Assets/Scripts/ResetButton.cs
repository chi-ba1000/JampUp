using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public Button resetButton;

    private void Start()
    {
        // ボタンがクリックされたときにResetGameを呼び出す
        resetButton.onClick.AddListener(ResetGame);
    }

    void ResetGame()
    {
        // ゲーム内のリセット処理をここに実装
        // 例: キャラクターの位置を初期化、得点をゼロに設定、ゲーム状態を初期状態に戻すなど
    }
}
