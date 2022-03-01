using UnityEngine;

public class TitleScenePresenter : MonoBehaviour
{
    //============Model==============
    [Header("--------Model---------")]
    [SerializeField] TitleSceneModel _TitleSceneModel; 
    [SerializeField] OptionModel _OptionModel;
    [SerializeField] SoundModel _SoundModel;
    [SerializeField] CreditModel _Creditmodel;
    [SerializeField] BGMModel _BGMModel;
    [SerializeField] SEModel _SEModel;
    [SerializeField] SelectSEModel _SelectSEModel;

    //============View===============
    [Header("---------View---------")]
    [SerializeField] TitleSceneView _TitleSceneView; 
    [SerializeField] OptionView _OptionView; 
    [SerializeField] SoundView _SoundView;
    [SerializeField] CreditView _Creditview;
    [SerializeField] BGMView _BGMView; 
    [SerializeField] SEView _SEView; 
    [SerializeField] SelectSEView _SelectSEView;

    public void Start()
    {
        //ViewÇ…èâä˙ílÇëóÇÈ
        _TitleSceneView.SelectIcon(_TitleSceneModel.selectnum);
        _OptionView.OptionSelectIcon(_OptionModel.selectnum);
        _SoundView.SoundSelectIcon(_SoundModel.selectnum);
        _BGMView.Volume(_BGMModel.DefaultVolume);
        _SEView.Volume(_SEModel.DefaultVolume);

        //===========TiltleScene Event==============
        _TitleSceneModel.SelectEvent += _TitleSceneView.SelectIcon;
        //_TitleSceneModel.SelectSEEvent += _TitleSceneView.SelectSE;

        //===========OptionScene Event=============
        _OptionModel.OptionSelected += _OptionView.OptionMenuActive;
        _OptionModel.SelectEvent += _OptionView.OptionSelectIcon;
        //_OptionModel.SelectSEEvent += _OptionView.SelectSE;

        //===========SoundScene Event=============
        _SoundModel.SelectEvent += _SoundView.SoundSelectIcon;
        //_SoundModel.SelectSEEvent += _SoundView.SelectSE;
        _SoundModel.SoundSelected += _SoundView.SoundMenuActive;

        //===========Credit Event=============
        _Creditmodel.ESCSelected += _Creditview.CreditMenuActive;

        //===========BGM Event==================
        _BGMModel.VolumeUp += _BGMView.Volume;
        _BGMModel.VolumeDown += _BGMView.Volume;
        //_BGMModel.SelectSEEvent += _BGMView.SelectSE;

        //============SE Event==================
        _SEModel.VolumeUp += _SEView.Volume;
        _SEModel.VolumeDown += _SEView.Volume;
        //_SEModel.SelectSEEvent += _SEView.SelectSE;

        //============SelectSE==================
        _SelectSEModel.SelectSEEvent += _SelectSEView.SelectSE;
        _SelectSEModel.VolumeSEEvent += _SelectSEView.SelectSE;

        //============DecisonSE==================
        _SoundModel.DecisionSEEvent += _SoundView.DecisionSE;
    }

}
