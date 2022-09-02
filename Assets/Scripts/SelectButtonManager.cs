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
        selectButton1.SetActive(false);
        selectButton2.SetActive(false);
        selectButton3.SetActive(false);
    }
}
