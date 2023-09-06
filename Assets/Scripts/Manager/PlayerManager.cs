using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Animations;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private List<AnimatorController> AnimatorControllers;
    public static PlayerManager I;

    private void Awake()
    {
        I = this;
    }

    internal void SetActive(bool flag)
    {
        Player.SetActive(flag);
    }

    internal void SetName(string name)
    {
        Player.GetComponentInChildren<TextMeshProUGUI>().text = name;
    }

    internal void SetAnimatorController(int index)
    {
        Player.GetComponentInChildren<Animator>().runtimeAnimatorController = AnimatorControllers[index];
    }

    internal GameObject GetPlayer()
    {
        return Player;
    }
}
