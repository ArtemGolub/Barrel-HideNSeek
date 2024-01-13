using UnityEngine;
[RequireComponent(typeof(PopupView))]
public class PopupController : MonoBehaviour
{
    private PopupView _view;
    private PopupModel _model;
    
    private void Awake()
    {
        _model = new PopupModel();
        _view = GetComponent<PopupView>();
    }
    void Start()
    {
        HideAllPopups();
        EventManager.current.Lose.AddListener(LosePopUp);
        EventManager.current.Win.AddListener(WinPopUp);
    }
    
    private void WinPopUp()
    { 
        _view.ShowPopUp(_view.WinPopUp);
    }
    
    private void LosePopUp()
    {
        _view.ShowPopUp(_view.LosePopUp);
    }
    private void HideAllPopups()
    {
        _view.HidePopUp(_view.WinPopUp);
        _view.HidePopUp(_view.LosePopUp);
    }
    
    
}
