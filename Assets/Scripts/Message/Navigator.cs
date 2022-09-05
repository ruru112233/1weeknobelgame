using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class Navigator : MonoBehaviour
{
    // �R���[�`���p
    public void MessageCol(string message)
    {
        Text messageText = GameObject.FindWithTag("MessageText").GetComponent<Text>();
        messageText.text = message;
    }

    public async Task Message(string[] messages_str)
    {
        // �e�L�X�gComponent���擾����
        Text messageText = GameObject.FindWithTag("MessageText").GetComponent<Text>();

        TextFader textFader = GameObject.FindWithTag("MessageText").GetComponent<TextFader>();

        foreach (string message_str in messages_str)
        {
            // textFader.enabled = true;
            // ���b�Z�[�W�e�L�X�g���Z�b�g
            messageText.text = message_str;

            while (true)
            {
                await Task.Delay(1);
                if (Application.isEditor)
                {
                    if (Input.GetMouseButtonUp(0)) break;
                }
                else
                {
                    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) break;
                }
            }
        }
    }

    // ���b�Z�[�W�ƃX�v���C�g�I�u�W�F�N�g�������ɕ\������ꍇ
    public async Task MessageObject(string[] messages_str, Sprite sprite)
    {
        // �e�L�X�gCompnent���擾����
        Text messageText = GameObject.FindWithTag("MessageText").GetComponent<Text>();

        setBackGround(sprite, true);

        foreach (string message_str in messages_str)
        {
            // ���b�Z�[�W�e�L�X�g���Z�b�g
            messageText.text = message_str;

            // ��ʂ��^�b�v�����̂�҂�
            // 1ms���Ƀ`�F�b�N����
            while (true)
            {
                await Task.Delay(1);
                if (Application.isEditor)
                {
                    if (Input.GetMouseButtonUp(0)) break;
                }
                else
                {
                    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) break;
                }

            }
        }

        setBackGround(sprite, false);
    }

    public void setBackGround(Sprite sprite, bool showFlag)
    {
        GameObject backGroundObj = GameManager.instance.backGroundImage;
        backGroundObj.SetActive(showFlag);

        if (!showFlag) return;

        Image image = backGroundObj.GetComponent<Image>();
        image.sprite = sprite;

    }

    // �����l���̐ݒ�
    public void setLeftImage(Sprite sprite, bool showFlag)
    {
        GameObject imageObj = GameManager.instance.leftImage;
        imageObj.SetActive(showFlag);

        if (!showFlag) return;

        Image image = imageObj.GetComponent<Image>();
        image.sprite = sprite;
    }

    // �E���l���̐ݒ�
    public void setrightImage(Sprite sprite, bool showFlag)
    {
        GameObject imageObj = GameManager.instance.rightImage;
        imageObj.SetActive(showFlag);

        if (!showFlag) return;

        Image image = imageObj.GetComponent<Image>();
        image.sprite = sprite;
    }

}
