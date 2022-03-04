using UnityEngine;
using System;

public class TitleSceneModel : MonoBehaviour
{
    public int selectnum = 0;
    private const int _MAX_ELEMENT = 3;

    [SerializeField]private GameStartUISelect _GameStartUISelect;
    [SerializeField] private OptionUISelect _OptionUISelect;
    [SerializeField] private ExitUISelect _ExitUISelect;

    public event Action<float> SelectEvent;
    public event Action<float> SelectSEEvent;


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
        SelectSEEvent(selectnum);
    }
    
    //次の項目
    public void GoNext()
    {
        selectnum = (++selectnum) % _MAX_ELEMENT;
        SelectEvent(selectnum);
        SelectSEEvent(selectnum);
    }

    //決定
    public int DecisionMenu()
    {
        switch (selectnum)
        {
            case (int)SelectStatus.GameStart:
                _GameStartUISelect.Select();
                break;
            case (int)SelectStatus.Option:
                _OptionUISelect.Select();
                return (int)SelectStatus.Option;
            case (int)SelectStatus.Exit:
                _ExitUISelect.Select();
                break;
        }
        return default;
    }
}
