using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class Navigator : MonoBehaviour
{
    // コルーチン用
    public void MessageCol(string message)
    {
        Text messageText = GameObject.FindWithTag("MessageText").GetComponent<Text>();
        messageText.text = message;
    }

    public async Task Message(string[] messages_str)
    {
        // テキストComponentを取得する
        Text messageText = GameObject.FindWithTag("MessageText").GetComponent<Text>();

        TextFader textFader = GameObject.FindWithTag("MessageText").GetComponent<TextFader>();

        foreach (string message_str in messages_str)
        {
            // textFader.enabled = true;
            // メッセージテキストをセット
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

    // メッセージとスプライトオブジェクトが同時に表示する場合
    public async Task MessageObject(string[] messages_str, Sprite sprite)
    {
        // テキストCompnentを取得する
        Text messageText = GameObject.FindWithTag("MessageText").GetComponent<Text>();

        setBackGround(sprite, true);

        foreach (string message_str in messages_str)
        {
            // メッセージテキストをセット
            messageText.text = message_str;

            // 画面がタップされるのを待つ
            // 1ms毎にチェックする
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

    // 左側人物の設定
    public void setLeftImage(Sprite sprite, bool showFlag)
    {
        GameObject imageObj = GameManager.instance.leftImage;
        imageObj.SetActive(showFlag);

        if (!showFlag) return;

        Image image = imageObj.GetComponent<Image>();
        image.sprite = sprite;
    }

    // 右側人物の設定
    public void setrightImage(Sprite sprite, bool showFlag)
    {
        GameObject imageObj = GameManager.instance.rightImage;
        imageObj.SetActive(showFlag);

        if (!showFlag) return;

        Image image = imageObj.GetComponent<Image>();
        image.sprite = sprite;
    }

}
