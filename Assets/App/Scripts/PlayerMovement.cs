using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float sideSpeed = 3f;
    [SerializeField] private float rotationSpeed = 5f;
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        SideMove(horizontalInput);
        RotateModel(horizontalInput);
    }
    private void SideMove(float horizontalInput)
    {
        // transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (transform.position.x <= -2.2)
        {
            transform.position = new Vector3(-2.2f, transform.position.y, 0);
        }
        if (transform.position.x >= 2.2)
        {
            transform.position = new Vector3(2.2f, transform.position.y, 0);
        }
        //transform.Translate(Vector3.right * horizontalInput * sideSpeed * Time.deltaTime);
        transform.position += new Vector3(horizontalInput * sideSpeed * Time.deltaTime, 0, 0);
    }
    private void RotateModel(float horizontalInput)
    {
            Quaternion targetRotation = Quaternion.LookRotation(new Vector3(horizontalInput, 0f, 1f));
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}
