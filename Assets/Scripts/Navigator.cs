using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class Navigator : MonoBehaviour
{
    public async Task Message(string[] messages_str)
    {
        // テキストComponentを取得する
        Text messageText = GameObject.FindWithTag("MessageText").GetComponent<Text>();

        TextFader textFader = GameObject.FindWithTag("MessageText").GetComponent<TextFader>();

        foreach (string message_str in messages_str)
        {
            textFader.enabled = true;
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

}
