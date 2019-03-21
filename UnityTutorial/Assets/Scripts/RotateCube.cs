using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private GameObject cube;

    public int RotationSpeed = 50;

    private void Start()
    {
        cube = GameObject.Find("Cube");
    }

    private void Update()
    {
        cube.transform.Rotate(new Vector3(0, Time.deltaTime * RotationSpeed, 0));
    }
}