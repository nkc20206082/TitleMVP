using System.Collections.Generic;
using UnityEngine;
using System;

public class TitleSceneModel : MonoBehaviour
{
    public int selectnum = 0;
    private int _maxelement = 3;

    [SerializeField] GameStart gameStart;
    [SerializeField] Option option;
    [SerializeField] Exit exit;


    //public CountEvent countevent = new CountEvent();
    public event Action<float> SelectEvent;
    public event Action<float> DecisionEvent;

    public void GoBack()
    {
        selectnum = (selectnum - 1 + _maxelement) % _maxelement;
        SelectEvent(selectnum);
    }
    
    public void GoNext()
    {
        selectnum = (++selectnum) % _maxelement;
        SelectEvent(selectnum);
    }

    public void DecisionMenu()
    {
        switch (selectnum)
        {
            case 0:
                gameStart.Select();
                break;
            case 1:
                option.Select();
                break;
            case 2:
                exit.Select();
                break;
        }
    }
}
