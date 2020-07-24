using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class UIManager : MonoBehaviour
{  
    public Text kanjiText;
    public Text Explanation1;
    public Text Explanation2;
    public Image Mask ;
    public Image fal ;
    public Image TrueUI ;
    public Image FalseUI ;
    //ボタンの表示非表示管理
    //問題ボタン
    public Button ablechangebuttonQ;
    //回答ボタン
    public Button ablechangebuttonA;
    public InputField answerbox;
    //public RectTransform Mask;
    public void UpdateUI(string kanjimondai)
    {
        kanjiText.text = (kanjimondai);
    }

    public void answercheck(string yomi , string dani)
    {
        Explanation1.text = (yomi);
        Explanation2.text = (dani);
    }

    public void ansUI(bool QA , bool QF)
    {
        TrueUI.gameObject.SetActive(QA);
        FalseUI.gameObject.SetActive(QF);
    }

    //漢字のマスクをする表示範囲と位置を管理
    // Qbutton Q=false A=true 
    // Abutton Q=true A=false 
    public void Buttonchange(bool Q, bool A)
    {
        ablechangebuttonQ.gameObject.SetActive(Q);
        Mask.gameObject.SetActive(A);
        ablechangebuttonA.gameObject.SetActive(A);
        answerbox.gameObject.SetActive(A);
        fal.gameObject.SetActive(Q);
        Explanation1.gameObject.SetActive(Q);
        Explanation2.gameObject.SetActive(Q);
    }
    private RectTransform imagemask;
    private RectTransform imagemask2;    public float x,y;　　//変更したいサイズ
    public float xx,yy;　　//変更したいサイズ
    void Start()
    {
        imagemask=GameObject.Find("Mask").GetComponent<RectTransform>();
        imagemask2=GameObject.Find("Question").GetComponent<RectTransform>();
        imagemask.sizeDelta=new Vector2(x,y);
        imagemask.localPosition=new Vector2(xx,(300-y)/2);　//サイズが変更できる　
        imagemask2.sizeDelta=new Vector2(x,y);
        imagemask2.localPosition=new Vector2(xx,0);　//サイズが変更できる　

    }
}
