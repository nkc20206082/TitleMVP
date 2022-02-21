using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEvent : MonoBehaviour
{
    [SerializeField] TitleSceneModel Titlemodel;
    [SerializeField] OptionModel Optionmodel;
    bool _getkeyflg = false;
    bool _select = false;

    void Update()
    {
        if (!_select)
        {
            TitleMenuSelect();
        }
        else
        {
            OptionMenuSelected();
        }
    }

    void TitleMenuSelect()
    {
        float VerSelect = Input.GetAxisRaw("Vertical");
        switch (VerSelect)
        {
            case 1:
                if (!_getkeyflg)
                {
                    Titlemodel.GoBack();
                }
                KeyDown();
                break;
            case -1:
                if (!_getkeyflg)
                {
                    Titlemodel.GoNext();
                }
                KeyDown();
                break;
            case 0:
                KeyUp();
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Titlemodel.DecisionMenu();
            _select = true;
        }
    }

    void OptionMenuSelected()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Optionmodel.EscapeOption();
            _select = false;
        }
    }

    void KeyDown()
    {
        _getkeyflg = true;
    }

    void KeyUp()
    {
        _getkeyflg = false;
    }
}
