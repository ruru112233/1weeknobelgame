using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{
    // タイトルシーンへ遷移
    public void goToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    // リセット
    public void resetButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // ゲームシーンへ遷移
    public void goToGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
