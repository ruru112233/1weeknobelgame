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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);

        navigator.MessageCol("森の中でいつも寝て怠けるだけの、同じ毎日をすごしていたなまけものがいた。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】だるいなぁ〜");
        navigator.setBackGround(spriteManager.mori_namakemono, true);

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
        navigator.MessageCol("【ナマケモノのチームメイトA】マイ!シュート!!");
        navigator.setLeftImage(spriteManager.ippan_senshu, true);
        

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】え!?");
        navigator.setLeftImage(spriteManager.kantoku_dere, false);
        navigator.setrightImage(spriteManager.onnanoko_odoroki, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("目を覚ましたナマケモノはバスケットボールを持っている。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("バスケの試合中、周りのチームメイトがシュートをすすめる声を上げている。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        select1();
        navigator.setrightImage(spriteManager.onnanoko_odoroki, false);

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
        selectButtonManager.setSelectButton(3, "更にゾーンに入る", 19);
    }

    // 分岐⑨
    void select9()
    {
        selectButtonManager.setSelectButton(1, "リバウンドしてパス", 12);
        selectButtonManager.setSelectButton(2, "リバウンドしてシュート", 12);
        selectButtonManager.setSelectButton(3, "ダンク", 12);
    }

    // 分岐⑩
    void select10()
    {
        selectButtonManager.setSelectButton(1, "右", 23);
        selectButtonManager.setSelectButton(2, "左", 22);
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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);

        navigator.MessageCol("シュートがスポッと音をたててかっこよく決まる。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ナマケモノに対して歓声が聞こえる。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】な、なにこれ...めっちゃ嬉しい!");
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("喜びのあまりその場を跳ね出すナマケモノ。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("その後も脅威のスピードでシュートを決め続ける。");
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);

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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);

        navigator.MessageCol("ドリブルの仕方がわからずトラベリング。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("えっ?と言わんばかりの顔をしている審判員と目が合うナマケモノ。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】てへ");
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("赤くなる審判員。");
        navigator.setLeftImage(spriteManager.shinpan, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ボールを持って走るナマケモノ。");
        navigator.setLeftImage(spriteManager.shinpan, false);
        navigator.setrightImage(spriteManager.onnanoko_shinken, true);

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

       // messageText.SetActive(false);

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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);

        navigator.MessageCol("ボールを相手チームに取られてシュートされる。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】え!!");
        navigator.setrightImage(spriteManager.onnanoko_odoroki, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ボールを取り返しに行くナマケモノ。");
        navigator.setrightImage(spriteManager.onnanoko_shinken, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("敵チームのボールカットに成功したナマケモノ。");
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, true);

        //messageText.SetActive(false);

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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);

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
        navigator.setrightImage(spriteManager.onnanoko_odoroki, true);
        
        select4();

        //messageText.SetActive(false);
    }

    public void Scene5Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene5());
    }

    public IEnumerator Scene5()
    {
        messageText.SetActive(true);
        navigator.MessageCol("次々と敵チームを抜き去りランニングシュート");
        clickFlag = false;
        navigator.setBackGround(spriteManager.basuke_goal, true);
        navigator.setrightImage(spriteManager.onnanoko_shinken, true);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("シュートが決まった！");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【観客】おぉー、スゲー！！");
        navigator.setrightImage(spriteManager.onnanoko_shinken, false);
        navigator.setBackGround(spriteManager.basuke_court, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ナマケモノは歓声をあびて満面の笑顔だ。");
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【監督】さすがは「マイちゃん」だ！私が教えただけのことはあるなぁ");
        navigator.setLeftImage(spriteManager.kantoku_dere, true);


        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("攻守交替。ナマケモノに向かって、相手がドリブルで攻めてくる。");
        navigator.setLeftImage(spriteManager.kantoku_dere, false);
        navigator.setrightImage(spriteManager.onnanoko_shinken, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】右か左か...どっちだ...");

        //messageText.SetActive(false);

        select10();
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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
        navigator.MessageCol("シュッ！");
        clickFlag = false;
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("シュートが綺麗に決った。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;

        //messageText.SetActive(false);

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
        navigator.setrightImage(spriteManager.onnanoko_odoroki, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
        navigator.MessageCol("パスカットされる。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【監督】おい、マイちゃんのパスを取るんじゃない！");
        navigator.setLeftImage(spriteManager.kantoku_oko, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("そのまま、ゴールを決められてしまった...");
        navigator.setLeftImage(spriteManager.kantoku_oko, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【監督】何やってるんだ！さっさと攻めろ！");
        navigator.setLeftImage(spriteManager.kantoku_oko, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【監督】マイちゃん、ドンマイ！");
        navigator.setLeftImage(spriteManager.kantoku_dere, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("カウンター(シュート入れられてからの速攻攻撃)を行う");
        navigator.setLeftImage(spriteManager.kantoku_oko, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ナマケモノにパスが回ってきた。");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;

        //messageText.SetActive(false);

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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
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

        //messageText.SetActive(false);

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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
        navigator.MessageCol("敵のチームのひとりが笑ってしまい、おじさんにおいかけられて1人退場");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】あ...すみません");
        navigator.setrightImage(spriteManager.onnanoko_odoroki, true);

        //messageText.SetActive(false);

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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
        navigator.MessageCol("鳥が乱入");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】え…");
        navigator.setrightImage(spriteManager.onnanoko_odoroki, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("シュートが外れる");

        //messageText.SetActive(false);

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
        navigator.setrightImage(spriteManager.onnanoko_shinken, true);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
        navigator.MessageCol("上手く敵を交わしてドリブルしてシュート");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】あ...");

        //messageText.SetActive(false);

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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
        navigator.MessageCol("カウンターを受けて敵のシュートが決まる");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】あ...");
        navigator.setrightImage(spriteManager.onnanoko_odoroki, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;

        //messageText.SetActive(false);

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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        navigator.MessageCol("どうする...");

        //messageText.SetActive(false);

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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
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
        navigator.setrightImage(spriteManager.onnanoko_odoroki, true);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
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
        navigator.setrightImage(spriteManager.onnanoko_shinken, true);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
        navigator.MessageCol("ナマケモノは、まねをしてゾーンに入った。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        navigator.MessageCol("【ナマケモノ】え...体が軽い！！");
        clickFlag = false;
        navigator.setrightImage(spriteManager.onnanoko_odoroki, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        navigator.MessageCol("そのまま相手を抜き去る");
        clickFlag = false;
        navigator.setrightImage(spriteManager.onnanoko_odoroki, false);


        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        navigator.MessageCol("【ナマケモノ】やったー！");
        clickFlag = false;
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        navigator.MessageCol("しかし、また目の前にはさっきの敵が立ちふさがった...");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;

        //messageText.SetActive(false);

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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
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
        navigator.setrightImage(spriteManager.shinpan, false);
        navigator.setLeftImage(spriteManager.shinpan, true);
        navigator.MessageCol("【審判】え...");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("審判とナマケモノは目が合った。");
        navigator.setrightImage(spriteManager.onnanoko_shinken, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】シュートォォォ！");
        navigator.setLeftImage(spriteManager.shinpan, false);
        navigator.setrightImage(spriteManager.onnanoko_odoroki, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【審判】は...はいぃぃぃ！");
        navigator.setLeftImage(spriteManager.shinpan, true);
        navigator.setrightImage(spriteManager.onnanoko_odoroki, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("なんと、審判がシュートをした。");
        navigator.setLeftImage(spriteManager.shinpan, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ボールは綺麗な放物線をえがき、ゴールに吸い込まれる形でボールが入った！");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】え！すごっ！");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("そのとき...");

        //messageText.SetActive(false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;

        StartCoroutine(HappyEnd());
    }

    public void Scene22Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene22());
    }

    public IEnumerator Scene22()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);
        navigator.setrightImage(spriteManager.onnanoko_shinken, true);
        navigator.setLeftImage(spriteManager.ippan_senshu, true);
        navigator.MessageCol("敵はナマケモノを左から抜こうとしたが、ナマケモノはそれを読んでいた。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;

        navigator.MessageCol("【ナマケモノ】読み通り！えい！！");
        navigator.setLeftImage(spriteManager.ippan_senshu, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;

        navigator.MessageCol("敵からボールのカットに成功。");
        navigator.setrightImage(spriteManager.ippan_senshu, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;

        navigator.MessageCol("【ナマケモノ】やった。");
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;

        navigator.MessageCol("そのままナマケモノはドリブルで敵ゴールへ突き進む。");
        navigator.setrightImage(spriteManager.onnanoko_shinken, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;

        navigator.MessageCol("しかし目の前には...");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;

        //messageText.SetActive(false);

        Scene13Start();
    }

    public void Scene23Start()
    {
        selectButtonManager.selectButtonOff();
        StartCoroutine(Scene23());
    }

    public IEnumerator Scene23()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);
        navigator.setrightImage(spriteManager.onnanoko_shinken, false);
        navigator.setLeftImage(spriteManager.ippan_senshu, false);
        navigator.MessageCol("ナマケモノは右に動いた。しかし、敵はナマケモノを左から抜かれてしまった。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】あ...");
        navigator.setrightImage(spriteManager.onnanoko_odoroki, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.setrightImage(spriteManager.onnanoko_odoroki, false);
        navigator.setLeftImage(spriteManager.kantoku_oko, true);
        navigator.MessageCol("【監督】何やっとるんだ！お前たち、さっさと走れ！");
        
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【監督】マイちゃん、さっきは大変だったねぇ。そんな時もあるから気にしないでねぇ。");
        navigator.setLeftImage(spriteManager.kantoku_dere, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】なんかこいつ、俺の時だけデレデレしてる気がするんだが...");
        navigator.setrightImage(spriteManager.onnanoko_odoroki, true);
        navigator.setLeftImage(spriteManager.kantoku_dere, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("敵チームのパスは繋がり、そのままゴールされてしまった。");
        navigator.setrightImage(spriteManager.onnanoko_odoroki, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノのチームメイトB】切り替えていこう！マイ、パス。");
        navigator.setLeftImage(spriteManager.ippan_senshu, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("チームメイトはナマケモノへパスを出す。");
        navigator.setLeftImage(spriteManager.ippan_senshu, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】次は点を取らないと。残り時間も少ないし、どうしよう...");
        navigator.setLeftImage(spriteManager.onnanoko_shinken, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        //messageText.SetActive(false);

        select5();
    }

    public IEnumerator BadEnd()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
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
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);

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
        navigator.MessageCol("END1\r\n夢オチEND");

        retry();

    }

    public IEnumerator HappyEnd()
    {
        messageText.SetActive(true);
        navigator.setBackGround(spriteManager.basuke_court, true);
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, false);
        navigator.setLeftImage(spriteManager.onnanoko_hohoemi, false);
        navigator.MessageCol("終了の笛がなる。");
        clickFlag = false;

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ナマケモノのチームは勝った。");
        navigator.setrightImage(spriteManager.onnanoko_odoroki, true);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("歓声が上がる");
        navigator.setrightImage(spriteManager.onnanoko_hohoemi, true);


        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ナマケモノはチームメイトに囲まれる\r\n嬉しそうにするチームメイトたち");
        navigator.setLeftImage(spriteManager.ippan_senshu, true);


        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("【ナマケモノ】やったね！");
        navigator.setLeftImage(spriteManager.ippan_senshu, false);

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("ナマケモノは人として幸せに生きていったとさ");

        yield return new WaitUntil(() => Input.GetMouseButtonDown(0) && clickFlag);
        clickFlag = false;
        navigator.MessageCol("END2\r\n勝利END");

        retry();

    }

}
