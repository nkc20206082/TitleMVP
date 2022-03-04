using UnityEngine;

public class CreditUISelect : MonoBehaviour
{
    [SerializeField]private CreditModel _Creditmodel;
    public void Select()
    {
        _Creditmodel.Selected();
        Debug.Log("Credit");
    }
}
