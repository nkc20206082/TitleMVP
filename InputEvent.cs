using UnityEngine;

public class InputEvent : MonoBehaviour
{
    [SerializeField] TitleSceneModel _Titlemodel;
    [SerializeField] OptionModel _Optionmodel;
    bool _getkeyflg = false;
    bool _select = false;


    public enum VerOperation : int
    {
        UP=1,
        DOWN=-1,
        DEFAULT=0
    }
    
    public enum HorrOperation : int
    {
        RIGHT=1,
        LEFT=-1,
        DEFAULT=0
    }
    

    void Update()
    {
        if (!_select)
        {
            TitleMenuSelect();
        }
        else
        {
            OptionMenuSelect();
        }
    }

    void TitleMenuSelect()
    {
        float VerSelect = Input.GetAxisRaw("Vertical");
        switch (VerSelect)
        {
            case (int)VerOperation.UP:
                if (!_getkeyflg)
                {
                    _Titlemodel.GoBack();
                }
                KeyDown();
                break;
            case (int)VerOperation.DOWN:
                if (!_getkeyflg)
                {
                    _Titlemodel.GoNext();
                }
                KeyDown();
                break;
            case (int)VerOperation.DEFAULT:
                KeyUp();
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _Titlemodel.DecisionMenu();
            _select = true;
        }
    }

    void OptionMenuSelect()
    {
        float VerSelect = Input.GetAxisRaw("Vertical");
        switch (VerSelect)
        {
            case (int)VerOperation.UP:
                if (!_getkeyflg)
                {
                    _Optionmodel.GoBack();
                }
                KeyDown();
                break;
            case (int)VerOperation.DOWN:
                if (!_getkeyflg)
                {
                    _Optionmodel.GoNext();
                }
                KeyDown();
                break;
            case (int)VerOperation.DEFAULT:
                KeyUp();
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _select=_Optionmodel.DecisionMenu();
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
