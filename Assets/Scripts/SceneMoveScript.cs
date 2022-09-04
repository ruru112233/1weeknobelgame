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
        }

    }
}
