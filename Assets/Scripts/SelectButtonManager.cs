using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButtonManager : MonoBehaviour
{
    [SerializeField] GameObject selectButton1, selectButton2, selectButton3;


    // Start is called before the first frame update
    void Start()
    {
        // ゲームスタート時の初期設定
        gameInit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 初期化
    void gameInit()
    {
        selectButtonOff();
    }

    // セレクトボタンの非表示
    public void selectButtonOff()
    {
        selectButton1.SetActive(false);
        selectButton2.SetActive(false);
        selectButton3.SetActive(false);
    }

    // 選択ボタンに文字をセットする
    public void setSelectButton(int buttonNo, string text)
    {
        if (buttonNo == 1) 
        {
            // テキストの更新
            setButtonText(selectButton1, text);
            // ボタンの表示
            selectButton1.SetActive(true);


        }
        else if(buttonNo == 2)
        {
            // テキストの更新
            setButtonText(selectButton2, text);
            // ボタンの表示
            selectButton2.SetActive(true);
        }
        else if (buttonNo == 3)
        {
            // テキストの更新
            setButtonText(selectButton3, text);
            // ボタンの表示
            selectButton3.SetActive(true);
        }
    }

    // buttonTextの変更
    void setButtonText(GameObject btnObj, string text)
    {
        Text btnText = btnObj.GetComponent<Text>();
        btnText.text = text;
    }
}
