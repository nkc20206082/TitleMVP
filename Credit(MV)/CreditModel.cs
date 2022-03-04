using System;
using UnityEngine;

public class CreditModel : MonoBehaviour
{

    public event Action<bool> ESCSelected;

    //オプションの内容
    public enum SelectStatus : int
    {
        Escape = 0
    }

    public void Selected()
    {
        ESCSelected(true);
    }

    //オプションを閉じる
    public void Escape()
    {
        ESCSelected(false);
    }

    //決定時処理
    public void DecisionMenu()
    {
        Escape();
    }
}
