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

        await navigator.Message(new string[] { "����̓e�X�g�ł��B"
                                              ,"�����`��"
                                              ,"�����`"
                                              ,"�����Ƀ��b�Z�[�W��������"
                                              ,"���Ƃ͉����������炢����������Ȃ�����e�L�g�[�ɒ������͂������������ǁA�ق�Ɖ����������炢���̂�������Ȃ��񂾂�ȁ`�B"
        �@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@�@,"��U�A����m�F�͂���Ȋ������ȁB�B�B"});

        messageText.SetActive(false);
        
    }
}
