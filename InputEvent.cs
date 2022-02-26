using System.Collections;
using UnityEngine;

public class InputEvent : MonoBehaviour
{
    [SerializeField] TitleSceneModel _Titlemodel;
    [SerializeField] OptionModel _Optionmodel;
    [SerializeField] SoundModel _Soundmodel;
    [SerializeField] BGMModel _BGMmodel;
    [SerializeField] SEModel _SEmodel;
    bool _getkeyflg = false;
    bool _selectinterval = false;
    int _Phasenum = 0;
    const int _PhaseChangenum= 1;

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
        BGMPHASE=3,
        SEPHASE=4
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
        SE = 1
    }
    void Update()
    {
    //    Debug.Log(_Phasenum);
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
            switch (_Optionmodel.DecisionMenu())
            {
                case (int)OptionMenu.RETURN:
                    _Phasenum -= _PhaseChangenum;
                    StartCoroutine("SelectInterval");
                    break;
                case (int)OptionMenu.VOLUME:
                    _Phasenum+= _Phasenum;
                    break;
                case (int)OptionMenu.CREDIT:
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
                }
                KeyDown();
                break;
            case (int)VerOperation.DOWN:
                if (!_getkeyflg)
                {
                    _Soundmodel.GoNext();
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
                    _Phasenum += _PhaseChangenum + (int)SoundMenu.BGM;
                    break;
                case (int)SoundMenu.SE:
                    _Phasenum += _PhaseChangenum + (int)SoundMenu.SE;
                    break;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _Soundmodel.Escape();
            _Phasenum -= _PhaseChangenum;
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
            _Phasenum -= _PhaseChangenum + (int)SoundMenu.BGM;
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
                }
                KeyDown();
                break;
            case (int)HorOperation.LEFT:
                if (!_getkeyflg)
                {
                    _SEmodel.SEVoluemeDown();
                }
                KeyDown();
                break;
            case (int)HorOperation.DEFAULT:
                KeyUp();
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _Phasenum -=_PhaseChangenum + (int)SoundMenu.SE;
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
