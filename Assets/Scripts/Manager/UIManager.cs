using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> UIList;
    [SerializeField] private List<Sprite> sprites;
    [SerializeField] private Image image;

    public static UIManager I;

    void Awake()
    {
        I = this;
    }

    internal void SetImage(int index)
    {
        image.sprite = sprites[index];
    }


    internal void SetActive(int index, bool flag)
    {
        UIList[index].SetActive(flag);
    }


}
