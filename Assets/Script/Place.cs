using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Place : MonoBehaviour
{
    public GameObject player;  
    public GameObject tree;    
    public float radius = 5.0f;  
    public TextMeshProUGUI messageText;  

    private bool isInRadius = false;  

    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, tree.transform.position);

        if (distance <= radius && !isInRadius)
        {
            Debug.Log("In Radius");
            messageText.text = "Press E to place Baubles";
            isInRadius = true;
        }
        else if (distance > radius && isInRadius)
        {
           
            messageText.text = "";
            isInRadius = false;
        }
    }
}
