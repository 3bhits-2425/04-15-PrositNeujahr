using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ToDo : MonoBehaviour
{
    private Collect Collect;
    public TextMeshProUGUI toDo;
    public float time = 5.0f;
    void Start()
    {
        toDo.text = "Collect 9 Baubles!";
        StartCoroutine(HideTextAfterTime(time));
    }
    IEnumerator HideTextAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        toDo.text = "";

        if (Collect.score == 9)
        {
            toDo.text = "Find the Christmas Tree!";
            StartCoroutine(HideTextAfterTime(time));
        }
    }
}
