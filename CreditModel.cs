using System;
using UnityEngine;

public class CreditModel : MonoBehaviour
{

    public event Action<bool> ESCSelected;

    //�I�v�V�����̓��e
    public enum SelectStatus : int
    {
        Escape = 0
    }

    public void Selected()
    {
        ESCSelected(true);
    }

    //�I�v�V���������
    public void Escape()
    {
        ESCSelected(false);
    }

    //���莞����
    public void DecisionMenu()
    {
        Escape();
    }
}
