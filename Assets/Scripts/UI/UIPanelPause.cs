using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelPause : MonoBehaviour, IMenu
{
    [SerializeField] private Button btnClose, btnRestart;

    private UIMainManager m_mngr;

    private void Awake()
    {
        btnClose.onClick.AddListener(OnClickClose);
        btnRestart.onClick.AddListener(OnClickRestart);
    }

    private void OnDestroy()
    {
        if (btnClose) btnClose.onClick.RemoveAllListeners();
    }

    public void Setup(UIMainManager mngr)
    {
        m_mngr = mngr;
    }

    private void OnClickClose()
    {
        m_mngr.ShowGameMenu();
    }

    public void OnClickRestart()
    {
        Hide();
        m_mngr.Restart();
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
