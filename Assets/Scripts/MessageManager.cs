using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class MessageManager : MonoBehaviour
{
    [SerializeField]
    private Navigator navigator = null;

    async void Start()
    {
        await StartMessage();
    }

    async Task StartMessage()
    {
        await Task.Delay(1000);

        await navigator.Message(new string[] { "これはテストです。"
                                              ,"らららら～♪"
                                              ,"わわわわ～"});
    }
}
