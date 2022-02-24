using UnityEngine;
using System;

public class OptionModel : MonoBehaviour
{
    public int selectnum = 0;
    private const int _MAX_ELEMENT = 3;

    //[SerializeField] BGMOperation _BGM;
    //[SerializeField] Option _SE;

    public event Action<float> SelectEvent;
    public event Action<bool> OptionSelected;

    //オプションの内容
    public enum SelectStatus : int
    {
        BGM = 0,
        SE = 1,
        Exit = 2
    }

    //前の項目
    public void GoBack()
    {
        selectnum = (selectnum - 1 + _MAX_ELEMENT) % _MAX_ELEMENT;
        SelectEvent(selectnum);
    }

    //次の項目
    public void GoNext()
    {
        selectnum = (++selectnum) % _MAX_ELEMENT;
        SelectEvent(selectnum);
    }

    //オプションが選ばれた時
    public void Selected()
    {
        OptionSelected(true);
    }

    //オプションを閉じる
    public void EscapeOption()
    {
        OptionSelected(false);
    }

    //決定時処理
    public int DecisionMenu()
    {
        switch (selectnum)
        {
            case (int)SelectStatus.BGM:
                //_BGM.Select();
                return (int)SelectStatus.BGM;

            case (int)SelectStatus.SE:
                //_Option.Select();
                return (int)SelectStatus.SE;

            case (int)SelectStatus.Exit:
                //_Esc.Select();
                selectnum = 0;
                SelectEvent(selectnum);
                EscapeOption();
                return (int)SelectStatus.Exit;
        }
        return default;
    }
}
