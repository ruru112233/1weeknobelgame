using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{
    // �^�C�g���V�[���֑J��
    public void goToTitle()
    {
        AudioManager.instance.PlaySE(0);
        SceneManager.LoadScene("TitleScene");
    }

    // ���Z�b�g
    public void resetButton()
    {
        AudioManager.instance.PlaySE(0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // �Q�[���V�[���֑J��
    public void goToGame()
    {
        AudioManager.instance.PlaySE(0);
        SceneManager.LoadScene("GameScene");
    }
}
