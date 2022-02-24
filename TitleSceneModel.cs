using UnityEngine;
using System;

public class TitleSceneModel : MonoBehaviour
{
    public int selectnum = 0;
    private const int _MAX_ELEMENT = 3;

    [SerializeField] GameStart _GameStart;
    [SerializeField] Option _Option;
    [SerializeField] Exit _Exit;

    public event Action<float> SelectEvent;

    //タイトルの要素
    public enum SelectStatus : int
    {
        GameStart=0,
        Option=1,
        Exit=2
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

    //決定
    public int DecisionMenu()
    {
        switch (selectnum)
        {
            case (int)SelectStatus.GameStart:
                _GameStart.Select();
                break;
            case (int)SelectStatus.Option:
                _Option.Select();
                return (int)SelectStatus.Option;
            case (int)SelectStatus.Exit:
                _Exit.Select();
                break;
        }
        return default;
    }
}
