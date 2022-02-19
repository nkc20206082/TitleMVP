using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEvent : MonoBehaviour
{
    [SerializeField] TitleSceneModel titlemodel;
    bool _getkeyflg = false;
    void Update()
    {
        
        float VerSelect = Input.GetAxisRaw("Vertical");
        switch (VerSelect)
        {
            case 1:
                if (!_getkeyflg)
                {
                    titlemodel.GoBack();
                }
                KeyDown();
                break;
            case -1:
                if (!_getkeyflg)
                {
                    titlemodel.GoNext();
                }
                KeyDown();
                break;
            case 0:
                KeyUp();
                break;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            titlemodel.DecisionMenu();
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
