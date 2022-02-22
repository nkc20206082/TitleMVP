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

    public enum SelectStatus : int
    {
        GameStart=0,
        Option=1,
        Exit=2
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

    public void DecisionMenu()
    {
        switch (selectnum)
        {
            case (int)SelectStatus.GameStart:
                _GameStart.Select();
                break;
            case (int)SelectStatus.Option:
                _Option.Select();
                break;
            case (int)SelectStatus.Exit:
                _Exit.Select();
                break;
        }
    }
}
