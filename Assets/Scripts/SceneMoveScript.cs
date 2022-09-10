using UnityEngine;

public class SceneMoveScript : MonoBehaviour
{
    public int sceneNo = 0;
    public void sceneMove()
    {
        AudioManager.instance.PlaySE(0);
        MessageManager messageManager = GameObject.FindWithTag("MessageManager").GetComponent<MessageManager>();
        
        switch (sceneNo)
        {
            case 0:
                messageManager.Scene0Start();
                break;
            case 1:
                messageManager.Scene1Start();
                break;
            case 2:
                messageManager.Scene2Start();
                break;
            case 3:
                messageManager.Scene3Start();
                break;
            case 4:
                messageManager.Scene4Start();
                break;
            case 5:
                messageManager.Scene5Start();
                break;
            case 6:
                messageManager.Scene6Start();
                break;
            case 7:
                messageManager.Scene7Start();
                break;
            case 8:
                messageManager.Scene8Start();
                break;
            case 9:
                messageManager.Scene9Start();
                break;
            case 10:
                messageManager.Scene10Start();
                break;
            case 11:
                messageManager.Scene11Start();
                break;
            case 12:
                messageManager.Scene12Start();
                break;
            case 13:
                messageManager.Scene13Start();
                break;
            case 14:
                messageManager.Scene14Start();
                break;
            case 15:
                messageManager.Scene15Start();
                break;
            case 16:
                messageManager.Scene16Start();
                break;
            case 17:
                messageManager.Scene17Start();
                break;
            case 18:
                messageManager.Scene18Start();
                break;
            case 19:
                messageManager.Scene19Start();
                break;
            case 20:
                messageManager.Scene20Start();
                break;
            case 21:
                messageManager.Scene21Start();
                break;
            case 22:
                messageManager.Scene22Start();
                break;
            case 23:
                messageManager.Scene23Start();
                break;
        }

    }
}
