using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class MessageManager : MonoBehaviour
{
    [SerializeField]
    private Navigator navigator = null;

    [SerializeField]
    private GameObject messageText = null;

    async void Start()
    {
        await StartMessage();
    }

    async Task StartMessage()
    {
        await Task.Delay(1000);
        messageText.SetActive(true);

        await navigator.Message(new string[] { "これはテストです。"
                                              ,"らららら～♪"
                                              ,"わわわわ～"
                                              ,"ここにメッセージを書くよ"
                                              ,"あとは何を書いたらいいか分からないからテキトーに長い文章を書きたいけど、ほんと何を書いたらいいのか分からないんだよな～。"
        　　　　　　　　　　　　　　　　　　　,"一旦、動作確認はこんな感じかな。。。"});

        messageText.SetActive(false);
        
    }
}
