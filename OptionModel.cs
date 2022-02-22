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

    public enum SelectStatus : int
    {
        BGM = 0,
        SE = 1,
        Exit = 2
    }

    public void GoBack()
    {
        selectnum = (selectnum - 1 + _MAX_ELEMENT) % _MAX_ELEMENT;
        SelectEvent(selectnum);
    }

    public void GoNext()
    {
        selectnum = (++selectnum) % _MAX_ELEMENT;
        SelectEvent(selectnum);
    }

    public void Selected()
    {
        OptionSelected(true);
    }

    public void EscapeOption()
    {
        OptionSelected(false);
    }

    public bool DecisionMenu()
    {
        switch (selectnum)
        {
            case (int)SelectStatus.BGM:
                //_BGM.Select();
                break;
            case (int)SelectStatus.SE:
                //_Option.Select();
                break;
            case (int)SelectStatus.Exit:
                selectnum = 0;
                EscapeOption();
                return false;
        }
        return default;
    }
}
