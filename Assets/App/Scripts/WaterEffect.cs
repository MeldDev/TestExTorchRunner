using UnityEngine;

public class WaterEffect : MonoBehaviour
{
    private Torch torch;
    private void Start()
    {
        torch = FindObjectOfType<Torch>();
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Water effects");
        torch.ChangeStrengthTorch(-0.7f);
    }
}
