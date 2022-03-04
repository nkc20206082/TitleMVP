using UnityEngine;

public class TitleScenePresenter : MonoBehaviour
{
    //============Model==============
    [Header("--------Model---------")]
    [SerializeField] private TitleSceneModel _TitleSceneModel; 
    [SerializeField] private OptionModel _OptionModel;
    [SerializeField] private SoundMenuModel _SoundMenuModel;
    [SerializeField] private CreditModel _Creditmodel;
    [SerializeField] private BGMOptionModel _BGMOptionModel;
    [SerializeField] private SEOptionModel _SEOptionModel;

    //============View===============
    [Header("---------View---------")]
    [SerializeField] private TitleSceneView _TitleSceneView; 
    [SerializeField] private OptionView _OptionView; 
    [SerializeField] private SoundMenuView _SoundMenuView;
    [SerializeField] private CreditView _Creditview;
    [SerializeField] private BGMOptionView _BGMOptionView; 
    [SerializeField] private SEOptionView _SEOptionView; 

    public void Start()
    {
        //ViewÇ…èâä˙ílÇëóÇÈ
        _TitleSceneView.SelectIcon(_TitleSceneModel.selectnum);
        _OptionView.OptionSelectIcon(_OptionModel.selectnum);
        _SoundMenuView.SoundSelectIcon(_SoundMenuModel.selectnum);
        _BGMOptionView.Volume(_BGMOptionModel.DefaultVolume);
        _SEOptionView.Volume(_SEOptionModel.defaultVolume);

        //===========TiltleScene Event==============
        _TitleSceneModel.SelectEvent += _TitleSceneView.SelectIcon;
        _TitleSceneModel.SelectSEEvent += _TitleSceneView.SelectSE;

        //===========OptionScene Event=============
        _OptionModel.OptionSelected += _OptionView.OptionMenuActive;
        _OptionModel.SelectEvent += _OptionView.OptionSelectIcon;
        _OptionModel.SelectSEEvent += _OptionView.SelectSE;

        //===========SoundScene Event=============
        _SoundMenuModel.SelectEvent += _SoundMenuView.SoundSelectIcon;
        _SoundMenuModel.SelectSEEvent += _SoundMenuView.SelectSE;
        _SoundMenuModel.SoundSelected += _SoundMenuView.SoundMenuActive;

        //===========Credit Event=============
        _Creditmodel.ESCSelected += _Creditview.CreditMenuActive;

        //===========BGM Event==================
        _BGMOptionModel.VolumeUp += _BGMOptionView.Volume;
        _BGMOptionModel.VolumeDown += _BGMOptionView.Volume;
        _BGMOptionModel.SelectSEEvent += _BGMOptionView.SelectSE;

        //============SE Event==================
        _SEOptionModel.VolumeUp += _SEOptionView.Volume;
        _SEOptionModel.VolumeDown += _SEOptionView.Volume;
        _SEOptionModel.VolumeUp += _SEOptionView.TestSE;
        _SEOptionModel.VolumeDown += _SEOptionView.TestSE;
        _SEOptionModel.SelectSEEvent += _SEOptionView.SelectSE;

    }

}
