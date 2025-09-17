using UnityEngine;



public class CollectibleItem : MonoBehaviour

{

    private void OnTriggerEnter(Collider other)

    {

        if (other.CompareTag("Player"))

        {
            FindAnyObjectByType<ScoreManager>().AddPoint();
            Debug.Log("Item collected");

            Destroy(gameObject);

        }

    }

}