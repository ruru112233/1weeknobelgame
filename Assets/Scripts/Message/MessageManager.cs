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
        await Scene0();
    }

    async Task Scene0()
    {
        await Task.Delay(1000);
        messageText.SetActive(true);

        await navigator.Message(new string[] { "森の中でいつも寝て怠けるだけの、同じ毎日をすごしていたなまけものがいた。"
                                              ,"【ナマケモノ】だるいなぁ〜"
                                              ,"木にぶら下がっているナマケモノ。"
                                              ,"うっすら目を閉じて寝ようとし始めている。"
                                              ,"ガタッ!"
        　　　　　　　　　　　　　　　　　　　,"マヌケなナマケモノは寝ようとした時爪を滑らせて木から落ちてしまった。"
                                              ,"【ナマケモノ】いたたぁ...ね、眠い..."
                                              ,"木から落ちても寝ようとするナマケモノ。"
                                              ,"目の前に漫画の本がひらいたまま落ちているのに気がつくナマケモノ。"
                                              ,"【ナマケモノ】?"
                                              ,"ナマケモノはゆっくり、とてもゆっくりと近寄る。"
                                              ,"漫画をちらっと見るナマケモノ。"
                                              ,"漫画の中の女性がバスケをして活躍しているシーンのページだった。"
                                              ,"【ナマケモノ】こんなふうに動けたら楽しいだろうなぁ..."
                                              ,"ナマケモノは漫画をみて少しその女性が羨ましく感じていた。"
                                              ,"ページをめくろうとするナマケモノ。"
                                              ,"その時とてつもなく強い光に覆われる。"
                                              ,"..."
                                              ,"目を覚ました。ナマケモノ。"
                                              ,"【ナマケモノ】え!?"
                                              ,"ど、どういうこと???"
                                              ,"ナマケモノは漫画の中の女性の姿になっていた。"
                                              ,"【ナマケモノのチームメイトA】まい!シュート!!"
                                              ,"【ナマケモノ】え!?"
                                              ,"目を覚ましたナマケモノはバスケットボールを持っている。"
                                              ,"バスケの試合中、周りのチームメイトがシュートをすすめる声を上げている。"});

        messageText.SetActive(false);
        
    }
}
