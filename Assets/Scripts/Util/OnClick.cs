using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{
    // タイトルシーンへ遷移
    public void goToTitle()
    {
        AudioManager.instance.PlaySE(0);
        SceneManager.LoadScene("TitleScene");
    }

    // リセット
    public void resetButton()
    {
        AudioManager.instance.PlaySE(0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // ゲームシーンへ遷移
    public void goToGame()
    {
        AudioManager.instance.PlaySE(0);
        SceneManager.LoadScene("GameScene");
    }
}
