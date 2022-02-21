using UnityEngine;
using System;

public class TitleSceneModel : MonoBehaviour
{
    public int selectnum = 0;
    private const int MAX_ELEMENT = 3;

    [SerializeField] GameStart gameStart;
    [SerializeField] Option option;
    [SerializeField] Exit exit;

    public enum SelectStatus : int
    {
        GameStart=0,
        Option=1,
        Exit=2
    }

    public event Action<float> SelectEvent;

    public void GoBack()
    {
        selectnum = (selectnum - 1 + MAX_ELEMENT) % MAX_ELEMENT;
        SelectEvent(selectnum);
    }
    
    public void GoNext()
    {
        selectnum = (++selectnum) % MAX_ELEMENT;
        SelectEvent(selectnum);
    }

    public void DecisionMenu()
    {
        switch (selectnum)
        {
            case (int)SelectStatus.GameStart:
                gameStart.Select();
                break;
            case (int)SelectStatus.Option:
                option.Select();
                break;
            case (int)SelectStatus.Exit:
                exit.Select();
                break;
        }
    }
}
