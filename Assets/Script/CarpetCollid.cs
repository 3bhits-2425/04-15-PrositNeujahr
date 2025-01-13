using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarpetCollid : MonoBehaviour
{
    private void OnTriggerEnter(Collider x)
    {
        Debug.Log("Collider entered: " + x.gameObject.name);
        if (x.gameObject.tag == "Player")
        {
            Debug.Log("Entering Carpet - Loading Scene");
            SceneManager.LoadScene("04-Scene");
        }
    }
}
