using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor.Animations;
using System;

[AddComponentMenu("UI/DebugTextComponentName", 11)]
public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TimeTxt;

    private TimeUtil timeUtil;
    private int Index = 0;

    public static GameManager I;

    private void Awake()
    {
        I = this;
        timeUtil = new TimeUtil();
    }

    void FixedUpdate()
    {
        TimeTxt.text = timeUtil.GetCurrentTime();
    }

    public void ValueChange(GameObject gameObject)
    {
        TextMeshProUGUI TMP = gameObject.transform.GetComponentInChildren<TextMeshProUGUI>(); ;
        Button button = gameObject.transform.GetComponentInChildren<Button>(); ;

        if (TMP.text.Length >= 2 && TMP.text.Length <= 10)
            button.interactable = true;
        else
            button.interactable = false;
    }

    public void ActiveSelectUi()
    {
        UIManager.I.SetActive(1, true);
    }

    public void ClickeStartCharacter(int index)
    {
        Index = index;
        PlayerManager.I.SetAnimatorController(index);
        UIManager.I.SetImage(index);
        UIManager.I.SetActive(1, false);
    }

    public void ClickChangeName()
    {
        UIManager.I.SetActive(2, true);
        PlayerManager.I.SetActive(false);
    }


    public void ClickeConfirmName(TextMeshProUGUI TMP)
    {
        PlayerManager.I.SetName(TMP.text);
        PlayerManager.I.SetActive(true);
        UIManager.I.SetActive(0, false);
        UIManager.I.SetActive(2, false);
    }

    public void ClickParticipant(bool flag)
    {
        UIManager.I.SetActive(3, flag);
    }
}
