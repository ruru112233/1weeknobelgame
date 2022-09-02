using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{
    // �^�C�g���V�[���֑J��
    public void goToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    // ���Z�b�g
    public void resetButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // �Q�[���V�[���֑J��
    public void goToGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
