using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collect : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI counter;
    
    void Update()
    {
        counter.text = score.ToString();
    }
    public void OnTriggerEnter(Collider K)
    {
        if (K.gameObject.tag == "Kugel")
        {
            Destroy(K.gameObject);
            score++;
        }
    }
}
