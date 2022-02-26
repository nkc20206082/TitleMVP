using UnityEngine;

public class Volume : MonoBehaviour
{
    [SerializeField] SoundModel _Soundmodel;
    public void Select()
    {
        _Soundmodel.Selected();
        Debug.Log("Volume");
    }
}
