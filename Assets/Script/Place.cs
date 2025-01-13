using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Place : MonoBehaviour
{
    public GameObject player;
    public GameObject tree;
    public float radius = 5.0f;
    public TextMeshProUGUI messageText;
    public GameObject[] baubles;  
    private bool isInRadius = false;
    public Collect Collect;
    public GameObject Carpet;
    public float time = 5.0f;
    public Collider treeCollider;

    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, tree.transform.position);

       
        if (distance <= radius && !isInRadius)
        {
            messageText.text = "Press E to place Baubles";
            StartCoroutine(HideTextAfterTime(time));
            isInRadius = true;
        }
        else if (distance > radius && isInRadius)
        {
            messageText.text = "";
            isInRadius = false;
        }

        if (isInRadius && Input.GetKeyDown(KeyCode.E))
        {
            if (Collect.score > 0)
            {
                for (int i = 0; i < baubles.Length; i++)
                {
                    if (!baubles[i].activeSelf) 
                    {
                        baubles[i].SetActive(true);  
                        Collect.score--;  
                        break; 
                    }
                }

                if (Collect.score == 0 && AllBaublesPlaced())
                {
                    tree.SetActive(false);
                    treeCollider.enabled = false;
                    Carpet.SetActive(true);
                    messageText.text = "enter the Carpet";
                    StartCoroutine(HideTextAfterTime(time));

                }
            }
            
        }
    }
    bool AllBaublesPlaced()
    {
        for (int i = 0; i < baubles.Length; i++)
        {
            if (!baubles[i].activeSelf)
            {
                return false;
            }
        }
        return true;  
    }
    IEnumerator HideTextAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        messageText.text = "";
    }
    private void OnTriggerEnter(Collider x)
    {
        Debug.Log("Collider entered: " + x.gameObject.name);
        if (x.gameObject.tag == "Carpet")
        {
            Debug.Log("Entering Carpet - Loading Scene");
            SceneManager.LoadScene("04-Scene");
        }
    }

}

