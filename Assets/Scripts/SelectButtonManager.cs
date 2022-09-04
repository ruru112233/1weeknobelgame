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
    public void setSelectButton(int buttonNo, string text, int sceneNo)
    {
        if (buttonNo == 1) 
        {
            // �e�L�X�g�̍X�V
            setButtonText(selectButton1, text);

            // �{�^���ɑJ�ڐ��ݒ�
            setSceneMoveNo(selectButton1, sceneNo);

            // �{�^���̕\��
            selectButton1.SetActive(true);


        }
        else if(buttonNo == 2)
        {
            // �e�L�X�g�̍X�V
            setButtonText(selectButton2, text);
            // �{�^���ɑJ�ڐ��ݒ�
            setSceneMoveNo(selectButton2, sceneNo);
            // �{�^���̕\��
            selectButton2.SetActive(true);
        }
        else if (buttonNo == 3)
        {
            // �e�L�X�g�̍X�V
            setButtonText(selectButton3, text);
            // �{�^���ɑJ�ڐ��ݒ�
            setSceneMoveNo(selectButton3, sceneNo);
            // �{�^���̕\��
            selectButton3.SetActive(true);
        }
    }

    // buttonText�̕ύX
    void setButtonText(GameObject btnObj, string text)
    {
        Text btnText = btnObj.GetComponentInChildren<Text>();
        btnText.text = text;
    }

    // �{�^���ɑJ�ڐ��ݒ�
    void setSceneMoveNo(GameObject selectButton, int sceneNo)
    {
        SceneMoveScript sceneMoveScript = selectButton.GetComponent<SceneMoveScript>();
        sceneMoveScript.sceneNo = sceneNo;
    }

}
