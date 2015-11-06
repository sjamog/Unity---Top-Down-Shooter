using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag == "Hazard")
        {
            return;
        }

        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, transform.rotation);
        }
        Instantiate(explosion, transform.position, transform.rotation); //as GameObject;   

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
