using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Collect : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI Text;

    void Update()
    {
        Text.text = score.ToString();
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
