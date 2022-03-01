using UnityEngine;

public class Credit : MonoBehaviour
{
    [SerializeField] CreditModel _Creditmodel;
    public void Select()
    {
        _Creditmodel.Selected();
        Debug.Log("Credit");
    }
}
