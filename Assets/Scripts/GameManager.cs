using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int sceneNo = 0;

    public static GameManager instance;

    public GameObject backGroundImage = null;
    public GameObject leftImage = null; // ç∂ë§ÇÃóßÇøäG
    public GameObject rightImage = null; // âEë§ÇÃóßÇøäG


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GameStart() 
    {
        backGroundImage.SetActive(false);
        leftImage.SetActive(false);
        rightImage.SetActive(false);
    }

    void FadeIn()
    {
        GameObject backGroundObj = GameObject.FindWithTag("BackGroundImage");
        backGroundObj.SetActive(true);
        Image backGroundImage = backGroundObj.GetComponent<Image>();

        backGroundImage.sprite = null;
        backGroundImage.color = new Color32(255,255,255,0);
    }
}
