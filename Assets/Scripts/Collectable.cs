using UnityEngine;



public class CollectibleItem : MonoBehaviour

{

    private void OnTriggerEnter(Collider other)

    {

        if (other.CompareTag("Player"))

        {

            Debug.Log("Item collected");

            Destroy(gameObject);

        }

    }

}