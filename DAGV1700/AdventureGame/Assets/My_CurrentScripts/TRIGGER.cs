using UnityEngine;

public class TRIGGER : MonoBehaviour
{
    public Color targetColor = Color.red;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER");
        GetComponent<Renderer>().material.color = targetColor;
    }
}
