using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ToDo : MonoBehaviour
{
    public Collect Collect;
    public TextMeshProUGUI toDo;
    public float time = 5.0f;
    private bool hasMethodRun;
    public GameObject pfeil;

    void Start()
    {
        toDo.text = "Collect 9 Baubles!";
        StartCoroutine(HideTextAfterTime(time));
    }
    void Update()
    {
        if (Collect.score >= 9 && !hasMethodRun)
        {
            pfeil.SetActive(true);
            toDo.text = "Find the Christmas Tree!";
            StartCoroutine(HideTextAfterTime(time));
            hasMethodRun = true;
        }
    }

    IEnumerator HideTextAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        toDo.text = "";
    }
}
