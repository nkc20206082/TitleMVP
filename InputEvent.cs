using UnityEngine;

public class InputEvent : MonoBehaviour
{
    [SerializeField] TitleSceneModel _Titlemodel;
    [SerializeField] OptionModel _Optionmodel;
    [SerializeField] BGMModel _BGMmodel;
    [SerializeField] SEModel _SEmodel;
    bool _getkeyflg = false;
    int _Phasenum = 0;
    const int _PhaseChangenum= 1;

    //�c�������
    public enum VerOperation : int
    {
        UP=1,
        DOWN=-1,
        DEFAULT=0
    }
    
    //���������
    public enum HorOperation : int
    {
        RIGHT=1,
        LEFT=-1,
        DEFAULT=0
    }

    //�^�C�g����ʓ��̑J��
    public enum Phase : int
    {
        TITLEPHASE = 0,
        OPTIONPHASE = 1,
        BGMPHASE=2,
        SEPHASE=3
    }

    //�^�C�g����ʂ̗v�f
    public enum TitleMenu : int
    {
        START = 0,
        OPTION = 1,
        CLOSE = 2
    }

    //�I�v�V�����̗v�f
    public enum OptionMenu : int
    {
        BGM = 0,
        SE = 1,
        EXIT = 2
    }
    void Update()
    {
        switch (_Phasenum)
        {
            case (int)Phase.TITLEPHASE:
                TitleMenuSelect();
                break;
            case (int)Phase.OPTIONPHASE:
                OptionMenuSelect();
                break;
            case (int)Phase.BGMPHASE:
                BGMOption();
                break;
            case (int)Phase.SEPHASE:
                SEOption();
                break;
        }
        Debug.Log(_Phasenum);

    }

    //�^�C�g���̑���
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
        }
    }

    //�I�v�V�����̑���
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
                case (int)OptionMenu.BGM:
                    _Phasenum += _PhaseChangenum+(int)OptionMenu.BGM;
                    break;
                case (int)OptionMenu.SE:
                    _Phasenum += _PhaseChangenum + (int)OptionMenu.SE;
                    break;
                case (int)OptionMenu.EXIT:
                    _Phasenum -= _PhaseChangenum;
                    break;
            }
        }
    }

    //BGM�̑���
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
            _Phasenum = _PhaseChangenum + (int)OptionMenu.BGM;
        }
    }

    //SE�̑���
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
            _Phasenum =_PhaseChangenum + (int)OptionMenu.SE;
        }
    }

    //�L�[�������Ă���
    void KeyDown()
    {
        _getkeyflg = true;
    }

    //�L�[�𗣂���
    void KeyUp()
    {
        _getkeyflg = false;
    }
}
