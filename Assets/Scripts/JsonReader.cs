/*
using System;
using UnityEngine;

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

public class JsonReader : MonoBehaviour
{
    void Start()
    {
        string inputString = Resources.Load<TextAsset>("input").ToString();
        InputJson inputJson = JsonUtility.FromJson<InputJson>(inputString);
        Debug.Log(inputJson.a[0].No);
        Debug.Log(inputJson.a[0].漢字);
        Debug.Log(inputJson.a[0].段位);
        Debug.Log(inputJson.a[0].読み);
    }
}
*/