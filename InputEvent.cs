using System.Collections;
using UnityEngine;

public class InputEvent : MonoBehaviour
{
    [SerializeField] TitleSceneModel _Titlemodel;
    [SerializeField] OptionModel _Optionmodel;
    [SerializeField] SoundModel _Soundmodel;
    [SerializeField] CreditModel _Creditmodel;
    [SerializeField] BGMModel _BGMmodel;
    [SerializeField] SEModel _SEmodel;
    [SerializeField] SelectSEModel _SelectSEmodel;
    //[SerializeField] DecisionSEModel _DecisionSEmodel;

    bool _getkeyflg = false;
    bool _selectinterval = false;
    int _Phasenum = 0;
    const int _PhaseChangenum= 1;
    const int _PhaseSoundnum= 10;

    //縦操作方向
    public enum VerOperation : int
    {
        UP=1,
        DOWN=-1,
        DEFAULT=0
    }
    
    //横操作方向
    public enum HorOperation : int
    {
        RIGHT=1,
        LEFT=-1,
        DEFAULT=0
    }

    //タイトル画面内の遷移
    public enum Phase : int
    {
        TITLEPHASE = 0,
        OPTIONPHASE = 1,
        SOUNDPHASE = 2,
        CREDITPHASE = 3,
        BGMPHASE= SOUNDPHASE + _PhaseSoundnum,
        SEPHASE= 1+SOUNDPHASE + _PhaseSoundnum
    }

    //タイトル画面の要素
    public enum TitleMenu : int
    {
        START = 0,
        OPTION = 1,
        CLOSE = 2
    }

    //オプションの要素
    public enum OptionMenu : int
    {
        RETURN = 0,
        VOLUME = 1,
        CREDIT = 2
    }

    public enum SoundMenu : int
    {
        BGM = 0,
        SE = 1,
        RETURN=2
    }

    void Update()
    {
        //Debug.Log(_Phasenum);
        if (!_selectinterval)
        {
            switch (_Phasenum)
            {
                case (int)Phase.TITLEPHASE:
                    TitleMenuSelect();
                    break;
                case (int)Phase.OPTIONPHASE:
                    OptionMenuSelect();
                    break;
                case (int)Phase.SOUNDPHASE:
                    SoundMenuSelect();
                    break;
                case (int)Phase.CREDITPHASE:
                    CreditSelect();
                    break;
                case (int)Phase.BGMPHASE:
                    BGMOption();
                    break;
                case (int)Phase.SEPHASE:
                    SEOption();
                    break;
            }
        }
    }

    //タイトルの操作
    void TitleMenuSelect()
    {
        float VerSelect = Input.GetAxisRaw("Vertical");
        switch (VerSelect)
        {
            case (int)VerOperation.UP:
                if (!_getkeyflg)
                {
                    _Titlemodel.GoBack();
                    _SelectSEmodel.GoBack();
                }
                KeyDown();
                break;
            case (int)VerOperation.DOWN:
                if (!_getkeyflg)
                {
                    _Titlemodel.GoNext();
                    _SelectSEmodel.GoNext();
                }
                KeyDown();
                break;
            case (int)VerOperation.DEFAULT:
                KeyUp();
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (_Titlemodel.DecisionMenu())
            {
                case (int)TitleMenu.START:
                    break;
                case (int)TitleMenu.OPTION:
                    _Phasenum+= _PhaseChangenum;
                    break;
                case (int)TitleMenu.CLOSE:
                    break;
            }
            StartCoroutine("SelectInterval");
        }
    }

    //オプションの操作
    void OptionMenuSelect()
    {
        float VerSelect = Input.GetAxisRaw("Vertical");
        switch (VerSelect)
        {
            case (int)VerOperation.UP:
                if (!_getkeyflg)
                {
                    _Optionmodel.GoBack();
                    _SelectSEmodel.GoBack();
                }
                KeyDown();
                break;
            case (int)VerOperation.DOWN:
                if (!_getkeyflg)
                {
                    _Optionmodel.GoNext();
                    _SelectSEmodel.GoNext();
                }
                KeyDown();
                break;
            case (int)VerOperation.DEFAULT:
                KeyUp();
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (_Optionmodel.DecisionMenu())
            {
                case (int)OptionMenu.RETURN:
                    _Phasenum -= _PhaseChangenum;
                    StartCoroutine("SelectInterval");
                    break;
                case (int)OptionMenu.VOLUME:
                    _Phasenum+= (int)OptionMenu.VOLUME;
                    break;
                case (int)OptionMenu.CREDIT:
                    _Phasenum +=  (int)OptionMenu.CREDIT;
                    break;
            }
        }
    }

    void SoundMenuSelect()
    {
        float VerSelect = Input.GetAxisRaw("Vertical");
        switch (VerSelect)
        {
            case (int)VerOperation.UP:
                if (!_getkeyflg)
                {
                    _Soundmodel.GoBack();
                    _SelectSEmodel.GoBack();
                }
                KeyDown();
                break;
            case (int)VerOperation.DOWN:
                if (!_getkeyflg)
                {
                    _Soundmodel.GoNext();
                    _SelectSEmodel.GoNext();
                }
                KeyDown();
                break;
            case (int)VerOperation.DEFAULT:
                KeyUp();
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log(_Soundmodel.DecisionMenu());
            switch (_Soundmodel.DecisionMenu())
            {
                case (int)SoundMenu.BGM:
                    _Phasenum +=  _PhaseSoundnum+(int)SoundMenu.BGM;
                    break;
                case (int)SoundMenu.SE:
                    _Phasenum += _PhaseSoundnum  + (int)SoundMenu.SE;
                    break;
                case (int)SoundMenu.RETURN:
                    _Phasenum -= _PhaseChangenum;
                    break;
            }
        }
    }


    void CreditSelect()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _Creditmodel.DecisionMenu();
            _Phasenum -= (int)OptionMenu.CREDIT;
        }
    }

    //BGMの操作
    void BGMOption()
    {
        float HorSelect = Input.GetAxisRaw("Horizontal");
        switch (HorSelect)
        {
            case (int)HorOperation.RIGHT:
                if (!_getkeyflg)
                {
                    _BGMmodel.BGMVoluemeUp();
                }
                KeyDown();
                break;
            case (int)HorOperation.LEFT:
                if (!_getkeyflg)
                {
                    _BGMmodel.BGMVoluemeDown();
                }
                KeyDown();
                break;
            case (int)HorOperation.DEFAULT:
                KeyUp();
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _Phasenum -= _PhaseSoundnum+(int)SoundMenu.BGM;
        }
    }

    //SEの操作
    void SEOption()
    {
        float HorSelect = Input.GetAxisRaw("Horizontal");
        switch (HorSelect)
        {
            case (int)HorOperation.RIGHT:
                if (!_getkeyflg)
                {
                    _SEmodel.SEVoluemeUp();
                    _SelectSEmodel.SEVoluemeUp();
                }
                KeyDown();
                break;
            case (int)HorOperation.LEFT:
                if (!_getkeyflg)
                {
                    _SEmodel.SEVoluemeDown();
                    _SelectSEmodel.SEVoluemeDown();
                }
                KeyDown();
                break;
            case (int)HorOperation.DEFAULT:
                KeyUp();
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _Phasenum -= _PhaseSoundnum  + (int)SoundMenu.SE;
        }
    }

    //キーを押している
    void KeyDown()
    {
        _getkeyflg = true;
    }

    //キーを離した
    void KeyUp()
    {
        _getkeyflg = false;
    }

    IEnumerator SelectInterval()
    {
        _selectinterval = true;
        yield return new WaitForSeconds(0.5f);
        _selectinterval = false;
    }
}
