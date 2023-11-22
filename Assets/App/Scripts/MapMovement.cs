using UnityEngine;

public class MapMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    public void SetSpeed(float speed)
    {
        moveSpeed = speed;  
    }
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
