using UnityEngine;

public class TitleScenePresenter : MonoBehaviour
{
    [SerializeField] TitleSceneModel _titleSceneModel; 
    [SerializeField] TitleSceneView _titleSceneView; 

    public void Start()
    {
        _titleSceneView.SelectIcon(_titleSceneModel.selectnum);

        _titleSceneModel.SelectEvent += _titleSceneView.SelectIcon;
    }

}
