using System.Collections;
using UnityEngine;

public class MessageManager : MonoBehaviour
{
    [SerializeField]
    private Navigator navigator = null;

    [SerializeField]
    private GameObject messageText = null;

    [SerializeField]
    private SpriteManager spriteManager = null;

    [SerializeField]
    private SelectButtonManager selectButtonManager = null;

    float timer = 0;

    bool clickFlag = false;


    void Start()
    {
        //await Scene0();

        StartCoroutine(Scene0());
    }

    private void Update()
    {
        if (!clickFlag)
        {
            timer += Time.deltaTime;

            if (timer > 0.1f)
            {
                clickFlag = true;
                timer = 0;
            }
        }

    }

    private IEnumerator Scene0()
    {
        AudioManager.instance.PlayBGM(0);

        navigator.MessageCol("森の中でいつも寝て怠けるだけの、同じ毎日をすごしていたなまけものがいた。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】だるいなぁ〜");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("木にぶら下がっているナマケモノ。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("うっすら目を閉じて寝ようとし始めている。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ガタッ!");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("マヌケなナマケモノは寝ようとした時爪を滑らせて木から落ちてしまった。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】いたたぁ...ね、眠い...");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("木から落ちても寝ようとするナマケモノ。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.setBackGround(spriteManager.mori_manga, true);
        navigator.MessageCol("目の前に漫画の本がひらいたまま落ちているのに気がつくナマケモノ。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】?");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ナマケモノはゆっくり、とてもゆっくりと近寄る。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("漫画をちらっと見るナマケモノ。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("漫画の中の女性がバスケをして活躍しているシーンのページだった。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】こんなふうに動けたら楽しいだろうなぁ...");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ナマケモノは漫画をみて少しその女性が羨ましく感じていた。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ページをめくろうとするナマケモノ。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("その時とてつもなく強い光に覆われる。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.setBackGround(spriteManager.mori_manga, false);
        navigator.MessageCol("...");

        
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("目を覚ました。ナマケモノ。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】え!?");
        
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ど、どういうこと???");
        
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        AudioManager.instance.PlayBGM(1);
        navigator.setBackGround(spriteManager.basuke_court, true);
        navigator.MessageCol("ナマケモノは漫画の中の女性の姿になっていた。");
        
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノのチームメイトA】まい!シュート!!");
        navigator.setLeftImage(spriteManager.kantoku_dere, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】え!?");
        navigator.setLeftImage(spriteManager.kantoku_dere, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("目を覚ましたナマケモノはバスケットボールを持っている。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("バスケの試合中、周りのチームメイトがシュートをすすめる声を上げている。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        select1();

    }

    // 分岐①
    void select1()
    {
        navigator.setBackGround(spriteManager.basuke_court, true);
        selectButtonManager.setSelectButton(1, "シュートをする", 1);
        selectButtonManager.setSelectButton(2, "ドリブルをする", 2);
        selectButtonManager.setSelectButton(3, "なにもしない", 3);
    }

    // 分岐②
    void select2()
    {
        navigator.setBackGround(spriteManager.basuke_court, true);
        selectButtonManager.setSelectButton(1, "シュートをする", 4);
        selectButtonManager.setSelectButton(2, "ドリブルをする", 5);
    }

    // 分岐③
    void select3()
    {
        navigator.setBackGround(spriteManager.basuke_court, true);
        selectButtonManager.setSelectButton(1, "シュートをする", 6);
        selectButtonManager.setSelectButton(2, "パスをする", 7);
    }

    // 分岐④
    void select4()
    {
        navigator.setBackGround(spriteManager.basuke_court, true);
        selectButtonManager.setSelectButton(1, "わらう", 8);
        selectButtonManager.setSelectButton(1, "おじさんズラが取れてるよ", 8);
        selectButtonManager.setSelectButton(1, "気づかないフリをしてシュート", 9);
    }

    public void Scene1Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene1());
    }

    public IEnumerator Scene1()
    {

        messageText.SetActive(true);

        // 選択ボタンの非表示
        //selectButtonManager.selectButtonOff();

        navigator.setBackGround(spriteManager.basuke_court, true);

        navigator.MessageCol("シュートがスポッと音をたててかっこよく決まる。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ナマケモノに対して歓声が聞こえる。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】な、なにこれ...めっちゃ嬉しい!");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("喜びのあまりその場を跳ね出すナマケモノ。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("その後も脅威のスピードでシュートを決め続ける。");

        //messageText.SetActive(false);

        select2();
    }

    public void Scene2Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene2());
    }

    public IEnumerator Scene2()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);

        navigator.MessageCol("ドリブルの仕方がわからずトラベリング。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("えっ?と言わんばかりの顔をしている審判員と目が合うナマケモノ。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】てへ");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("赤くなる審判員。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ボールを持って走るナマケモノ。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ゴール下でシュートを決めるナマケモノ。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("見てないふりをする審判員。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【敵チームA】どう考えてもトラベリングでしょう!");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("なんで笛を鳴らさないの!");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("審判に抗議する敵チームのとぼけた顔をする審判員。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【審判員】さ、さっきのはセーフだよ。僕は歩いたところを見ていない。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【敵チームB】はぁ!ふざけんな!");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【審判員】はい、レッドカード!君退場!");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("1人脱落。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("敵チームBは退場した。その後敵チームはひとり追加でベンチから敵チームCを入れた。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ゲーム再開。");

        messageText.SetActive(false);

        select2();
    }

    public void Scene3Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene3());
    }

    public IEnumerator Scene3()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);

        navigator.MessageCol("ボールを相手チームに取られてシュートされる。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】え!!");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ボールを取り返しに行くナマケモノ。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("敵チームのボールカットに成功したナマケモノ。");

        messageText.SetActive(false);

        select3();
    }

    public void Scene4Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene4());
    }

    public IEnumerator Scene4()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);

        navigator.MessageCol("シュートが外れておじさんの頭にあたる。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("そしてズラが落ちる。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("空気が固まる。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】あ...");

        messageText.SetActive(false);
    }

    public void Scene5Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene5());
    }

    public IEnumerator Scene5()
    {
        messageText.SetActive(true);
        navigator.MessageCol("ドリブルが成功してシュートが入る。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("次々と敵チームを抜き去りランニングシュートを決めるナマケモノ。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("歓声をあびる。");

        messageText.SetActive(false);
    }

    public void Scene6Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene6());
    }

    public IEnumerator Scene6()
    {
        messageText.SetActive(true);
        navigator.MessageCol("シュートが決まる。");
        clickFlag = false;
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;

        messageText.SetActive(false);
    }

    public void Scene7Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene7());
    }

    public IEnumerator Scene7()
    {
        messageText.SetActive(true);
        navigator.MessageCol("パスカットされる。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;

        messageText.SetActive(false);
    }

    public void Scene8Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene8());
    }

    public IEnumerator Scene8()
    {
        messageText.SetActive(true);
        navigator.MessageCol("おじさんが怒って追いかけてくる。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【おじさん】何してくれてんやー！");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】え！");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("す、すみません！");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("コートを追いかけ回されるナマケモノ");

        messageText.SetActive(false);
    }

    public void Scene9Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene9());
    }

    public IEnumerator Scene9()
    {
        messageText.SetActive(true);
        navigator.MessageCol("敵のチームのひとりが笑ってしまい、おじさんにおいかけられて1人退場");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】あ...すみません");

        messageText.SetActive(false);
    }

}
