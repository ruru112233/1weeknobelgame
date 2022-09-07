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

    public void Scene0Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene0());
    }

    public IEnumerator Scene0()
    {
        AudioManager.instance.PlayBGM(0);

        navigator.setBackGround(spriteManager.mori_manga, false);

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
        AudioManager.instance.StopMusic();
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
        navigator.setLeftImage(spriteManager.ippan_senshu, true);
        

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
        selectButtonManager.setSelectButton(1, "シュートをする", 1);
        selectButtonManager.setSelectButton(2, "ドリブルをする", 2);
        selectButtonManager.setSelectButton(3, "なにもしない", 3);
    }

    // 分岐②
    void select2()
    {
        selectButtonManager.setSelectButton(1, "シュートをする", 4);
        selectButtonManager.setSelectButton(2, "ドリブルをする", 5);
    }

    // 分岐③
    void select3()
    {
        selectButtonManager.setSelectButton(1, "シュートをする", 6);
        selectButtonManager.setSelectButton(2, "パスをする", 7);
    }

    // 分岐④
    void select4()
    {
        selectButtonManager.setSelectButton(1, "わらう", 8);
        selectButtonManager.setSelectButton(2, "おじさんズラが取れてるよ", 8);
        selectButtonManager.setSelectButton(3, "気づかないフリをしてシュート", 9);
    }

    // 分岐⑤
    void select5()
    {
        selectButtonManager.setSelectButton(1, "シュートする", 10);
        selectButtonManager.setSelectButton(2, "ドリブルする", 11);
    }

    // 分岐⑥
    void select6()
    {
        selectButtonManager.setSelectButton(1, "シュートする", 13);
        selectButtonManager.setSelectButton(2, "パスする", 13);
        selectButtonManager.setSelectButton(3, "審判にパスする", 21);
    }

    // 分岐⑦
    void select7()
    {
        selectButtonManager.setSelectButton(1, "パスする", 14);
        selectButtonManager.setSelectButton(2, "シュートする", 16);
        selectButtonManager.setSelectButton(3, "まねする", 17);
    }

    // 分岐⑧
    void select8()
    {
        selectButtonManager.setSelectButton(1, "にらむ", 15);
        selectButtonManager.setSelectButton(2, "シュートする", 18);
        selectButtonManager.setSelectButton(3, "ゾーンに入る", 19);
    }

    // 分岐⑨
    void select9()
    {
        selectButtonManager.setSelectButton(1, "リバウンドしてパス", 12);
        selectButtonManager.setSelectButton(2, "リバウンドしてシュート", 12);
        selectButtonManager.setSelectButton(3, "ダンク", 12);
    }

    void retry()
    {
        messageText.SetActive(true);
        selectButtonManager.setSelectButton(1, "もう一度遊ぶ", 0);
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

        navigator.setBackGround(spriteManager.basuke_goal, true);

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
        navigator.setBackGround(spriteManager.basuke_goal, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("見てないふりをする審判員。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【敵チームA】どう考えてもトラベリングでしょう!\r\nなんで笛を鳴らさないの!");
        navigator.setLeftImage(spriteManager.ippan_senshu, true);
        navigator.setBackGround(spriteManager.basuke_court, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("審判に抗議したが、とぼけた顔をする審判員。");
        navigator.setLeftImage(spriteManager.ippan_senshu, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【審判員】さ、さっきのはセーフだよ。僕は歩いたところを見ていない。");
        navigator.setrightImage(spriteManager.shinpan, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【敵チームB】はぁ!ふざけんな!");
        navigator.setLeftImage(spriteManager.ippan_senshu, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【審判員】はい、レッドカード!君退場!");
        navigator.setrightImage(spriteManager.shinpan, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("1人脱落。");
        navigator.setLeftImage(spriteManager.ippan_senshu, false);
        navigator.setrightImage(spriteManager.shinpan, false);

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

        select4();

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
        navigator.setBackGround(spriteManager.basuke_goal, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("次々と敵チームを抜き去りランニングシュートを決めるナマケモノ。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("歓声をあびる。");

        messageText.SetActive(false);

        Scene13Start();
    }

    public void Scene6Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene6());
    }

    public IEnumerator Scene6()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_goal, true);
        navigator.MessageCol("シュートが決まる。");
        clickFlag = false;
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;

        messageText.SetActive(false);

        Scene13Start();
    }

    public void Scene7Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene7());
    }

    public IEnumerator Scene7()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);
        navigator.MessageCol("パスカットされる。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("カウンター(シュート入れられてからの速攻攻撃)を行う");
        
        messageText.SetActive(false);

        select6();
    }

    public void Scene8Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene8());
    }

    public IEnumerator Scene8()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);
        navigator.MessageCol("おじさんが怒って追いかけてくる。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【おじさん】何してくれてんやー！");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】え！\r\nす、すみません！");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("コートを追いかけ回されるナマケモノ");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("もう試合どころではない...\r\n～ゲームオーバー～");

        messageText.SetActive(false);

        retry();
    }

    public void Scene9Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene9());
    }

    public IEnumerator Scene9()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);
        navigator.MessageCol("敵のチームのひとりが笑ってしまい、おじさんにおいかけられて1人退場");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】あ...すみません");

        messageText.SetActive(false);

        select5();
    }

    public void Scene10Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene10());
    }

    public IEnumerator Scene10()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_goal, true);
        navigator.MessageCol("鳥が乱入");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】え…");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("シュートが外れる");

        messageText.SetActive(false);

        select9();
    }

    public void Scene11Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene11());
    }

    public IEnumerator Scene11()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_goal, true);
        navigator.MessageCol("上手く敵を交わしてドリブルしてシュート");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】あ...");

        messageText.SetActive(false);

        StartCoroutine(TrueEnd());
    }

    public void Scene12Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene12());
    }

    public IEnumerator Scene12()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);
        navigator.MessageCol("カウンターを受けて敵のシュートが決まる");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】あ...");

        messageText.SetActive(false);

        StartCoroutine(BadEnd());
    }

    public void Scene13Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene13());
    }

    public IEnumerator Scene13()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);
        navigator.MessageCol("オーラをまとったような敵が前に立ふさがる");
        clickFlag = false;
        navigator.setLeftImage(spriteManager.tokushu_senshu, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        navigator.setLeftImage(spriteManager.ippan_senshu, false);

        messageText.SetActive(false);

        select7();
    }

    public void Scene14Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene14());
    }

    public IEnumerator Scene14()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);
        navigator.MessageCol("犬が乱入してきて犬にパスカットされて敵ボールになる");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        
        messageText.SetActive(false);

        StartCoroutine(Scene12());
    }

    public void Scene15Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene15());
    }

    public IEnumerator Scene15()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);
        navigator.MessageCol("ボールを取られてシュートされる");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);

        messageText.SetActive(false);

        StartCoroutine(BadEnd());
    }

    public void Scene16Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene16());
    }

    public IEnumerator Scene16()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_goal, true);
        navigator.MessageCol("外す");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);

        messageText.SetActive(false);

        StartCoroutine(Scene12());
    }

    public void Scene17Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene17());
    }

    public IEnumerator Scene17()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);
        navigator.MessageCol("ゾーンに入って抜く");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);

        messageText.SetActive(false);

        select8();
    }

    public void Scene18Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene18());
    }

    public IEnumerator Scene18()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_goal, true);
        navigator.MessageCol("シュートを外すが仲間がリバウンドをとってシュートをいれる");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);

        messageText.SetActive(false);

        StartCoroutine(TrueEnd());
    }

    public void Scene19Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene19());
    }

    public IEnumerator Scene19()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_goal, true);
        navigator.MessageCol("ゴールが決まる");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);

        messageText.SetActive(false);

        StartCoroutine(HappyEnd());
    }

    public void Scene20Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene20());
    }

    public IEnumerator Scene20()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);
        navigator.MessageCol("カウンター(シュート入れられてからの速攻攻撃)を行う");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);

        messageText.SetActive(false);
    }

    public void Scene21Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene21());
    }

    public IEnumerator Scene21()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_goal, true);
        navigator.setrightImage(spriteManager.shinpan, true);
        navigator.MessageCol("審判がシュートしてくれる");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ゴール");
        navigator.setrightImage(spriteManager.shinpan, false);

        messageText.SetActive(false);
    }

    public IEnumerator BadEnd()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);
        navigator.MessageCol("終了の笛がなる");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ナマケモノのチームは敗北した。\r\nナマケモノはナマケモノの姿に戻ってしまう");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【チームメイト】きゃあー！！");
        navigator.setLeftImage(spriteManager.ippan_senshu, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("みんなに逃げられたり、物を投げられるナマケモノ");
        navigator.setLeftImage(spriteManager.ippan_senshu, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】そ、そんなぁ");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("END3\r\n敗北END");

        retry();

    }

    public IEnumerator TrueEnd()
    {
        messageText.SetActive(true);
        navigator.MessageCol("終了の笛がなる");
        clickFlag = false;
        navigator.setBackGround(spriteManager.mori_manga, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ナマケモノのチームは勝ったと思った。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.setBackGround(spriteManager.mori_sleep, true);
        navigator.MessageCol("しかし目が覚めると森の中にいた。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ナマケモノはナマケモノの姿に戻ってしまっていた。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】なんだぁ夢かぁ、もう少し寝ようかな...zzz");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("END1\r\n寝落ちEND");

        retry();

    }

    public IEnumerator HappyEnd()
    {
        messageText.SetActive(true);
        navigator.MessageCol("終了の笛がなる。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ナマケモノのチームは勝った。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("歓声が上がる");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ナマケモノはチームメイトに囲まれる\r\n嬉しそうにするチームメイトたち");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】やったね！");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ナマケモノは人として幸せに生きていったとさ");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("END2\r\n勝利END");

        retry();

    }

}
