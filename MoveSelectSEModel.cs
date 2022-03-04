using System;
using UnityEngine;

public class MoveSelectSEModel : MonoBehaviour
{
    public int selectnum = 0;
    public int volumenum = 0;
    private const int _ELEMENT = 1;
    private const int _MAX_Volume = 10;
    private const int _MIN_Volume = 0;

    public event Action<float> SelectSEEvent;
    public event Action<float> VolumeSEEvent;


    //ëOÇÃçÄñ⁄
    public void GoBack()
    {
        selectnum = (selectnum - 1 + _ELEMENT) % _ELEMENT;
        SelectSEEvent(selectnum);
    }

    //éüÇÃçÄñ⁄
    public void GoNext()
    {
        selectnum = (++selectnum) % _ELEMENT;
        SelectSEEvent(selectnum);
    }

    public void SEVoluemeUp()
    {
        if (volumenum < _MAX_Volume)
        {
            ++volumenum;
            VolumeSEEvent(volumenum);
        }
    }
    
    public void SEVoluemeDown()
    {
        if (volumenum > _MIN_Volume)
        {
            --volumenum;
            VolumeSEEvent(volumenum);
        }
    }
}
