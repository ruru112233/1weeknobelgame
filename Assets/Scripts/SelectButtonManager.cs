using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButtonManager : MonoBehaviour
{
    [SerializeField] GameObject selectButton1, selectButton2, selectButton3;


    // Start is called before the first frame update
    void Start()
    {
        // �Q�[���X�^�[�g���̏����ݒ�
        gameInit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ������
    void gameInit()
    {
        selectButtonOff();
    }

    // �Z���N�g�{�^���̔�\��
    public void selectButtonOff()
    {
        selectButton1.SetActive(false);
        selectButton2.SetActive(false);
        selectButton3.SetActive(false);
    }

    // �I���{�^���ɕ������Z�b�g����
    public void setSelectButton(int buttonNo, string text)
    {
        if (buttonNo == 1) 
        {
            // �e�L�X�g�̍X�V
            setButtonText(selectButton1, text);
            // �{�^���̕\��
            selectButton1.SetActive(true);


        }
        else if(buttonNo == 2)
        {
            // �e�L�X�g�̍X�V
            setButtonText(selectButton2, text);
            // �{�^���̕\��
            selectButton2.SetActive(true);
        }
        else if (buttonNo == 3)
        {
            // �e�L�X�g�̍X�V
            setButtonText(selectButton3, text);
            // �{�^���̕\��
            selectButton3.SetActive(true);
        }
    }

    // buttonText�̕ύX
    void setButtonText(GameObject btnObj, string text)
    {
        Text btnText = btnObj.GetComponent<Text>();
        btnText.text = text;
    }
}
