using UnityEngine;

public class PickUpFire : MonoBehaviour
{
    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other != null && other.tag == "Player")
        {
            Destroy(this.gameObject);
            GameObject.FindObjectOfType<Torch>().PlusStrengthTorch(50);
            GameObject.FindObjectOfType<Score>().PlusScore(50);
        }
    }
}
