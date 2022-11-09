using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    public int numberCube;
    private void OnMouseOver()
    {
        Debug.Log(numberCube);
    }
}
