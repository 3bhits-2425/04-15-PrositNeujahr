using UnityEngine;

public class Sphere : MonoBehaviour
{
     void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Target")) {
            
            Destroy(gameObject);
        }
    }
}
