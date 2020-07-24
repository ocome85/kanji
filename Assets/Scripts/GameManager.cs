using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
//using System.Text.Json;

[Serializable]
public class InputJson
{ 
    public A[] a;
}

[Serializable]
public class A
{
    public string No;
    public string 漢字;
    public string 段位;
    public string 読み;
}

public class GameManager : MonoBehaviour
{
    public UIManager StageUI;
    public string dani;
    public string yomi;
    public string kanji;
    public Text ACheck;
    public string asn;
    public void Quizbutton()
    {
        //input.jsonからデータを取得する
        string inputString = Resources.Load<TextAsset>("kanji").ToString();
        InputJson inputJson = JsonUtility.FromJson<InputJson>(inputString);
       // Debug.Log(inputJson.a[0].No);
        //Debug.Log(inputJson.a[0].漢字);
        //Debug.Log(inputJson.a[0].段位);
        //Debug.Log(inputJson.a[0].読み);

        
        System.Random r = new System.Random();
        int i1 = r.Next(0,2137);
        /*
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(1, "北");
        dic.Add(2, "県");
        dic.Add(3, "県");
        */
        //Debug.Log(i1);
        //Debug.Log(inputJson.a[i1].漢字);
        StageUI.UpdateUI(inputJson.a[i1].漢字);
        StageUI.Buttonchange(false,true);
        dani=inputJson.a[i1].段位;
        yomi=inputJson.a[i1].読み;
        kanji=inputJson.a[i1].漢字;  
        StageUI.ansUI(false,false);
    }
    public void AnsButton()
    {
        
        StageUI.Buttonchange(true,false);
        StageUI.answercheck(yomi,dani);

        //正誤確認 UI表示切替

        asn=ACheck.text;
        if (kanji==asn)
        {
            StageUI.ansUI(true,false);
        }
        else 
        {
            StageUI.ansUI(false,true);
        }




        //StageUI.answercheck(inputJson.a[i1].読み,inputJson.a[i1].段位);
        //StageUI.(inputJson.a[i1].漢字);

    }

}
